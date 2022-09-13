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
    
    public partial class Factura : Form
    {
        public string Tipo,IDENTIFICACION;
        //Factura conn = new Factura("Data Source=DESKTOP-D2GO33D;Initial Catalog=VENTASAUTOSDB;Integrated Security=True");
        //private string v;

        public Factura()
        {
            InitializeComponent();
            consulta_detalle();
            consulta_fact();
         //   this.v = v;

        }
        public void Consulta_Det() 
        {
            clsNegocios usuariosNegocio = new clsNegocios();
            int deeta = int.Parse(detallee.Text);
            deeta = deeta - 1;
            usuariosNegocio.Num_detalle = deeta;
            dataGridView1.DataSource = usuariosNegocio.obtenerDetalle();

        }
        public void consulta_detalle() 
        {
            clsNegocios negocio = new clsNegocios();
            string detalle = negocio.detalle_consulta();
            if (detalle == null)
            {
                int deta = 1;
                detallee.Text = Convert.ToString(deta);
            }
            else
            {
                int deta = int.Parse(detalle);
                deta = deta + 1;
                detallee.Text = Convert.ToString(deta);
            }
        }

        public void consulta_fact()
        {
            clsNegocios negocio = new clsNegocios();
            string factura = negocio.detalle_fact();
            if (factura == null)
            {
                int fact = 1;
                FacturaTXT.Text = Convert.ToString(fact);
            }
            else {
                int fact = int.Parse(factura);
                fact = fact + 1;
                FacturaTXT.Text = Convert.ToString(fact);
            }

        }
        public void precios() 
        {
            clsNegocios negocio = new clsNegocios();
            negocio.MODELO1 = Convert.ToString(Modeloo.Text);
            negocio.ANO1 = Convert.ToString(anoVehiculo.Text);
            negocio.precios();
            txb_precio.Text = negocio.precioss;
        
        }

        public void detalle_fact() 
        {
            clsNegocios negocio = new clsNegocios();
            negocio.Marca = Convert.ToString(Marca.Text);
            negocio.Modelo = Convert.ToString(Modeloo.Text);
            negocio.Estilo = Convert.ToString(estilo.Text);
            negocio.Combustible = Convert.ToString(combustible.Text);
            negocio.Transmision = Convert.ToString(transmision.Text);
            negocio.Financiado = Convert.ToString(financiado.Text);
            negocio.Puertas = Convert.ToString(numeroPuertas.Text);
            negocio.Año = int.Parse(anoVehiculo.Text);
            negocio.Color = Convert.ToString(colorVehiculo.Text);
            negocio.insertar_Detalle();
            consulta_detalle();        
        }

        public void factura() 
        {
            clsNegocios negocios = new clsNegocios();
            int numu = int.Parse(detallee.Text);
            numu = numu -1;
            //negocios.Numm = numu;
            negocios.Numm = int.Parse(FacturaTXT.Text);
            if (rb_CR.Checked)
            {
                negocios.ID_Clientee1 = Convert.ToString(MTXB_CR.Text);
            }
            else if (rb_TJ.Checked) 
            {
                negocios.ID_Clientee1 = Convert.ToString(MTXB_TJ.Text);
            }
            negocios.Num_detallee = numu;
            if (radioEfectivo.Checked)
            {
                negocios.Tipo_pagoe = "Efectivo";
            }else if (radioTarjeta.Checked)
            {
                negocios.Tipo_pagoe = "Tarjeta";
            }
            negocios.Precioe = int.Parse(text_Subtotal.Text);
            negocios.IVAe1 = Convert.ToString(text_impuesto.Text);
            negocios.Totale = int.Parse(text_Total.Text);
            negocios.Fechae = (dateTimePicker1.Value);
            negocios.factura();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioCosta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Agregar01_Click(object sender, EventArgs e, string ranNum)
        {
            
            Random myObject = new Random();
            int ranNum1 = myObject.Next(555000, 150);
            ranNum = Convert.ToString(ranNum1);
            FacturaTXT.Text = ranNum;
            

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            detalle_fact();
            precios();

            int Precio = int.Parse(txb_precio.Text);
            string IVA = "13%";
            double iva = 0.13 * Precio;
            double Total = Precio + iva;
            text_Subtotal.Text = Precio.ToString();
            text_impuesto.Text = IVA;
            text_Total.Text = Total.ToString();
            
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsNegocios negocios = new clsNegocios();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (rb_CR.Checked)
                {
                    try
                    {
                        Tipo = "Costarricense";
                    negocios.IDENTIFICACION = MTXB_CR.Text;
                    negocios.Consulta_Clientes();
                    txb_nombre.Text = negocios.nombre;
                    txb_Apellido.Text = negocios.apellido;
                    txb_Genero.Text = negocios.genero;
                    txb_Civil.Text = negocios.estado;
                    txb_numero.Text = negocios.telefono;
                    

                }
                    catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
                else
                {
                    MessageBox.Show("No tiene casilla marcada");
                }
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsNegocios negocios = new clsNegocios();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (rb_TJ.Checked)
                {
                    try
                    {

                        
                        Tipo = "Extrangero";
                    txb_nombre.Text = negocios.nombre;
                    txb_Apellido.Text = negocios.apellido;
                    txb_Genero.Text = negocios.genero;
                    txb_Civil.Text = negocios.estado;
                    txb_numero.Text = negocios.telefono;
                }
                    catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
                else
                {
                    MessageBox.Show("No tiene casilla marcada");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Al ingresar la cedula esta informacion \n se llenara automaticamente");
        }

        private void AgregarFactura_Click(object sender, EventArgs e)
        {
            factura();
            Consulta_Det();
            consulta_fact();
        }

        private void anoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ID_Clientes()
        {
            clsNegocios negocios = new clsNegocios();
            if (MTXB_CR != null) 
            {
                negocios.IDENTIFICACION = Convert.ToString(MTXB_CR.Text);

            }else if (MTXB_TJ!=null) 
            {
                negocios.IDENTIFICACION = Convert.ToString(MTXB_TJ.Text);
            } 
            
            
        }
        
    }
}
