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
            if (txtName.Text.Length > 0)
            {
                frmResumen mandar = new frmResumen();
                contador += 1;
                mandar.lblPedido.Text = "No. de pedido: " + contador.ToString();
                mandar.lblName.Text = "Nombre del cliente: " + txtName.Text;
                mandar.lblHamb.Text = "Producto: Hamburguesa";
                mandar.lblHot.Text = "Producto: Hotdog";
                if (rbHaG.Checked == true)
                {
                    mandar.lblSizeHam.Text = "Tamaño: " + rbHaG.Text;
                }
                else
                {
                    mandar.lblSizeHam.Text = "Tamaño: " + rbHaCH.Text;
                }
                if (rbHoG.Checked == true)
                {
                    mandar.lblSizeHot.Text = "Tamaño: " + rbHoG.Text;
                }
                else
                {
                    mandar.lblSizeHot.Text = "Tamaño: " + rbHoC.Text;
                }

                if (chkIngHa1.Checked == true && chkIngHa2.Checked == true && chkIngHa3.Checked == true)
                {
                    mandar.lblIngHam.Text = "Ingredientes: " + chkIngHa1.Text + " " + chkIngHa2.Text + " " + chkIngHa3.Text;
                }
                else if (chkIngHa1.Checked == true && chkIngHa2.Checked == true)
                {
                    mandar.lblIngHam.Text = "Ingredientes: " + chkIngHa1.Text + " " + chkIngHa2.Text;
                }
                else if (chkIngHa1.Checked == true)
                {
                    mandar.lblIngHam.Text = "Ingredientes: " + chkIngHa1.Text;
                }

                if (chkIngHo1.Checked == true && chkIngHo2.Checked == true && chkIngHo3.Checked == true)
                {
                    mandar.lblIngHot.Text = "Ingredientes: " + chkIngHo1.Text + " " + chkIngHo2.Text + " " + chkIngHo3.Text;
                }
                else if (chkIngHo1.Checked == true && chkIngHo2.Checked == true)
                {
                    mandar.lblIngHot.Text = "Ingredientes: " + chkIngHo1.Text + " " + chkIngHo2.Text;
                }
                else if (chkIngHo1.Checked == true)
                {
                    mandar.lblIngHot.Text = "Ingredientes: " + chkIngHo1.Text;
                }

                mandar.lblAderezos.Text = "Aderezos: " + cmbAderezo.SelectedItem.ToString();
                mandar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error en el envío.\nNo hay cliente registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
