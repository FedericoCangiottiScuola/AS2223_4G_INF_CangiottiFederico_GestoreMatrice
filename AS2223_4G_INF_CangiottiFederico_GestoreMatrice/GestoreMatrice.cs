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
        }

        /// <summary>
        /// Istanzia e carica la matrice con la matrice passata come parametro
        /// </summary>
        /// <param name="mat"></param>
        public GestoreMatrice(int[,] mat)
        {
        }

        /// <summary>
        /// Carica la matrice con valori casuali fra minValue e MaxValue
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public void CaricaMatrice(int minValue, int maxValue)
        {
        }

        /// <summary>
        /// Stampa la matrice nella console opportunamente formattata
        /// </summary>
        public void StampaMatrice()
        {
        }

        /// <summary>
        /// Stampa la cornice della matrice da [0,0] per righe distinte in senso antiorario
        /// </summary>
        public void StampaCornice()
        {
        }

        /// <summary>
        /// Inverte i valori della prima colonna della matrice con l'ultima
        /// </summary>
        /// <returns></returns>
        public void InvertiPrimaUltimaColonna()
        {
        }

        /// <summary>
        /// Cerca il valore passato nella matrice e restituisce il numero di occorrenze
        /// </summary>
        /// <param name="valoreDaCercare"></param>
        /// <returns></returns>
        public int ContaValore(int valoreDaCercare)
        {
            int nValori = 0;

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