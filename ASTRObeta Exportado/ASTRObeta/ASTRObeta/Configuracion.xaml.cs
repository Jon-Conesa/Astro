using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ASTRObeta.Properties;
using windowform = System.Windows.Forms;

namespace ASTRObeta
{
	/// <summary>
	/// Interaction logic for Configuracion.xaml
	/// </summary>
	public partial class Configuracion : Window
	{
		public Configuracion()
		{
			this.InitializeComponent();
            carggarconfig();
			
			// Insert code required on object creation below this point.
		}

        void carggarconfig()
        {
            tbn.Text = Settings.Default.nombre;
            cbbp.Items.Add("GOOGLE");
            cbbp.Items.Add("YAHOO");
            cbbp.Items.Add("FACEBOOK");
            cbbp.Items.Add("BING");
            cbbp.Text = Settings.Default.buscadorpre;
            tbma.Text = Settings.Default.rutaalarma;
            user.Text = Settings.Default.usuario;
            passwor.Text = Settings.Default.password;
            mennu.Items.Add("EQUILIBRADO");
            mennu.Items.Add("VARIADO");
           mennu.Text = Settings.Default.menu;
           iccpp.Items.Add("INGLES");
           iccpp.Items.Add("ESPAÑOL");
           iccpp.Text = Settings.Default.icp;
           iddcc.Text = Settings.Default.idciudad;

        }

        private void btnguardar_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.nombre = tbn.Text;
            Settings.Default.Save();
            Settings.Default.usuario = user.Text;
            Settings.Default.Save();
            Settings.Default.password = passwor.Text;
            Settings.Default.Save();
            Settings.Default.idciudad = iddcc.Text;
            Settings.Default.Save();
            Menu mmenu = new Menu();
            mmenu.Show();
            this.Close();
        }

        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            Settings.Default.buscadorpre = cbbp.Text;
            Settings.Default.Save();
        }

        private void buscar_Click(object sender, RoutedEventArgs e)
        {
            windowform.OpenFileDialog ofd = new windowform.OpenFileDialog();
            ofd.Filter = "Archivos de música(*.mp3, *.wav)|*.mp3; *.wav" + "|Todos los archivos|*.*";
            ofd.Title = "Abrir";
            if (ofd.ShowDialog().ToString().Equals("OK"))
            {
                tbma.Text = ofd.FileName;
                Settings.Default.rutaalarma = tbma.Text;
                Settings.Default.Save();

            }
        }

        private void ComboBox_DropDownClosed_1(object sender, EventArgs e)
        {
            Settings.Default.menu = mennu.Text;
            Settings.Default.Save();
        }

        private void iccpp_DropDownClosed(object sender, EventArgs e)
        {
            Settings.Default.icp = iccpp.Text;
            Settings.Default.Save();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Menu mme = new Menu();
            mme.Show();
            this.Close();
            
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            App.Current.Shutdown();
        }

	}
}