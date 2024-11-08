using System;

namespace Usrs46
{
	public class Piece
	{
		public int Superficie;
		public string Nom;

		public Piece(int superficie, string nom)
		{
			Superficie = superficie;
			Nom = nom;
		}

		public override string ToString()
		{
			string toString = String.Format("La pi�ce {0} fait {1}m�", this.Nom, this.Superficie);
			return toString;
		}
	}
}