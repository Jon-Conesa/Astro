using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Globalization;
using ASTRObeta.Properties;
using windowform = System.Windows.Forms;

namespace ASTRObeta
{
	/// <summary>
	/// Interaction logic for alarmayhora.xaml
	/// </summary>
	public partial class alarmayhora : Window
	{
        DispatcherTimer laHora;
        DispatcherTimer laHoraa;
		public alarmayhora()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
            conftiemp();
            valoresiniciales();
            cconfg();
		}

        void conftiemp()
        {
            laHora = new DispatcherTimer();
            laHora.Interval = new TimeSpan(0, 0, 1);
            laHora.Tick += laHora_Tick;
            laHora.Start();

        }
        void cconfg()
        {
            laHoraa = new DispatcherTimer();
            laHoraa.Interval = new TimeSpan(0, 0, 1);
            laHoraa.Tick += laHoraa_Tick;
            laHoraa.Start();
        }

        void laHoraa_Tick(object sender, EventArgs e)
        {
            DateTime nowa = DateTime.Now;
            lhora_Copy.Content = nowa.ToString("hh:mm:ss tt", new CultureInfo("en-US"));
        }
        void laHora_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lhora.Content = now.ToString("hh:mm:ss tt", new CultureInfo("en-US"));
            string horaactual = now.ToString("h:mm:ss tt", new CultureInfo("en-US"));
            string horaguardada = Settings.Default.vhora +":"+ Settings.Default.vmin +":00 "+Settings.Default.vper;
            if(Settings.Default.venable == "ACTIVADO"){

                if (horaguardada == horaactual)
                {
                    Process.Start(Settings.Default.rutaalarma);

                }
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        void valoresiniciales(){
            cbp.Items.Add("AM");
            cbp.Items.Add("PM");
            for (int i = 0; i < 13; i++)
            {
                cbh.Items.Add(i);
            }
            for (int i = 0; i < 10; i++)
            {
                cbm.Items.Add("0"+i);

            }
            for (int i = 10; i < 60; i++)
            {
                cbm.Items.Add(i);
            }
            cbenable.Items.Add("ACTIVADO");
            cbenable.Items.Add("DESACTIVADO");
            
            cbh.Text = Settings.Default.vhora;
            cbm.Text = Settings.Default.vmin;
            cbp.Text = Settings.Default.vper;
            cbenable.Text = Settings.Default.venable;
            ruta.Text = Settings.Default.rutaalarma;

        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void cbh_DropDownClosed(object sender, EventArgs e)
        {
            Settings.Default.vhora = cbh.Text;
            Settings.Default.Save();
        }

        private void cbm_DropDownClosed(object sender, EventArgs e)
        {
            Settings.Default.vmin = cbm.Text;
            Settings.Default.Save();
        }

        private void cbp_DropDownClosed(object sender, EventArgs e)
        {
            Settings.Default.vper = cbp.Text;
            Settings.Default.Save();
        }

        private void cbenable_DropDownClosed(object sender, EventArgs e)
        {
            Settings.Default.venable = cbenable.Text;
            Settings.Default.Save();
        }

        private void buscar_Click(object sender, RoutedEventArgs e)
        {
            windowform.OpenFileDialog ofd = new windowform.OpenFileDialog();
            ofd.Filter = "Archivos de música(*.mp3, *.wav)|*.mp3; *.wav" + "|Todos los archivos|*.*";
            ofd.Title = "Abrir";
            if (ofd.ShowDialog().ToString().Equals("OK"))
            {
                ruta.Text = ofd.FileName;
                Settings.Default.rutaalarma = ruta.Text;
                Settings.Default.Save();

            }
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
	}
}