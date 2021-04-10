using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TAREA8
{
    class ClassArrays
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal;
        private int tamañoArreglo = 0;

        public int getTamañoArreglo()
        {
            return datos.Length;
        }

        public ClassArrays(int[] arregloParametro)
        {
            datos = arregloParametro;
            tamañoArreglo = datos.Length;
        }

        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for (i = 0; i < tamañoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamañoArreglo; j++)
                {
                    if (ArregloTemporal[i] < ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }

    }
}
