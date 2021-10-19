using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioHerencia_Inmobiliria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNroPiso.Enabled = true;
            txtNroVentanas.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtNroPiso.Enabled = false;
            txtNroVentanas.Enabled = true;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double piso;
            double local;

            String direccion  = txtDireccion.Text;

            int numVentanas   = Convert.ToInt32(txtNroVentanas.Text);

            int sup           = Convert.ToInt32(txtSuperficie.Text);

            double precioBase = Convert.ToDouble(txtPrecioBase.Text);

            int antiguedad    = Convert.ToInt32(txtAntiguedad.Text);

            int numPiso       = Convert.ToInt32(txtNroPiso.Text);

            Piso miPiso       = new Piso();
            Local miLocal     = new Local();

            piso = miPiso.ingresarPiso(precioBase, numPiso, antiguedad);
            local = miLocal.local(precioBase, antiguedad, sup, numVentanas);

            lblResultadoFinal.Text = "El precio Final es " + piso + " " + direccion;
            lblResultadoFinal.Text = "El precio Final es " + local + " " + direccion;
        }
    }
}