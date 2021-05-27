using System;
using ClasseBase;
using Heritage;
using Association;

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

            Console.WriteLine(perso1.obtenirDescription());     // premiere version 

            // string msgDescription = perso1.obtenirDescription();    // deuxieme version
            // Console.WriteLine(msgDescription);

            // Heritage 
            AnimalDomestique animal1 = new AnimalDomestique();
            animal1.seDeplacer();

            Gremlin g = new Gremlin();
            g.seDeplacer();
            g.attaquer(90);     // forcer de metre un parametre
            // animal1.attaquer(90); // NON dispo dans doc de animal, attaquer(..) est isole chez gremlin
            Console.WriteLine(g);
            g.Nom = "Gizmo";
            Console.WriteLine("Le Gremlin est " + g.Nom);


            // Association 
            Level level1 = new Level();
            Brick brick1 = new Brick();

            brick1.seCasser();



        }
    }
}
