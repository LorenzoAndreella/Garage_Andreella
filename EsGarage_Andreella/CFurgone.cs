using System;
using System.Collections.Generic;
using System.Text;

namespace EsGarage_Andreella
{
    public class CFurgone : CVeicolo
    {
        protected int Capacita { get; set; }
        public CFurgone(int id, string marca, int anno, int cilindrata, int capacita)
            : base(id, marca, anno, cilindrata)
        {
            Capacita = capacita;
        }
        public override string StampaInformazioni()
        {
            return base.StampaInformazioni() + $", Capacità: {Capacita} L";
        }
    }
}
