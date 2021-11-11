using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_NIM;

namespace ServerConfigForm_P5_105
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelonoroff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            buttonOn.Enabled = false;
            buttonOFF.Enabled = true;
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            labelonoroff.Text = "Server OFF";
            labelKet.Text = "Klik ON untuk Menjalankan Server";
            Host.Close();
            buttonOn.Enabled = true;
            buttonOFF.Enabled = false;
        }
    }
}
