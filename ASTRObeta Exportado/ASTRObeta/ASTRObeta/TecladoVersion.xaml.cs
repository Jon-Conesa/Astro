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
using System.Runtime.InteropServices;



namespace ASTRObeta
{
	/// <summary>
	/// Interaction logic for TecladoVersion.xaml
	/// </summary>
	public partial class TecladoVersion : Window
	{
		public TecladoVersion()
		{
			this.InitializeComponent();
            this.TextBox2.KeyDown += new KeyEventHandler(TextBox2_KeyDown);
            this.LayoutRoot.KeyDown += new KeyEventHandler(LayoutRoot_KeyDown);
            this.Window.KeyDown += new KeyEventHandler(Window_KeyDown);
			
			// Insert code required on object creation below this point.

		}

        private void Pass_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer AVJarvis = new SpeechSynthesizer();
            string text = TextBox2.Text;
            if (text == "hola" || text == "Hola")
            {
                AVJarvis.SpeakAsync("Hola senyor estoy a su disposición. Para cualquier duda de los comandos ponga: ayuda");
            }
            if (text == "Quien es tu creador?" || text == "Quien es tu creador")
            {
                AVJarvis.Speak("Mi creador a querido que su identidad permanezca en secreto.");
            }
            if (text == "hola" || text == "Hola")
            {
                AVJarvis.Speak("Hola senyor estoy a su disposición. Para cualquier duda de los comandos ponga: ayuda");
            }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                SpeechSynthesizer AVJarvis = new SpeechSynthesizer();
                string text = TextBox2.Text;
                if (text == "hola" || text == "Hola")
                {
                    AVJarvis.SpeakAsync("Hola senyor estoy a su disposición. Para cualquier duda de los comandos ponga: ayuda");
                    txttv.Text = "Hola senyor estoy a su disposición. Para cualquier duda de los comandos ponga: ayuda";
                }
                if (text == "Quien es tu creador?" || text == "Quien es tu creador")
                {
                    AVJarvis.SpeakAsync("Mi creador a querido que su identidad permanezca en secreto.");
                    txttv.Text = "Mi creador a querido que su identidad permanezca en secreto.";
                }
                if (text == "hola" || text == "Hola")
                {
                    AVJarvis.SpeakAsync("Hola senyor estoy a su disposición. Para cualquier duda de los comandos ponga: ayuda");
                    txttv.Text = "Hola senyor estoy a su disposición. Para cualquier duda de los comandos ponga: ayuda";
                }
                if (text == "Tienes novia" || text == "tienes novia" || text == "tienes novia?" || text == "Tienes novia?")
                {
                    AVJarvis.SpeakAsync("Si. Mi novia es Siri. Y mi suegro Apple");
                    txttv.Text = "Si. Mi novia es Siri. Y mi suegro Apple";
                }
                if (text == "0/0" || text == "0 dividido entre 0" || text == "0 entre 0" || text == "0 partido por 0")
                {
                    txttv.Text = "Error 451. Fallo en el sistema. Evacuación!!";
                    AVJarvis.Speak("Error 451. Fallo en el sistema. Evacuación!!");
                    App.Current.Shutdown();
                }
                if (text == "CH" || text == "ch" )
                {
                    AVJarvis.SpeakAsync("Había una vez una persona muy muy muy aburrida. Esta aburrida persona tuvo una idea. Decirle a su asistente virtual que le contara una historia. Y aquí estas tu.");
                    txttv.Text = "Había una vez una persona muy muy muy aburrida. Esta aburrida persona tuvo una idea. Decirle a su asistente virtual que le contara una historia. Y aquí estas tu.";
                }
                if (text == "que esperas de mí" || text == "Que esperas de mí" || text == "Que esperas de mí?" || text == "que esperas de mí?" || text == "que esperas de mi" || text == "Que esperas de mi" || text == "Que esperas de mi?" || text == "que esperas de mi?")
                {
                    AVJarvis.SpeakAsync("Espero que no seas un amo muy severo. Y que por ejemplo no me preguntes 0/0 porque sino explotaria");
                    txttv.Text = "Espero que no seas un amo muy severo. Y que por ejemplo no me preguntes 0/0 porque sino explotaria";
                    
                }
                if (text == "me aburro" || text == "Me aburro")
                {
                    AVJarvis.SpeakAsync("Pues comprate un burro");
                    txttv.Text = "Pues comprate un burro";
                    System.Diagnostics.Process.Start("https://www.google.es/search?q=burro&espv=2&biw=1440&bih=799&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjv0IP2yLTOAhWG5xoKHfF4AosQ_AUIBigB#imgrc=zU9-TEd96ekclM%3A");

                }
            }
        }

        private void LayoutRoot_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            App.Current.Shutdown();
        }




	}
}