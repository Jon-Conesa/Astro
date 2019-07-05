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
using System.Windows.Shapes;
using ASTRObeta.Properties;
using System.Xml;

namespace ASTRObeta
{
    /// <summary>
    /// Interaction logic for Wheather.xaml
    /// </summary>
    public partial class Wheather : Window
    {

        string appid = "3e5e4227ca5c4ea9aed13ffac9a650b3";
        string id = Settings.Default.idciudad;
        string lang = "es";
        string unit = "metric";
        string mode = "xml";
        public Wheather()
        {
            InitializeComponent();
            GetClima();

        }
        void GetClima()
        {
            try
            {
                string url = "http://api.openweathermap.org/data/2.5/weather?id=" + id + "&appid=" + appid + "&lang=" + lang + "&units=" + unit + "&mode=" + mode;
                XmlDocument docxml = new XmlDocument();
                docxml.Load(url);
                string ciudad = docxml.DocumentElement.SelectSingleNode("city").Attributes["name"].Value;
                string temp = docxml.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
                string humi = docxml.DocumentElement.SelectSingleNode("humidity").Attributes["value"].Value;
                string pres = docxml.DocumentElement.SelectSingleNode("pressure").Attributes["value"].Value;
                string clouds = docxml.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;
                string precipi = docxml.DocumentElement.SelectSingleNode("precipitation").Attributes["mode"].Value;

                cciudad.Content = ciudad ;
                ttemp.Content = temp + " º";
                hhumi.Content = humi + " %";
                ppress.Content = pres + " hPa";
                cclouds.Content = clouds;
                pprecip.Content = precipi;

                bool test2 = clouds.Contains("nubes");
                bool test1 = clouds.Contains("claro");
                if (test2 == true && clouds != "algo de nubes")
                {
                    cloud.Visibility = System.Windows.Visibility.Visible;
                    sun.Visibility = System.Windows.Visibility.Hidden;
                }
                else if (test1 == true && test2 == false)
                {
                    cloud.Visibility = System.Windows.Visibility.Hidden;
                    sun.Visibility = System.Windows.Visibility.Visible;
                }
                else if (clouds == "algo de nubes")
                {
                    sun.Visibility = System.Windows.Visibility.Visible;
                    cloud.Visibility = System.Windows.Visibility.Visible;
                }



            }
            catch
            {
                cciudad.Content = "Sin Conexión";
                ttemp.Content = "Sin Conexión";
                hhumi.Content = "Sin Conexión";
                ppress.Content = "Sin Conexión";
                cclouds.Content = "Sin Conexión";
                pprecip.Content = "Sin Conexión";
                cloud.Visibility = System.Windows.Visibility.Hidden;
                sun.Visibility = System.Windows.Visibility.Hidden;

            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Rectangle_MouseWheel(object sender, MouseWheelEventArgs e)
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
