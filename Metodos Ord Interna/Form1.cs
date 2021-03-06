using Metodos_Ord_Interna.Busquedas;
using Metodos_Ord_Interna.Ordenamientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos_Ord_Interna
{
    public partial class Form1 : Form
    {
        IntercambioDirecto IntercambioDirecto = new IntercambioDirecto();
        InsercionDirecta InsercionDirecta = new InsercionDirecta();

        Secuencial Secuencial = new Secuencial();
        Binaria Binaria = new Binaria();

        public struct DatosPersonas
        {
            public int numero;
            public string nombre;
            public int edad;
        } DatosPersonas[] Datos;

        int contador;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtMaximo.Text) <= 0)
                    MessageBox.Show("Ingrese una cantida válida", "Error");

                else
                {
                    Datos = new DatosPersonas[Convert.ToInt32(txtMaximo.Text)];

                    btnAceptar.Visible = false;
                    txtMaximo.ReadOnly = true;

                    panel2.Enabled = true;

                    txtNumero.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMaximo.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (contador < Convert.ToInt32(txtMaximo.Text))
                {
                    Datos[contador].numero = Convert.ToInt32(txtNumero.Text);
                    Datos[contador].nombre = txtNombre.Text;
                    Datos[contador].edad = Convert.ToInt32(txtEdad.Text);

                    contador++;
                    MostrarDatos(contador, Datos);

                    txtNumero.Clear();
                    txtNombre.Clear();
                    txtEdad.Clear();

                    txtNumero.Focus();
                }
                else
                {
                    MessageBox.Show("Ya no se pueden ingresar más datos", "Error");
                    btnGuardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarDatos(int N, DatosPersonas[] Datos)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(Datos[i].numero), Datos[i].nombre, Convert.ToString(Datos[i].edad));
            }
        }

        private void btnIntercambioDirecto_Click(object sender, EventArgs e)
        {
            IntercambioDirecto.Ordenar(contador, Datos, dataGridView1);
        }

        private void btnInsercionDirecta_Click(object sender, EventArgs e)
        {
            InsercionDirecta.Ordenar(contador, Datos, dataGridView1);
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            try
            {
                Secuencial.Buscar(contador, Convert.ToInt32(txtBusqueda.Text), Datos, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            try
            {
                Binaria.Buscar(contador, Convert.ToInt32(txtBusqueda.Text), Datos, dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
