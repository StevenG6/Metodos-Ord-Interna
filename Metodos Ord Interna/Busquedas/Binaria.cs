using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Metodos_Ord_Interna.Form1;

namespace Metodos_Ord_Interna.Busquedas
{
    class Binaria : ClassBase
    {
        //Auxiliares para busqueda
        private int cen, izq, der;

        public override void Buscar(int N, int numBuscar, DatosPersonas[] Datos, DataGridView dataGridView)
        {
            izq = 0;
            der = N;
            cen = (izq + der) / 2;

            while ((izq <= der) && (numBuscar != Datos[cen].numero))
            {
                if (numBuscar > Datos[cen].numero)
                    izq = cen + 1;
                else
                    der = cen - 1;

                cen = (izq + der) / 2;
            }

            if (izq > der)
                MessageBox.Show("El registro no fue encontrado", "Error");
            else
                base.Buscar(cen, numBuscar, Datos, dataGridView);
        }
    }
}
