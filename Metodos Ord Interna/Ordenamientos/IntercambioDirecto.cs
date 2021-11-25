using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Metodos_Ord_Interna.Form1;

namespace Metodos_Ord_Interna.Ordenamientos
{
    class IntercambioDirecto : ClassBase
    {
        //Variables auxiliares para intercambios
        string auxString;
        int auxInt;

        public override void Ordenar(int N, DatosPersonas[] Datos, DataGridView dataGridView)
        {
            for (int i = 1; i < N; i++)
            {
                for (int j = N - 1; j >= i; j--)
                {
                    if (Datos[j - 1].numero > Datos[j].numero)
                    {
                        auxInt = Datos[j - 1].numero;       Datos[j - 1].numero = Datos[j].numero;      Datos[j].numero = auxInt;
                        auxString = Datos[j - 1].nombre;    Datos[j - 1].nombre = Datos[j].nombre;      Datos[j].nombre = auxString;
                        auxInt = Datos[j - 1].edad;         Datos[j - 1].edad = Datos[j].edad;          Datos[j].edad = auxInt;
                    }
                }
            }

            base.Ordenar(N, Datos, dataGridView);
        }
    }
}
