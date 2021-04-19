using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.Text = "Calculadora de Dattilo, Damian del curso 2A";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cmbOperador.Items.AddRange(new String[] {"+", "-", "*", "/"});
        }

        /// <summary>
        /// Muestra el resultado de la operacion solicitada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            if(String.IsNullOrWhiteSpace(txtNumero1.Text) || String.IsNullOrWhiteSpace(cmbOperador.Text) || String.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("ERROR: Ingrese valores");
            }
            else
            {
                Numero n1 = new Numero(this.txtNumero1.Text);
                Numero n2 = new Numero(this.txtNumero2.Text);

                resultado = Calculadora.Operar (n1, n2, cmbOperador.Text);

                this.lblResultado.Text = (Convert.ToString(resultado));

            }

        }

        /// <summary>
        /// Borra los valores y los devuelve a su condicion de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            lblResultado.Text = "";
            txtNumero2.Clear();
            cmbOperador.SelectedIndex = 0;
        }

        /// <summary>
        /// Convierte el resultado a binario o lo mantiene igual si ya es binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
        }

        /// <summary>
        /// Convierte el resultado a decimal o lo mantiene si ya es decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            
            this.lblResultado.Text = Convert.ToString(Numero.BinarioDecimal(this.lblResultado.Text));
            
        }

        /// <summary>
        /// Cierra el form con el boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
