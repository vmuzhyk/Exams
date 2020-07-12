﻿using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Interceptor : Aircraft
    {
        public Interceptor(int maxHealt, int damage, Cruiser parentcruiser) : base(maxHealt, damage, parentcruiser)
        {
        }
        public override string ToString()
        {
            return $"I({CurrentHealth})";
        }
    }
}
