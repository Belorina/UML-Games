using System;
using ClasseBase;

namespace UML_Cours_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Personnage perso1 = new Personnage(); // creation object 
            // Personnage perso2 = new Personnage();
            perso1.seDeplacer();
            perso1.attaquer();

            perso1.Force = 50; // appelle au set 
            Console.WriteLine("La force de perso1 est : " + perso1.Force);
            perso1.Force += 25;
            Console.WriteLine("La force de perso1 est : " + perso1.Force);

            Console.WriteLine(perso1.obtenirDescription());

            string msgDescription = perso1.obtenirDescription();
            Console.WriteLine(msgDescription);


        }
    }
}
