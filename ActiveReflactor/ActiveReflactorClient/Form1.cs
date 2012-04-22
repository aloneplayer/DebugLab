using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ActiveReflactorClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Active_Click(object sender, EventArgs e)
        {
            ActivationServiceClient client = new ActivationServiceClient();

            client.Activate();
        }

        private void button_Deactive_Click(object sender, EventArgs e)
        {
            ActivationServiceClient client = new ActivationServiceClient();

            client.Deactivate();
        }
    }
}
