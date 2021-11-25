using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Metodos_Ord_Interna.Form1;

namespace Metodos_Ord_Interna.Busquedas
{
    class Secuencial : ClassBase
    {
        int i;

        public override void Buscar(int N, int numBuscar, DatosPersonas[] Datos, DataGridView dataGridView) //Recibe totoal de registros, numero a buscar, struct con registros, data para mostrar reg encontrado
        {
            i = 0;

            while ((i <= N - 1) && (Datos[i].numero != numBuscar))
                i++;

            if (i > N - 1)
                MessageBox.Show("El registro no fue encontrado", "Error");
            else
                base.Buscar(i, numBuscar, Datos, dataGridView);
        }
    }
}
