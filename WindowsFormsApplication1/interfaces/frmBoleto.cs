using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.interfaces
{
    public partial class frmBoleto : Form
    {
        public frmBoleto()
        {
            InitializeComponent();
        }

        private void frmBoleto_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser.Print();
        }
    }
}
