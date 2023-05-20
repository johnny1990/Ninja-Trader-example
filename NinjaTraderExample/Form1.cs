using NinjaTrader.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NinjaTraderExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunTransaction_Click(object sender, EventArgs e)
        {
            var client = new Client();

            var order = client.NewOrderId();
            var result = client.Command("Place", "32724", "/ZW", "BUY", 1, "limit", 221.60, 0, "Gtc",
                   string.Empty, order, string.Empty, string.Empty);

            lstResult.Items.Add(String.Format("Result", result));

            var orders = client.Orders("32724");
            lstResult.Items.Add(String.Format("Orders ", string.IsNullOrEmpty(orders) ? "EMPTY" : orders));
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            Client NTClient = new Client();
            int myPosition = NTClient.MarketPosition(@"/ZW", @"32724");
            txtPosition.Text = myPosition.ToString();
        }
    }
}
