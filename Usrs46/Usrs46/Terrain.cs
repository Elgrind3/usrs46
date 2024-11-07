﻿using System;
using System.Text.RegularExpressions;

namespace Usrs46
{
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCotesClotures;
        public bool Riviere;

        public Terrain(string adresse, float superficie, int nbPieces, bool jardin)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbCotesClotures = nbPieces;
            Riviere = jardin;
        }

        public override string ToString()
        {
            string toString = String.Format("Nombre de cotés clorutés = {0}\n", this.NbCotesClotures);
            toString += String.Format("Présence d'une rivière = {0}\n", this.Riviere ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$\n", this.EvaluationValeur());
            return toString;
        }


        public new float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Riviere) { facteur += 600; }

            facteur += 100 * this.NbCotesClotures;

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }
    }
}

