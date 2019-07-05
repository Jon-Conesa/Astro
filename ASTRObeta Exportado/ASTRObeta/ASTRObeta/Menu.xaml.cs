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
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using ASTRObeta.Properties;

namespace ASTRObeta
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            this.InitializeComponent();
            SpeechSynthesizer AVJarvis = new SpeechSynthesizer();
            AVJarvis.SpeakAsync("Bienvenido, senyor. Estoy, a su, servicio,");
            this.LayoutRoot.KeyDown += new KeyEventHandler(LayoutRoot_KeyDown);
            this.Window.KeyDown += new KeyEventHandler(Window_KeyDown);
            // Insert code required on object creation below this point.
            
        }

        private void teclado_Click(object sender, RoutedEventArgs e)
        {
            TecladoVersion tecladop = new TecladoVersion();
            MainWindow main = new MainWindow();
            tecladop.Show();
            main.Close();
            tiempo.Visibility = System.Windows.Visibility.Hidden;
            hora.Visibility = System.Windows.Visibility.Hidden;
            CONFIGURACION.Visibility = System.Windows.Visibility.Hidden;
            ayuda.Visibility = System.Windows.Visibility.Hidden;
            Asistente_virtual.Visibility = System.Windows.Visibility.Hidden;
            cerrar.Visibility = System.Windows.Visibility.Hidden;
            comandos.Visibility = System.Windows.Visibility.Hidden;
            voz.Visibility = System.Windows.Visibility.Hidden;
            teclado.Visibility = System.Windows.Visibility.Hidden;
            MENU.Visibility = System.Windows.Visibility.Hidden;
            BUSCADOR.Visibility = System.Windows.Visibility.Hidden;
            CLIENTE_SERVIDOR.Visibility = System.Windows.Visibility.Hidden;

        }

        private void voz_Click(object sender, RoutedEventArgs e)
        {
            TecladoVersion tecladop = new TecladoVersion();
            MainWindow main = new MainWindow();
            tecladop.Close();
            main.Show();
            tiempo.Visibility = System.Windows.Visibility.Hidden;
            hora.Visibility = System.Windows.Visibility.Hidden;
            CONFIGURACION.Visibility = System.Windows.Visibility.Hidden;
            ayuda.Visibility = System.Windows.Visibility.Hidden;
            Asistente_virtual.Visibility = System.Windows.Visibility.Hidden;
            cerrar.Visibility = System.Windows.Visibility.Hidden;
            comandos.Visibility = System.Windows.Visibility.Hidden;
            voz.Visibility = System.Windows.Visibility.Hidden;
            teclado.Visibility = System.Windows.Visibility.Hidden;
            MENU.Visibility = System.Windows.Visibility.Hidden;
            BUSCADOR.Visibility = System.Windows.Visibility.Hidden;
            CLIENTE_SERVIDOR.Visibility = System.Windows.Visibility.Hidden;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        private void cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AstroButton_Click(object sender, RoutedEventArgs e)
        {
            if (tiempo.Visibility == System.Windows.Visibility.Hidden)
            {
                tiempo.Visibility = System.Windows.Visibility.Visible;
                hora.Visibility = System.Windows.Visibility.Visible;
                CONFIGURACION.Visibility = System.Windows.Visibility.Visible;
                ayuda.Visibility = System.Windows.Visibility.Visible;
                Asistente_virtual.Visibility = System.Windows.Visibility.Visible;
                cerrar.Visibility = System.Windows.Visibility.Visible;
                MENU.Visibility = System.Windows.Visibility.Visible;
                BUSCADOR.Visibility = System.Windows.Visibility.Visible;
                CLIENTE_SERVIDOR.Visibility = System.Windows.Visibility.Visible;


            }
            else
            {

                tiempo.Visibility = System.Windows.Visibility.Hidden;
                hora.Visibility = System.Windows.Visibility.Hidden;
                CONFIGURACION.Visibility = System.Windows.Visibility.Hidden;
                ayuda.Visibility = System.Windows.Visibility.Hidden;
                Asistente_virtual.Visibility = System.Windows.Visibility.Hidden;
                cerrar.Visibility = System.Windows.Visibility.Hidden;
                comandos.Visibility = System.Windows.Visibility.Hidden;
                voz.Visibility = System.Windows.Visibility.Hidden;
                teclado.Visibility = System.Windows.Visibility.Hidden;
                MENU.Visibility = System.Windows.Visibility.Hidden;
                BUSCADOR.Visibility = System.Windows.Visibility.Hidden;
                CLIENTE_SERVIDOR.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void ayuda_Click(object sender, RoutedEventArgs e)
        {
            if (comandos.Visibility == System.Windows.Visibility.Hidden)
            {
                comandos.Visibility = System.Windows.Visibility.Visible;


            }
            else
            {

                comandos.Visibility = System.Windows.Visibility.Hidden;
            }




        }

        private void Asistente_virtual_Click(object sender, RoutedEventArgs e)
        {
            if (voz.Visibility == System.Windows.Visibility.Hidden)
            {
                voz.Visibility = System.Windows.Visibility.Visible;
                teclado.Visibility = System.Windows.Visibility.Visible;


            }
            else
            {
                voz.Visibility = System.Windows.Visibility.Hidden;
                teclado.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void LayoutRoot_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void hora_Click(object sender, RoutedEventArgs e)
        {

            alarmayhora alarma = new alarmayhora();
            alarma.Show();
        }

        private void CONFIGURACION_Click(object sender, RoutedEventArgs e)
        {
            Configuracion config = new Configuracion();
            this.Close();
            config.Show();
        }
        void primeravez(){
            if (Settings.Default.password == "" && Settings.Default.nombre == "")
            {
                Privacity privi = new Privacity();
                privi.Show();
                this.Close();

            }
        }

        private void tiempo_Click(object sender, RoutedEventArgs e)
        {
            Wheather whea = new Wheather();
            whea.Show();
        }

        private void CLIENTE_SERVIDOR_Click(object sender, RoutedEventArgs e)
        {
            Window1 window111 = new Window1();
            window111.Show();
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

    }
}
