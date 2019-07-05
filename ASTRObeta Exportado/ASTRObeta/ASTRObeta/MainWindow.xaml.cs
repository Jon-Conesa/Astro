using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using System.Threading;


namespace ASTRObeta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool hr = true;
        string up;
        SpeechRecognitionEngine reconocedor = new SpeechRecognitionEngine();
        SpeechSynthesizer astro = new SpeechSynthesizer();
        string speech;
        string[] comandos = { "deshabilitar","minimizar","arriba", "abajo", "derecha", "izquierda", "cerrar", 
                                "astro saluda", "buenos dias astro", "joder astro" ,"astro","buscador","no",
                                "sí","hola","minimizar","maximizar","muestrate","te quiero ver","pantalla","abrir el buscador",
                                "deshabilitar","saluda a mi abuela","saluda a mi abuelo","saluda a mi padre","saluda a mi madre","saluda a mi tío","saluda a mi tía","saluda a mi "};
        public MainWindow()
        {
            InitializeComponent();
            load();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        void astro_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            hr = false;
        }

        void astro_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            hr = true;
        }

        void load()
        {
            Choices cmd = new Choices(comandos);
            reconocedor.LoadGrammar(new DictationGrammar());
            reconocedor.LoadGrammar(new Grammar(cmd));
            reconocedor.SetInputToDefaultAudioDevice();
            astro.SetOutputToDefaultAudioDevice();
            reconocedor.SpeechRecognized += reconocedor_SpeechRecognized;
            reconocedor.RecognizeAsync(RecognizeMode.Multiple);
            astro.SpeakCompleted += astro_SpeakCompleted;
            astro.SpeakStarted += astro_SpeakStarted;

        }
        void reconocedor_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            speech = e.Result.Text;
            palabrarrrrrr.Content = speech;
            
            


            switch (speech)
            {

                case "cerrar":
                    Close();
                    break;
                case "astro saluda":
                    try
                    {

                        ttbbrr.Text = "yo, Astro os saludo";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);


                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    
                    break;
                case "buenos dias astro":
                    
                    try
                    {


                        
                        
                        ttbbrr.Text = "Buenos dias señor";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "joder astro":
                    
                    try
                    {


                        astro.Speak("siento decepcionarle señor");
                        ttbbrr.Text = "siento decepcionarle señor";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "astro":
                    
                    try
                    {


                        astro.Speak("Señor");
                        ttbbrr.Text = "Señor";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "minimizar":
                    
                    try
                    {


                        astro.Speak("minimizando" + ". . . . .");
                        ttbbrr.Text = "Señor";
                        WindowState = WindowState.Minimized;
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "maximizar":
                    
                    try
                    {

                        ttbbrr.Text = "Maximizando";
                        WindowState = WindowState.Maximized;
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "muestrate":
                    
                    try
                    {

                        ttbbrr.Text = "Maximizando";
                        WindowState = WindowState.Normal;
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "muestra":
                    
                    try
                    {

                        ttbbrr.Text = "Maximizando";
                        WindowState = WindowState.Normal;
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "te quiero ver":
                    
                    try
                    {

                        ttbbrr.Text = "Maximizando";
                        WindowState = WindowState.Normal;
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        
                    }
                    catch
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "pantalla":
                    
                    try
                    {

                        ttbbrr.Text = "Maximizando";
                        WindowState = WindowState.Normal;
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "buscador":
                    
                    try
                    {

                        
                        ttbbrr.Text = "abriendo el google";
                        System.Diagnostics.Process.Start("www.google.es");
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "abrir el buscador":
                    
                    try
                    {

                        ttbbrr.Text = "abriendo el google";
                        System.Diagnostics.Process.Start("www.google.es");
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "sí":
                    
                    try
                    {


                        ttbbrr.Text = "buscando";
                        System.Diagnostics.Process.Start("https://www.google.es/search?q=" + up);
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "no":
                    
                    try
                    {
                        ttbbrr.Text = "como usted quiera";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "deshabilitar":
                    
                    try
                    {

                        ttbbrr.Text = "como usted quiera";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);
                        Thread.Sleep(milliseconds);
                        hr = false;
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "saluda a mi abuelo":
                    
                    try
                    {
                        ttbbrr.Text = "Hola abuelo de mi señor";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "saluda a mi abuela":
                    
                    try
                    {


                        ttbbrr.Text = "Hola abuela de mi señor";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "hola":
                    try
                    {

                        ttbbrr.Text = "Hola";
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);

                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                case "música":

                    try
                    {
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=BcsfftwLUf0");
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
                default:
                    
                    try
                    {

                        up = speech;
                        ttbbrr.Text = "No le he entendido, quiere que lo busque por internet?";
                        astro.SpeakAsync("no le he entendido, quiere que lo busque por internet?" + ". . . . .");
                        int milliseconds = 100;
                        Thread.Sleep(milliseconds);

                        Thread.Sleep(milliseconds);
                        
                    }
                    catch (Exception exp)
                    {
                        MainWindow mainn = new MainWindow();
                        mainn.Show();
                        this.Close();
                    }
                    break;
            }
        }












        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Pass_Click(object sender, RoutedEventArgs e)
        {
            TecladoVersion panttwo = new TecladoVersion();
            panttwo.Show();
            this.Hide();
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
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
