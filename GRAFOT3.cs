
using System;
using System.Collections.Generic;

public class GrafoT3
    {
        private int[,] matrizAdyacente;
        private int cantidadNodos;

        public GrafoT3(int nodos)
        {
            cantidadNodos = nodos;
            matrizAdyacente = new int[nodos, nodos];
        }

        public void AgregarArista(int origen,
                                  int destino,
                                  int peso)
        {
            matrizAdyacente[origen, destino] = peso;
            matrizAdyacente[destino, origen] = peso; 
        }

        public void MostrarMatriz()
        {
            for (int i = 0; i < cantidadNodos; i++)
            {
                for (int j = 0; j < cantidadNodos; j++)
                {
                    Console.Write(matrizAdyacente[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int NumGrupos()
        {
            bool[] visitado = new bool[cantidadNodos];
            int grupos = 0;

            for (int i = 0; i < cantidadNodos; i++)
            {
                if (!visitado[i])
                {
                    grupos++;
                    DFS(i, visitado);
                }
            }

            return grupos;
        }

        private void DFS(int nodo, bool[] visitado)
        {
            visitado[nodo] = true;

            for (int i = 0; i < cantidadNodos; i++)
            {
                if (matrizAdyacente[nodo, i] > 0 && !visitado[i])
                {
                    DFS(i, visitado);
                }
            }
        }

        public bool GrupoCorrelativo(int nodo)
        {
            HashSet<int> grupo = new HashSet<int>();
            bool[] visitado = new bool[cantidadNodos];
            ObtenerGrupo(nodo, visitado, grupo);

            int[] nodosGrupo = new int[grupo.Count];
            grupo.CopyTo(nodosGrupo);
            Array.Sort(nodosGrupo);

            for (int i = 0; i < nodosGrupo.Length - 1; i++)
            {
                if (nodosGrupo[i] + 1 != nodosGrupo[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private void ObtenerGrupo(int nodo, bool[] visitado, HashSet<int> grupo)
        {
            visitado[nodo] = true;
            grupo.Add(nodo);

            for (int i = 0; i < cantidadNodos; i++)
            {
                if (matrizAdyacente[nodo, i] > 0 && !visitado[i])
                {
                    ObtenerGrupo(i, visitado, grupo);
                }
            }
        }
    }




