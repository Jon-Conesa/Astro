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
using System.Net;
using System.Net.Sockets;
using ASTRObeta.Properties;

namespace ASTRObeta
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        bool derecho;
        bool izquierdo;
        string myip;
        Socket sck;
        EndPoint epLocal, epRemote;
        public Window1()
        {
            InitializeComponent();
            
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            string myip = GetLocalIP(); //  testLocalIp.Text = GetLocalIP();
            tbip.Text = GetLocalIP(); // textFiendsIp.Text = GetLocalIP();
            
        }
        

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());


            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void eldestructor(IAsyncResult aResult)
        {

            string myip = GetLocalIP();
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] reciveData = new byte[1464];

                    reciveData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string recivedMessage = eEncoding.GetString(reciveData);

                    bool uiAccess = lllllliiiiiisssssst.Dispatcher.CheckAccess();

                    if (uiAccess)
                    {
                        string resultado = recivedMessage.Replace("[", "");
                        string resultadodef = resultado.Replace("]", "");
                        string resultado11 = resultadodef.Replace("/n", "");

                        lllllliiiiiisssssst.Items.Add("Friend : " + resultado11);
                    }
                    else
                    {
                        string resultado = recivedMessage.Replace("\0", "");
                        string resultadodef = resultado.Replace("/0", "");
                        string resultado11 = resultadodef.Replace("/n", "");

                        lllllliiiiiisssssst.Dispatcher.Invoke(() => { lllllliiiiiisssssst.Items.Add("Friend : " + resultado11); });
                    }

                    

                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(eldestructor), buffer);




            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            
        }

        private void empezarbt_Click(object sender, RoutedEventArgs e)
        {
            string myip = GetLocalIP();
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(myip), Convert.ToInt32("80"));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(tbip.Text), Convert.ToInt32("80"));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(eldestructor), buffer);

                empezarbt.Content = "Conectado";
                mensagetb.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Settings.Default.ultimaip = tbip.Text;
            Settings.Default.Save();
            

        }

        private void enviarbt_Click(object sender, RoutedEventArgs e)
        {
            string myip = GetLocalIP();
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(mensagetb.Text);

                sck.Send(msg);
                
                lllllliiiiiisssssst.Items.Add("Me : " + mensagetb.Text);
                mensagetb.Clear();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
            izquierdo = true;
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void mensagetb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string myip = GetLocalIP();
                try
                {
                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    byte[] msg = new byte[1500];
                    msg = enc.GetBytes(mensagetb.Text);

                    sck.Send(msg);

                    lllllliiiiiisssssst.Items.Add("Me : " + mensagetb.Text);
                    mensagetb.Clear();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            tbip.Text = Settings.Default.ultimaip;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
            derecho = true;
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            derecho = false;
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            izquierdo = false;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
