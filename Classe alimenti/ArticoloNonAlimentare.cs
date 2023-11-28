using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_alimenti
{
    public class ArticoloNonAlimentare : Articolo
    {
        private string _materiale;
        private bool _riciclabile;

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public bool Riciclabile
        {
            get { return _riciclabile; }
            set { _riciclabile = value; }
        }

        public ArticoloNonAlimentare() : base()
        {
            Materiale = "";
            Riciclabile = false;
        }

        public ArticoloNonAlimentare(int codice, string materiale, bool riciclabile, string descrizione, double prezzoUnit, bool cartaFed) : base(codice, descrizione, prezzoUnit, cartaFed)
        {
            Materiale = materiale;
            Riciclabile = riciclabile;
        }

        public ArticoloNonAlimentare(ArticoloNonAlimentare vecchioArtNonAlim, Articolo vecchioArt) : base(vecchioArt)
        {
            Materiale = vecchioArtNonAlim.Materiale;
            Riciclabile = vecchioArtNonAlim.Riciclabile;
        }

        public override string ToString()
        {
            string str = Riciclabile ? "Riciclabile" : "Non riciclabile";
            return $"{base.ToString()}; Materiale: {Materiale}; Riciclabilità: {str}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloNonAlimentare other = (ArticoloNonAlimentare)obj;

            if (base.Equals(other) && Materiale == other.Materiale && Riciclabile == other.Riciclabile)
            {
                return true;
            }

            return false;
        }

        public override double Sconta()
        {
            double s = base.Sconta();

            // Sconta ulteriormente in base a s
            if (Riciclabile)
            {
                return PrezzoUnit - s * 10F / 100F;
            }

            // Se ho solo la carta o nessuna delle due
            return s;
        }
    }
}
