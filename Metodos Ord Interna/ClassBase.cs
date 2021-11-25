using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Metodos_Ord_Interna.Form1;

namespace Metodos_Ord_Interna
{
    class ClassBase
    {
        public virtual void Ordenar(int N, DatosPersonas[] Datos, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                dataGridView.Rows.Add(Convert.ToString(Datos[i].numero), Datos[i].nombre, Convert.ToString(Datos[i].edad));
            }
        }

        public virtual void Buscar(int N, int numBuscar, DatosPersonas[] Datos, DataGridView dataGridView)  //Recibe posicion de registro encontrado, numero que se buscó, struct de datos, data para mostrar reg encontrado
        {
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add(Convert.ToString(Datos[N].numero), Datos[N].nombre, Convert.ToString(Datos[N].edad));
        }
    }
}
