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

namespace ASTRObeta
{
	/// <summary>
	/// Interaction logic for Password.xaml
	/// </summary>
	public partial class Password : Window
	{
		public Password()
		{
			this.InitializeComponent();
            if (Settings.Default.password == "" && Settings.Default.nombre == "")
            {
                Privacity privi = new Privacity();
                privi.Show();
                this.Close();

            }
			
			// Insert code required on object creation below this point.
		}

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            if(usuario.Text == Settings.Default.nombre){
                if (psw1.Text == Settings.Default.password)
                {
                    Menu mmenu = new Menu();
                    mmenu.Show();
                    this.Close();
                    

                }

            }
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
	}
}