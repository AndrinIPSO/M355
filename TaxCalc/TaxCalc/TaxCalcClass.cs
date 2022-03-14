using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalc
{
    public class TaxCalcClass
    {
        public float Betrag { get; set; }
        public float BetragBrutto { get; set; }
        public float BetragNetto { get; set; }
        public float BetragUst { get; set; }
        public bool isNetto { get; set; }
        public float ustProzent { get; set; }

        public TaxCalcClass()
        {

        }

        public void BerechneBetrag()
        {
            if (isNetto)
            {
                BetragNetto =  Betrag - (Betrag / 100 * ustProzent);
            }
            else
            {
                BetragBrutto = Betrag + (Betrag / 100 * ustProzent);
            }
        }
    }
}
