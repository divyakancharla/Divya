﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionPractice
{
    partial class A
    {
        partial void setData();
        public void print()
        {
            Console.WriteLine("Class A printing");
            setData();
        }
    }
    
}
