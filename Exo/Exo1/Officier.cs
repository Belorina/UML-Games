using System;
using System.Collections.Generic;

// exo pas corrigee

namespace Exo1
{
    // Créer un diagramme correspondant à cette situation:
    //Un vaisseau spatial et gérée par un officier, un officier gére plusieurs vaisseaux spatiaux

    public class Officier
    {
        private List<Vaisseau> vaisseaux = new List<Vaisseau>();

    
        public string _grade;

        public string Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                _grade = value;
            }
        }

        public void quiPilote()
        {
            Console.WriteLine("Officier qui pilote, zoom zoom.");
        }
    }
}