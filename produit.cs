using System;
namespace appfacturation
{
	public class produit
	{
		public int numeroproduit { get; set; }
		public string nomproduit { get; set; }
        public int prix { get; set; }
        public DateTime date_expiration { get; set; }

        private List<produit> produits = new List<produit>();


        public void Ajouterproduit(int Numeroproduit, string Nomproduit, int Prix, DateTime Date_expiration)

        {
            produit produit= new produit
            {

                numeroproduit = Numeroproduit,
                nomproduit = Nomproduit,
                prix = Prix,
                date_expiration = Date_expiration
               
            };
            produits.Add(produit);
            Console.WriteLine("ajouté avec succès !");
        }


        public produit Rechercherproduit(int numeroproduit)
        {
            return produits.Find(p => p.numeroproduit == numeroproduit);
        }
        public produit()
		{
	
		}
	}
}

