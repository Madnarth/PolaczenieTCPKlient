using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolaczenieTCPKlient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            string host = tbHostAddress.Text;
            int port = System.Convert.ToInt16(numPort.Value);
            try
            {
                TcpClient klient = new TcpClient(host, port);
                lbLogs.Items.Add("Nawiązano połączenie z " + host + " na porcie: " + port);
               
                klient.Close();
            }
            catch (Exception ex)
            {
                lbLogs.Items.Add("Błąd: Nie udało się nawiązać połączenia!");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
