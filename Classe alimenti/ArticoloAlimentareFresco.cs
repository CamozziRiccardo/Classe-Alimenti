using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_alimenti
{
    public class ArticoloAlimentareFresco : ArticoloAlimentare
    {
        private int _prefCons;

        public int PrefCons
        {
            get { return _prefCons; }
            set { _prefCons = value; }
        }

        public ArticoloAlimentareFresco() : base()
        {
            PrefCons = 3;
        }

        public ArticoloAlimentareFresco(int codice, int prefCons, int anno, string descrizione, double prezzoUnit, bool cartaFed) : base(codice, anno, descrizione, prezzoUnit, cartaFed)
        {
            PrefCons = prefCons;
        }

        public ArticoloAlimentareFresco(ArticoloAlimentareFresco vecchioArtAlimFre, ArticoloAlimentare vecchioArtAlim, Articolo vecchioArt) : base(vecchioArtAlim, vecchioArt)
        {
            PrefCons = vecchioArtAlimFre.PrefCons;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Consumarsi entro: {PrefCons}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloAlimentareFresco other = (ArticoloAlimentareFresco)obj;

            if (base.Equals(other) && PrefCons == other.PrefCons)
            {
                return true;
            }

            return false;
        }

        public override double Sconta()
        {
            double perc = 10F;
            double s = base.Sconta();

            for (int i = 1; i < 6 && i < PrefCons; i++)
            {
                perc -= 2F;
            }

            return s - s * perc / 100;
        }
    }
}
