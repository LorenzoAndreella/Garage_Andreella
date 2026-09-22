using System;
using System.Collections.Generic;
using System.Text;

namespace EsGarage_Andreella
{
    public class CGarage
    {
        public static int MaxVeicoli = 15;
        public List<CVeicolo> elencoVeicoli { get; protected set; }

        public CGarage()
        {
            elencoVeicoli = new List<CVeicolo>();
        }

        public void AggiungiVeicolo(CVeicolo veicolo)
        {
            if (elencoVeicoli.Count >= MaxVeicoli)
            {
                throw new InvalidOperationException("Garage pieno, impossibile aggiungere un nuovo veicolo.");
            }
            elencoVeicoli.Add(veicolo);
        }

        public CVeicolo EstrazioneVeicolo(int posizione)
        {
            if (posizione < 0|| posizione >= elencoVeicoli.Count)
            {
                throw new ArgumentException("Posizione non valida, impossibile estrarre il veicolo.");
            }

            CVeicolo veicolo = elencoVeicoli[posizione];
            elencoVeicoli.RemoveAt(posizione);

            for (int i=posizione; i < elencoVeicoli.Count; i++)
            {
                elencoVeicoli[i].Id = i;
            }

            return veicolo;

        }

        public string StampaSituazione()
        {
            string situazione = "Situazione Garage:\n";
            for (int i = 0; i < elencoVeicoli.Count; i++)
            {
                if (elencoVeicoli[i] != null)
                {
                    situazione += elencoVeicoli[i].StampaInformazioni() + "\n";
                }
            }
            return situazione;
        }
    }
}
