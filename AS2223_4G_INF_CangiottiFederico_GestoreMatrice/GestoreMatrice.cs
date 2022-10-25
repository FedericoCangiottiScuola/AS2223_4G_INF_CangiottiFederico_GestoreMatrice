using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_CangiottiFederico_GestoreMatrice
{
    internal class GestoreMatrice
    {
        // definizione e istanziazione matrice in base alle dimensioni indicate dall'utente
        int[,] mat;

        // dimensione della matrice
        int matSize;

        /// <summary>
        /// Istanzia una matrice quadra di dimensione lato
        /// </summary>
        /// <param name="lato"></param>
        public GestoreMatrice(int lato)
        {
            mat = new int[lato, lato];
        }

        /// <summary>
        /// Istanzia e carica la matrice con la matrice passata come parametro
        /// </summary>
        /// <param name="mat"></param>
        public GestoreMatrice(int[,] mat)
        {
            this.mat = new int[mat.GetLength(0), mat.GetLength(1)];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    this.mat[i, j] = mat[i, j];
                }
            }
        }

        /// <summary>
        /// Carica la matrice con valori casuali fra minValue e MaxValue
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public void CaricaMatrice(int minValue, int maxValue)
        {
            Random rand = new Random();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rand.Next(minValue, maxValue + 1);
                }
            }
        }

        /// <summary>
        /// Stampa la matrice nella console opportunamente formattata
        /// </summary>
        public void StampaMatrice()
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Stampa la cornice della matrice da [0,0] per righe distinte in senso antiorario
        /// </summary>
        public void StampaCornice()
        {
            for (int i = 0; i < mat.GetLength(0) - 1; i++)
            {
                Console.WriteLine(mat[i, 0]);
            }
            for (int i = 0; i < mat.GetLength(1) - 1; i++)
            {
                Console.WriteLine(mat[mat.GetLength(0) - 1, i]);
            }

            for (int i = mat.GetLength(0) - 1; i > 0; i--)
            {
                Console.WriteLine(mat[i, mat.GetLength(1) - 1]);
            }
            for (int i = mat.GetLength(1) - 1; i > 0; i--)
            {
                Console.WriteLine(mat[0, i]);
            }
        }

        /// <summary>
        /// Inverte i valori della prima colonna della matrice con l'ultima
        /// </summary>
        /// <returns></returns>
        public void InvertiPrimaUltimaColonna()
        {
            int temp;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                temp = mat[i, 0];
                mat[i, 0] = mat[i, mat.GetLength(1) - 1];
                mat[i, mat.GetLength(1) - 1] = temp;
            }
        }

        /// <summary>
        /// Cerca il valore passato nella matrice e restituisce il numero di occorrenze
        /// </summary>
        /// <param name="valoreDaCercare"></param>
        /// <returns></returns>
        public int ContaValore(int valoreDaCercare)
        {
            int nValori = 0;
            
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == valoreDaCercare)
                    {
                        nValori++;
                    }
                }
            }

            return nValori;
        }

        /// <summary>
        /// Calcola il valore minimo, massimo e medio (ritornato) dei valori inseriti nella matrice
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public double CalcolaMinMaxMedio(ref int min, ref int max)
        {
            double medio = 0;
            int somma = 0;
            min = mat[0, 0];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    somma += mat[i, j];

                    if (mat[i, j] < min)
                    {
                        min = mat[i, j];
                    }

                    if (mat[i, j] > max)
                    {
                        max = mat[i, j];
                    }
                }
            }
            medio = (float)somma / (mat.GetLength(0) * mat.GetLength(1));

            return medio;
        }

        /// <summary>
        /// Ritorna il valore della matrice in una cella
        /// </summary>
        /// <param name="riga"></param>
        /// <param name="colonna"></param>
        /// <returns></returns>
        public int GetValue(int riga, int colonna)
        {
            return 0;
        }
    }
}