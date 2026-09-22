using System;
using System.Collections.Generic;
using System.Text;

namespace EsGarage_Andreella
{
    public class CMoto : CVeicolo
    {
        protected string Tempi { get; set; }
        public CMoto(int id, string marca, int anno, int cilindrata, string tempi)
            : base(id, marca, anno, cilindrata)
        {
            Tempi = tempi;
        }

        public override string StampaInformazioni()
        {
            return base.StampaInformazioni() + $", Tempi: {Tempi}";
        }
    }
}
