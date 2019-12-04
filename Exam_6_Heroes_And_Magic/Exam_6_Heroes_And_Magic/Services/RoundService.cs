﻿using Exam_6_Heroes_And_Magic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Services
{
    public class RoundService
    {
        private Army TeamA { get; set; }
        private Army TeamB { get; set; }
        private bool IsTeamBTurn { get; set; }

        public RoundService ()
        {
            TeamA = new Army("Yellow");
            TeamB = new Army("Violet");
            ChooseFirstTurn();
        }

        private void ChooseFirstTurn()
        {
            Random rand = new Random();
            int index = rand.Next(0, 2);
            IsTeamBTurn = index == 0 ? true : false;
        }

        public void Begin()
        {
            while (TeamB.IsAllUnitsAlive && TeamA.IsAllUnitsAlive)
            {
                HitStepByStep();
                Console.WriteLine($"violetCrusader's lives {TeamB.CurrentHealth} : yellowCrusader's lives {TeamA.CurrentHealth}");
            }
            Console.WriteLine($"violetCrusader's lives {TeamB.CurrentHealth} : yellowCrusader's lives {TeamA.CurrentHealth}");
        }

        private void HitStepByStep()
        {
            if (IsTeamBTurn)
                TeamA.RemoveHealth(TeamB.Damage);
            else
                TeamB.RemoveHealth(TeamA.Damage);

            IsTeamBTurn = !IsTeamBTurn;
        }
    }
}
