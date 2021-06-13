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

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
            this.Text = "TP Final de Dattilo, Damian del curso 2A";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            this.elegirClase.Items.AddRange(new String[] { "Microondas", "Aire Acondicionado" });
            
            this.eficiencia1.Items.AddRange(new String[] { "A", "B", "C", "D" });
            this.eficiencia2.Items.AddRange(new String[] { "A", "B", "C", "D" });
            
            this.caracteristica1.Items.AddRange(new String[] { "Frio", "Calor", "FrioCalor", "Chico", "Mediano", "Grande"});
            this.caracteristica2.Items.AddRange(new String[] { "Frio", "Calor", "FrioCalor", "Chico", "Mediano", "Grande"});
        }

        private void id1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* EficienciaEnergetica auxEficiencia1;
            EficienciaEnergetica auxEficiencia2;

            ETamanio auxTam1;
            ETamanio auxTam2;

            ETipo auxTipo1;
            ETipo auxTipo2;

            bool auxClase;*/

            if (String.IsNullOrWhiteSpace(elegirClase.Text) || String.IsNullOrWhiteSpace(id1.Text) || string.IsNullOrWhiteSpace(id2.Text) || String.IsNullOrWhiteSpace(eficiencia1.Text) || String.IsNullOrWhiteSpace(eficiencia2.Text) || String.IsNullOrWhiteSpace(caracteristica1.Text) || String.IsNullOrWhiteSpace(caracteristica2.Text))
            {
                MessageBox.Show("ERROR: Ingrese valores");
            }
           /* else
            {
                if(eficiencia1 == "A")
                {
                    auxEficiencia1 == EficienciaEnergetica.A;
                }
                if (eficiencia1 == "B")
                {
                    auxEficiencia1 == EficienciaEnergetica.B;
                }
                if (eficiencia1 == "C")
                {
                    auxEficiencia1 == EficienciaEnergetica.C;
                }
                if (eficiencia1 == "D")
                {
                    auxEficiencia1 == EficienciaEnergetica.D;
                }
                if (eficiencia2 == "A")
                {
                    auxEficiencia2 == EficienciaEnergetica.A;
                }
                if (eficiencia2 == "B")
                {
                    auxEficiencia2 == EficienciaEnergetica.B;
                }
                if (eficiencia2 == "C")
                {
                    auxEficiencia2 == EficienciaEnergetica.C;
                }
                if (eficiencia2 == "D")
                {
                    auxEficiencia2 == EficienciaEnergetica.D;
                }
                
                if (elegirClase.Text == "Microondas")
                {
                    if(caracteristica1.Text == "Chico")
                    {
                        auxTam1 = ETamanio.Chico;
                    }
                    else if(caracteristica1.Text == "Mediano")
                    {
                        auxTam1 = ETamanio.Mediano;
                    }
                    else if(caracteristica1.Text == "Grande")
                    {
                        auxTam1 = ETamanio.Chico;
                    }
                    else
                    {
                        MessageBox.Show("ERROR, caracteristica 1 no corresponde a la clase");
                    }

                    if (caracteristica2.Text == "Chico")
                    {
                        auxTam2 = ETamanio.Chico;
                    }
                    else if (caracteristica2.Text == "Mediano")
                    {
                        auxTam2 = ETamanio.Mediano;
                    }
                    else if (caracteristica2.Text == "Grande")
                    {
                        auxTam2 = ETamanio.Chico;
                    }
                    else
                    {
                        MessageBox.Show("ERROR, caracteristica 2 no corresponde a la clase");
                    }
                    Microondas obj1 = new Microondas(int.Parse(id1.Text), auxEficiencia1, auxTam1);
                    Microondas obj2 = new Microondas(int.Parse(id2.Text), auxEficiencia2, auxTam2);
                    if(!(obj1 == obj2))
                    {
                        MessageBox.Show("Los Microondas son distintos");
                    }
                    else
                    {
                        MessageBox.Show("Los Microondas son iguales");
                    }
                }
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
