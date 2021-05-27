using System;

namespace ClasseBase
{
    public class Personnage
    {
        public int _force;
        public int _stamina;

        public int Force
        {
            get
            {
                return _force;
            }
            set
            {
                _force = value;
            }
        }

        public int Stamina
        {
            get
            {
                return _stamina;
            }
            set
            {
                _stamina = value;
            }
        }

        public void seDeplacer()        // void ne renvoie rien 
        {
            Console.WriteLine("Je bouge!");
        }
        public void attaquer ()
        {
            Console.WriteLine("J'attaque!");
        }


        public string obtenirDescription ()
        {
            string description = "je suis un personnage hello";
            return (description);
        }
    }






}