﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller.Models.Abstract
{
    public interface IUnit
    {
        string Name { get; }
        int CurrentHealth { get; set; }
        int MaxHealth { get; set; }
        int Damage { get; set; }
        /*void Attack(UnitBase defender);
        void Attack(Army defenderArmy);
        void HitBack(UnitBase attacker);*/

        bool IsAlive { get; }
    }
}