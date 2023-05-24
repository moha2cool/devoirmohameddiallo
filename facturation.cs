using System;
namespace appfacturation

{
    public class facturation

    {

        public int numerofacture { get; set; }
        public string nomproduit { get; set; }
        public int quantiteproduit { get; set; }
        public DateTime datefacture { get; set; }
        public int total { get; set; }
        public int recu { get; set; }
        private List<facturation> factures = new List<facturation>();

        public void Ajouterfacture(int Numerofacture, string Nomproduit, int Quantiteproduit, DateTime Datefacture, int Total, int Recu)

        {
            facturation facturation = new facturation
            {

                numerofacture = Numerofacture,
                nomproduit = Nomproduit,
                quantiteproduit = Quantiteproduit,
                datefacture = Datefacture,
                total = Total,
                recu = Recu
            };
            factures.Add(facturation);
            Console.WriteLine("Patient ajouté avec succès !");
        }


        public facturation Rechercherfacture(int numerofacture)
        {
            return factures.Find(p => p.numerofacture == numerofacture);
        }


        public void MettreAJourfacture(int Numerofacture, string Nomproduit, int Quantiteproduit, DateTime Datefacture, int Total, int Recu)
        {
            facturation facturation = Rechercherfacture(numerofacture);
            if (facturation != null)
            {

                facturation.numerofacture = Numerofacture;
                facturation.nomproduit = Nomproduit;
                facturation.quantiteproduit = Quantiteproduit;
                facturation.datefacture = Datefacture;
                facturation.total = Total;
                facturation.recu = Recu;
                Console.WriteLine(" mises à jour avec succès !");
            }
            else
            {
                Console.WriteLine(" non trouvé.");
            }
        }


        public void SupprimerPatient(int numerofacture)
        {
            facturation patient = Rechercherfacture(numerofacture);
            if (patient != null)
            {
                factures.Remove(facturation);
                Console.WriteLine(" supprimé avec succès !");

            }
            else
            {
                Console.WriteLine("Patient non trouvé.");
            }
        }

        public facturation()
        {
        }
    }

}