// Scrivere un programma che :
// 1) chiede in ingresso all’utente la dimensione di una matrice quadrata di numeri interi e la riempie con numeri casuali da -100 a 75 (punti 1)
// 2) stampa formattata della matrice
// 3) funzione di conteggio dei valori che restituisca il numero di occorrenze nella matrice del valore passato come parametro (punti 1)
// 4) stampa i valori presenti nella cornice della matrice in senso "anti-"orario
// 5) scrivere una funzione che inverte i valori della prima colonna della matrice con l'ultima
// 6) scrivere un metodo che restituisce il valore medio, minimo e massimo dei valori contenuti nella matrice


// dichiaro e istanzio l'oggetto per la gestione della matrice
using AS2223_4G_INF_CangiottiFederico_GestoreMatrice;
const int MIN_VALUE_MAT = -100;
const int MAX_VALUE_MAT = 75;


// Main()

GestoreMatrice m = new GestoreMatrice(10);

m.StampaMatrice();

// popola la matrice con valori causali nell'intervallo definito in firma
m.CaricaMatrice(MIN_VALUE_MAT, MAX_VALUE_MAT);

m.StampaMatrice();

// stampa la cornice della matrice in senso "anti"-orario a partire da [0,0]
m.StampaCornice();

// visualizza la matrice
m.StampaMatrice();

// inverte i valori della prima colonna della matrice con l'ultima
m.InvertiPrimaUltimaColonna();

// visualizza la matrice
m.StampaMatrice();

// conta valori nella matrice
int valoreDaCercare = 12;
int nValori = m.ContaValore(12);
Console.WriteLine("Trovati " + nValori + " occorrenze del valore " + valoreDaCercare);

int min = 0, max = 0;
double media = 0;

// calcola il valore medio (ritornato) e il min e max della matrice
media = m.CalcolaMinMaxMedio(ref min, ref max);

Console.WriteLine("Min " + min + " max " + max + " e media dei valori " + media);