using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8_tabla_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
         
            
                int Numero;
                Numero = int.Parse(txt_numero.Text);

                for (int i = 1; i <= 12; i++)
                {
                    int resultado = Numero * i;
                    // Agregar la multiplicación al ListBox
                    lst_tabla.Items.Add($"{Numero} x {i} = {resultado}");



                }
            }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lst_tabla.Items.Clear();
            txt_numero.Clear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
    }