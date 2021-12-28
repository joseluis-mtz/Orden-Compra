using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orden_Compra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAderezo.SelectedIndex = 0;
            rbHaG.Checked = true;
            rbHoG.Checked = true;
            chkIngHa1.Checked = true;
            chkIngHo1.Checked = true;
        }

        int contador = 0;

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}
