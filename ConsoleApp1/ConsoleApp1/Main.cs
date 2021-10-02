using System;
using System.Collections.Generic;

namespace Main{
    class Program{
        static void Main(){
            bool choix = true;
            List<Matiere> lP = new List<Matiere>();
            while (choix == true){
                // menu de saisie
                Console.WriteLine("Que voulez vous faire ?");
                Console.WriteLine("1. Creer une nouvelle Matière");
                Console.WriteLine("2. Afficher les matières");
                Console.WriteLine("3. Quitter");
                string choixUtilisateur = Console.ReadLine();
                if (choixUtilisateur == "1"){
                    Matiere nouvellematiere = CreerMatiere();
                    lP.Add(nouvellematiere);
                }
                else if (choixUtilisateur == "2"){
                    Console.WriteLine("***********************************");
                    foreach (Matiere matiereinboucle in lP)
                    {
                        string messageAAfficher = CreerMessage(matiereinboucle);
                        Console.WriteLine(messageAAfficher);
                        Console.WriteLine("***********************************");
                    }
                }
                else if(choixUtilisateur == "3"){
                    choix = false;
                }
                
            }
        }
        public static Matiere CreerMatiere(){
            Matiere m = new Matiere();

            // demander le nom
            m.Nom = DemandeString("Quel est le nom de ta matière ?");
            // demander le code
            m.Code = DemandeEntier("Quel est son CODE ( > 0 ) ?");
            // demander le nombre d'heures
            m.heures = DemandeEntier("Quel est son nombre d'heures enseignées ?");

            return m;
        }
        public static string DemandeString(string message){
            bool oui = false;
            bool monTexteEstEntier = true;
            int entier;
            string input = "";
            while (oui == false){
                Console.WriteLine(message);
                input = Console.ReadLine();
                string testupper = input.Substring(0, 1);
                char testupper2 = char.Parse(testupper);
                monTexteEstEntier = int.TryParse(input,out entier);
                if (char.IsUpper(testupper2) == true && monTexteEstEntier==false)
                {
                    oui = true;
                }
                else{
                    Console.WriteLine("le nom de la matière n'est pas correct (il doit commencer par une MAJ et ne doit pas etre un nombre)");
                }
            }
            return input;

        }
        public static int DemandeEntier(string message){
            bool monTexteEstEntier = false;
            int Code = 1;

            while (monTexteEstEntier == false) {
                Console.WriteLine(message);
                string monTexte = Console.ReadLine();
                monTexteEstEntier = int.TryParse(monTexte, out Code);
                if (monTexteEstEntier == false)
                {
                    Console.WriteLine("ceci n'est pas un nombre");
                }
            }

            return Code;
        }
        public static string CreerMessage(Matiere m)
        {
            string message = "";
            message = "Matière : " + m.Nom + ", Code : " + m.Code + ", Nb heures de la matière : "+ m.heures;
            return message;
        }
    }
}