using System;

namespace Heritage  // nom dossier 
{
    public class Gremlin : AnimalDomestique
    {
        public string _nom;     // attribu 

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }

        public void attaquer(int forceAttaque)
        {
            Console.WriteLine("Je sui sun Gremlin et j'attaque avec " + forceAttaque + " HP");
        }

        

    }



        
}
