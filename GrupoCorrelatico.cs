using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_ALOIS
{
    internal class GrupoCorrelatico
    {
         private GrafoT3 Grafo;
        public GrupoCorrelatico(GrafoT3 Grafo)
        {
            this.Grafo = Grafo;
        }

        public bool correlativo(int nodo1, int nodo2)
        {
            if (nodo1 <0 || nodo1 >= Grafo.NumGrupos() ||nodo2 <0 || nodo2 >= Grafo.NumGrupos())
            {
                throw new ArgumentException("nodos fuera  de rango ");

            }
            return Grafo.GrupoCorrelativo(nodo1) == Grafo.GrupoCorrelativo(nodo2);
        }
        
    }
}
