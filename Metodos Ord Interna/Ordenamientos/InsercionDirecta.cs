using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Metodos_Ord_Interna.Form1;

namespace Metodos_Ord_Interna.Ordenamientos
{
    class InsercionDirecta : ClassBase
    {
        //Variables auxiliares para intercambios
        int auxNumero;
        string auxNombre;
        int auxEdad;

        int k;

        //Ordena Ascendentemente por Edad
        public override void Ordenar(int N, DatosPersonas[] Datos, DataGridView dataGridView)
        {
            for (int i = 1; i < N; i++)
            {
                auxNumero = Datos[i].numero;
                auxNombre = Datos[i].nombre;
                auxEdad = Datos[i].edad;

                k = i - 1;
                while (k >= 0 && auxEdad < Datos[k].edad)
                {
                    Datos[k + 1].numero = Datos[k].numero;
                    Datos[k + 1].nombre = Datos[k].nombre;
                    Datos[k + 1].edad = Datos[k].edad;

                    k--;
                }

                Datos[k + 1].numero = auxNumero;
                Datos[k + 1].nombre = auxNombre;
                Datos[k + 1].edad = auxEdad;
            }

            base.Ordenar(N, Datos, dataGridView);
        }
    }
}
