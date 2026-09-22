using System;
using System.Collections.Generic;
using System.Text;

namespace EsGarage_Andreella
{
    public class CAuto : CVeicolo
    {
        protected int Porte { get; set; }
        protected string Alimentazione { get; set; }
        public CAuto(int id, string marca, int anno, int cilindrata, int porte, string alimentazione)
            : base(id, marca, anno, cilindrata)
        {
            Porte = porte;
            Alimentazione = alimentazione;
        }
        public override string StampaInformazioni()
        {
            return base.StampaInformazioni() + $", Porte: {Porte}, Alimentazione: {Alimentazione}";
        }
    }
}
