using System;
using System.Collections.Generic;

// exo pas corrigee 

namespace Exo1
{
    public class Vaisseau
    {
        private List<Officier> officiers = new List<Officier>();

        public string _type;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public void quiVole()
        {
            System.Console.WriteLine("Vaisseau vole! ");
        }
    }
}