﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Weapons
{
    class Shield : Item
    {
        public Shield(string id, int healthEffect, int defenseEffect, int attackEffect) 
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
        }
    }
}
