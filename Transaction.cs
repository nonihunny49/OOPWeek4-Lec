﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek4_Lec
{
    internal class Transaction
    {
        private float val;
        private DateTime date;

        //setter 
        public void setVal(float val) { this.val = val; }
        public void setDate(DateTime date) { this.date = date; }

        //getter
        public float getVal() { return val; }  
        public DateTime getDate() { return date; } 

    }
}
