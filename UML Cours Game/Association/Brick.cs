using System;

namespace Association
{
    public class Brick
    {
        public string _type;

        public string type 
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

        public void seCasser()
        {
            Console.WriteLine("Brick se casse - POOf -");
        }

        
    }



}