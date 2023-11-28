using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_alimenti
{
    public class ArticoloAlimentare : Articolo
    {
        private int _anno;

        public int Anno
        {
            get { return _anno; }
            set
            {
                if (this is ArticoloAlimentare)
                    _anno = value;
                else
                    _anno = DateTime.Now.Year;
            }
        }

        public ArticoloAlimentare() : base()
        {
            Anno = DateTime.Now.Year + 2;
        }

        public ArticoloAlimentare(int codice, int anno, string descrizione, double prezzoUnit, bool cartaFed) : base(codice, descrizione, prezzoUnit, cartaFed)
        {
            Anno = anno;
        }

        public ArticoloAlimentare(ArticoloAlimentare vecchioArtAlim, Articolo vecchioArt) : base(vecchioArt)
        {
            Anno = vecchioArtAlim.Anno;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Anno: {Anno}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloAlimentare other = (ArticoloAlimentare)obj;

            if (base.Equals(other) && Anno == other.Anno)
            {
                return true;
            }

            return false;
        }

        public override double Sconta()
        {
            double s = base.Sconta();

            // Se ho la condizione dell'anno o sia anno che carta
            if (Anno == DateTime.Now.Year)
            {
                return PrezzoUnit - s * 20F / 100F;
            }

            // Se non ho nessuna delle due
            return s;
        }
    }
}
