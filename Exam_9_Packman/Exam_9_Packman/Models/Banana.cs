﻿using Exam_9_Packman.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models
{
    public class Banana : Fruit
    {
        public int Coast { get; set; }
        public Banana(int coast, int percentAppearance) : base(coast, percentAppearance)
        {
        }

        
        

        
    }
}
