using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_alimenti
{
    public class Articolo
    {
        private int _codice = 0;
        private string _descrizione;
        private double _prezzoUnit;
        private bool _cartaFed;

        public int Codice
        {
            get { return _codice; }
            set { _codice++; }
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public double PrezzoUnit
        {
            get { return _prezzoUnit; }
            set { _prezzoUnit = value; }
        }

        public bool CartaFed
        {
            get { return _cartaFed; }
            set { _cartaFed = value; }
        }

        public Articolo()
        {
            Codice += 1;
            Descrizione = "";
            PrezzoUnit = 0;
            CartaFed = false;
        }

        public Articolo(int codice, string descrizione, double prezzoUnit, bool cartaFed)
        {
            Codice = codice;
            Descrizione = descrizione;
            PrezzoUnit = prezzoUnit;
            CartaFed = cartaFed;
        }

        public Articolo(Articolo vecchioArt)
        {
            Codice = vecchioArt.Codice;
            Descrizione = vecchioArt.Descrizione;
            PrezzoUnit = vecchioArt.PrezzoUnit;
            CartaFed = vecchioArt.CartaFed;
        }

        public override string ToString()
        {
            string str = CartaFed ? "Abbonato" : "Non abbonato";
            return $"Codice: {Codice}; Descrizione: {Descrizione}; Prezzo Unitario: {PrezzoUnit}; Carta Fedeltà: {str}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Articolo other = (Articolo)obj;

            if (Codice == other.Codice && Descrizione == other.Descrizione && PrezzoUnit == other.PrezzoUnit && CartaFed == other.CartaFed)
            {
                return true;
            }

            return false;
        }

        public virtual double Sconta()
        {
            if (CartaFed)
            {
                return PrezzoUnit - PrezzoUnit * 5 / 100;
            }

            return PrezzoUnit;
        }
    }
}
