using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBermuda.Enabled = false;
            checkBoxBermuda.Checked = false;
            checkBoxManga.Enabled = true;
        }

        private void radioButtonPantalon_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxManga.Enabled = false;
            checkBoxManga.Checked = false;
            checkBoxBermuda.Enabled = true;
        }

        //-----------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------//

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxPrecio.Text, out int precio))
            {
                textBoxPrecio.ForeColor = Color.Black;
            }
            else
            {
                textBoxPrecio.ForeColor = Color.Red;
            }
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCantidad.Text, out int cantidad))
            {
                textBoxCantidad.ForeColor = Color.Black;
            }
            else
            {
                textBoxCantidad.ForeColor = Color.Red;
            }
        }

        //-----------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------//

        private bool calidadRopa()
        {
            if (! radioButtonStandard.Checked && ! radioButtonPremium.Checked)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool precioYCantidad()
        {
            if (int.TryParse(textBoxPrecio.Text, out int precio) && int.TryParse(textBoxCantidad.Text, out int cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //-----------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------------------------------//

        private void buttonPrecioFinal_Click(object sender, EventArgs e)
        {
            if (!calidadRopa() || precioYCantidad())
            {
                MessageBox.Show("Hay un Problema");
            }
            else
            {
                int precio = int.Parse(textBoxPrecio.Text);
                bool calStandard = radioButtonStandard.Checked;
                int cant = int.Parse(textBoxCantidad.Text);
                double precioU;

                if (radioButtonCamisa.Checked)
                {
                    bool mangaCorta = checkBoxManga.Checked;

                    Camisa miCamisa = new Camisa(precio, mangaCorta, calStandard);

                    precioU = miCamisa.PrecioFinal();
                    int precioTotal = (int)(precioU * cant);

                    MessageBox.Show("Precio Final: $" + precioTotal);
                }

                if (radioButtonPantalon.Checked)
                {
                    bool bermuda = checkBoxBermuda.Checked;

                    Pantalon miPantalon = new Pantalon(bermuda, calStandard, precio);

                    precioU = miPantalon.PrecioFinal();
                    int precioTotal = (int)(precioU * cant);

                    MessageBox.Show("Precio Final: $" + precioTotal);
                }
            }
        }
    }
}