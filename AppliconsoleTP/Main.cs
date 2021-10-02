using System;
using System.Collections.Generic;

namespace Main{
    class Program{
        static void main(){
            bool choix = true;
            List<Matiere lP = new List<Matiere>();
            while (choix == true){
                // menu de saisie
                Console.WriteLine("Que voulez vous faire ?");
                Console.WriteLine("1. Creer une nouvelle Matière");
                Console.WriteLine("2. Afficher les matières");
                Console.WriteLine("3. Quitter");
                string choixUtilisateur = Console.ReadLine();
                if (choixUtilisateur == "1"){
                    Matiere nouvellematiere = CreerMatiere();
                    lP.Add(personnelambda);
                }
                else if (choixUtilisateur == "2"){
                    int Agetotale = 0;
                    foreach(Personne persoinboucle in lP){
                        string messageAAfficher = CreerMessage(persoinboucle);
                        Console.WriteLine(messageAAfficher);
                        Agetotale += persoinboucle.Age;
                    }
                    Console.WriteLine(Agetotale/lP.Count);
                }
                else if(choixUtilisateur == "3"){
                    choix = false;
                }
                
            }
        }
        public static Matiere CreerMatiere(){
            Matiere m = new metiere();

            // demander le nom
            m.Nom = DemandeString("Quel est le nom de ta matière ?");
            // demander le code
            m.Code = DemandeEntier("Quel est son CODE ?");
            // demander le nombre d'heures
            m.Heure = DemandeEntier("Quel est son nombre d'heures enseignées ?");

            return m;
        }
        public static string DemandeString(string message){
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static string DemandeEntier(string message){
            bool monTexteEstEntier = false;
            int Entier = 0;

            while (monTexteEstEntier == false) {
                Console.WriteLine(message);
                string monTexte = Console.ReadLine();
                monTexteEstEntier = int.TryParse(monTexte, out Entier);
            }

            return Entier;
        }
    }
}