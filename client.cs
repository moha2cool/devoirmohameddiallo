using System;
namespace appfacturation
{
	public class client
	{
		public int numeroclient { get; set; }
		public string nomclient { get; set; }
		public string prenomclient { get; set; }
		public string adresse { get; set; }

        private List<client> clients= new List<client>();


        public void Ajouterclient(int Numeroclient, string Nomclient, string Prenomclient, string Adresse)

        {
            client client= new client
            {

                numeroclient = Numeroclient,
                nomclient = Nomclient,
                prenomclient = Prenomclient,
                adresse =Adresse
  
            };
            clients.Add(client);
            Console.WriteLine("ajouté avec succès !");
        }

        public client Rechercherproduit(int numeroclient)
        {
            return clients.Find(p => p.numeroclient == numeroclient);
        }


        public client()
		{ }
	}

}