using System;
using System.Collections.Generic;
using System.Text;

namespace EsGarage_Andreella
{
    public class CVeicolo
    {
        public int Id { get; set; }
        protected string Marca { get; set; }
        protected int Anno { get; set; }
        protected int Cilindrata { get; set; }

        public CVeicolo(int id, string marca, int anno, int cilindrata)
        {
            Id = id;
            Marca = marca;
            Anno = anno;
            Cilindrata = cilindrata;
        }

        public virtual string StampaInformazioni()
        {
            return $"ID: {Id}, Marca: {Marca}, Anno: {Anno}, Cilindrata: {Cilindrata}cc";
        }
    }
}
