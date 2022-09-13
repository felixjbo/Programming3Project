using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Factura
{
    public partial class Cliente : Form
    {
        clsNegocios conn = new clsNegocios();//todos forms
        private string v;

        public Cliente()
        {
            InitializeComponent();

        }


        public void BTNIngresar_Click(object sender, EventArgs e)
        {
            string emp = "NovaCarShop";
            txt_Empresa.Text = emp;

            //try
            //{
                conn.Insertar_Cliente(Convert.ToString(txt_Cedula.Text),
                                      Convert.ToString(txt_tipo.Text),
                                      txt_NombreCliente.Text,
                                      txt_Apellido.Text,
                                      Convert.ToString(txt_genero.Text),
                                      Convert.ToString(txt_EstadoCivil.Text),
                                      int.Parse(txt_Telefono.Text),
                                      txt_Empresa.Text);
                MessageBox.Show("Exito al ingresar ");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error");
            //    throw ex;

            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_NombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void txt_genero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
