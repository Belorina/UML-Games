using System;
using System.Collections.Generic;

namespace Exo2
{
    public class Player{
        private Boss player = new Player();
        private Boss boss = new Boss();

        public int _hitPoints;

        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                _hitPoints = value;
            }
        }
    }
}