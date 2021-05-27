using System;

namespace Heritage  // nom dossier 
{
    public class AnimalDomestique
    {
        public int _stamina;

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

        public void seDeplacer () 
        {
            Console.WriteLine("Je bouge pas mal, je suis un AnimalDomestique");
        }


    }



        
}
