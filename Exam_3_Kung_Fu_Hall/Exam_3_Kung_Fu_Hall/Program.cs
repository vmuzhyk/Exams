﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3_Kung_Fu_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();
            battle.Begin();
            Console.ReadKey();
        }
    }
}
