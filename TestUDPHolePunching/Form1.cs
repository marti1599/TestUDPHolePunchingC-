using LumiSoft.Net.STUN.Client;
using Open.Nat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUDPHolePunching
{
    /* Steps:
     * Chcek if connected to Internet
     * Get All Local IPs
     * Foreach Local IP Create a UdpClient
     * Foreach UdpClient, get the Public Address
     *  * Foreach STUN on my STUN List
     *  *   * Try get the Public Address using STUN
     *  * Foreach TURN on my TURN List
     *  *   * Try get the Public Address using TURN
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */

    public partial class Form1 : Form
    {
        int port;

        bool receiveMessages = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart1_Click(object sender, EventArgs e)
        {
            //List<UdpClient> udpClients = new List<UdpClient>();
            if (CheckIfConnected())
            {
                List<String> localIPs = GetLocalIPAddress();

                /*foreach (String IP in localIPs)
                {
                    UdpClient client = new UdpClient(IP, port);
                    udpClients.Add(client);
                }*/

                /*List<(String netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint)> STUNResults = new List<(string netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint)>();
                foreach (UdpClient client in udpClients)
                {
                    IPEndPoint ep = client.Client.LocalEndPoint as IPEndPoint;
                    (String netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint) STUNResult = ConnectToSTUN(ep.Address);
                    if(STUNResult.netType != null && STUNResult.LocalEndPoint != null && STUNResult.PublicEndPoint != null)
                    {
                        STUNResults.Add(STUNResult);
                    }

                    ConnectToTURN();
                }*/

                List<(String netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint)> STUNResults = new List<(string netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint)>();
                foreach (String IP in localIPs)
                {
                    IPEndPoint ep = new UdpClient(IP, port).Client.LocalEndPoint as IPEndPoint;
                    (String netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint) STUNResult = ConnectToSTUN(ep.Address);
                    if (STUNResult.netType != null && STUNResult.LocalEndPoint != null && STUNResult.PublicEndPoint != null)
                    {
                        STUNResults.Add(STUNResult);
                    }

                    ConnectToTURN();
                }

                if (STUNResults.Count == 1)
                {
                    LblNetType1Value.Text = STUNResults[0].netType.ToString();
                    LblLocalEndPoint1Value.Text = STUNResults[0].LocalEndPoint.ToString();
                    LblPublicEndPoint1Value.Text = STUNResults[0].PublicEndPoint.ToString();
                }
            }
        }

        private bool CheckIfConnected()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return true;
            }

            return false;
        }

        private void ConnectToTURN()
        {
            //TODO
            //throw new NotImplementedException();
        }

        private (String netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint) ConnectToSTUN(IPAddress IP)
        {
            //List of STUN
            //https://gist.github.com/zziuni/3741933
            //https://gist.github.com/sagivo/3a4b2f2c7ac6e1b5267c2f1f59ac6c6b

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(new IPEndPoint(IPAddress.Any, 11000));
            //socket.Bind(new IPEndPoint(IP, port));

            STUN_Result result = STUN_Client.Query("stun.l.google.com", 19302, socket);
            STUN_NetType netType = result.NetType;
            EndPoint epLocal = socket.LocalEndPoint;
            EndPoint epPublic = null;
            if (result.NetType != STUN_NetType.UdpBlocked)
            {
                epPublic = result.PublicEndPoint;
            }

            Console.WriteLine("NetType = " + netType.ToString());
            Console.WriteLine("Local EndPoint = " + epLocal.ToString());
            if (epPublic != null)
            {
                Console.WriteLine("Public EndPoint = " + epPublic.ToString());
            }
            else
            {
                Console.WriteLine("Public EndPoint = ");
            }

            //socket.Close();

            if (netType != null && epLocal != null && epPublic != null)
            {
                return (netType.ToString(), epLocal as IPEndPoint, epPublic as IPEndPoint);
            }
            else
            {
                return (null, null, null);
            }
        }

        public static List<string> GetLocalIPAddress()
        {
            List<String> result = new List<String>();
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    result.Add(ip.ToString());
                }
            }

            return result;
        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {
            List<UdpClient> udpClients = new List<UdpClient>();
            if (CheckIfConnected())
            {
                List<String> localIPs = GetLocalIPAddress();

                foreach (String IP in localIPs)
                {
                    UdpClient client = new UdpClient(IP, port);
                    udpClients.Add(client);
                }

                List<(String netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint)> STUNResults = new List<(string netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint)>();
                foreach (UdpClient client in udpClients)
                {
                    IPEndPoint ep = client.Client.LocalEndPoint as IPEndPoint;
                    (String netType, IPEndPoint LocalEndPoint, IPEndPoint PublicEndPoint) STUNResult = ConnectToSTUN(ep.Address);
                    if (STUNResult.netType != null && STUNResult.LocalEndPoint != null && STUNResult.PublicEndPoint != null)
                    {
                        STUNResults.Add(STUNResult);
                    }

                    ConnectToTURN();
                }

                if (STUNResults.Count == 1)
                {
                    LblNetType2Value.Text = STUNResults[0].netType.ToString();
                    LblLocalEndPoint2Value.Text = STUNResults[0].LocalEndPoint.ToString();
                    LblPublicEndPoint2Value.Text = STUNResults[0].PublicEndPoint.ToString();
                }
            }
        }

        private void BtnStartSendMessages1_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(TxtbxIPDestination1.Text), Convert.ToInt32(NudPortDestination1.Value));
                UdpClient client = new UdpClient();
                client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                client.Connect(ep);
                while (receiveMessages)
                {
                    String msg = "Hi 1 ";
                    byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
                    client.Send(msgBytes, msgBytes.Length);
                    AppendTextBoxLog1("Local: " + client.Client.LocalEndPoint.ToString() + " Remote: " + client.Client.RemoteEndPoint.ToString() + " User1 Sent: " + msg);
                    Thread.Sleep(500);
                }
                client.Close();
            }).Start();

            /*new Thread(() =>
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, Convert.ToInt32(NudPortDestination1.Value));
                UdpClient client = new UdpClient(Convert.ToInt32(NudPortDestination1.Value));
                client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                for (int i = 0; i < 100; i++)
                {
                    byte[] msg = client.Receive(ref ep);
                    AppendTextBoxLog1(IPAddress.Any.ToString() + "User1 Received: " + Encoding.UTF8.GetString(msg));
                    Console.WriteLine(IPAddress.Any.ToString() + "User1 Received: " + Encoding.UTF8.GetString(msg));
                }
            }).Start();*/
        }

        public void AppendTextBoxLog1(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBoxLog1), new object[] { value });
                return;
            }
            TxtbxLog1.Text += value + Environment.NewLine;
        }

        private void BtnStartSendMessages2_Click(object sender, EventArgs e)
        {
            /*new Thread(() =>
            {
                UdpClient client = new UdpClient();
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(TxtbxIPDestination2.Text), Convert.ToInt32(NudPortDestination2.Value));
                client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                client.Connect(ep);
                for (int i = 0; i < 100; i++)
                {
                    String msg = "Hi 2 " + i;
                    byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
                    client.Send(msgBytes, msgBytes.Length);
                    AppendTextBoxLog2(client.Client.LocalEndPoint.ToString() + " " + client.Client.RemoteEndPoint.ToString() + " User2 Sent: " + msg);
                    Console.WriteLine(client.Client.LocalEndPoint.ToString() + " " + client.Client.RemoteEndPoint.ToString() + " User2 Sent: " + msg);
                    Thread.Sleep(500);
                }
            }).Start();*/

            new Thread(() =>
            {
                receiveMessages = true;
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.104.133"), Convert.ToInt32(NudPortDestination2.Value));
                UdpClient client = new UdpClient();
                //client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                client.Client.Bind(ep);
                client.Client.ReceiveTimeout = 5000;
                AppendTextBoxLog2("Listening on  " + ep.ToString());
                while(receiveMessages)
                {
                    try
                    {
                        byte[] msg = client.Receive(ref ep);
                        AppendTextBoxLog2("Local: " + client.Client.LocalEndPoint.ToString() + " Remote: " + ep.ToString() + " User2 Received: " + Encoding.UTF8.GetString(msg));
                    }
                    catch (SocketException ex)
                    {
                        //Receive Timeout
                    }
                }
                AppendTextBoxLog2("Stop Listening");
            }).Start();
        }

        public void AppendTextBoxLog2(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBoxLog2), new object[] { value });
                return;
            }
            TxtbxLog2.Text += value + Environment.NewLine;
        }

        private void BtnStopReceiveMessages_Click(object sender, EventArgs e)
        {
            receiveMessages = false;
        }
    }
}
