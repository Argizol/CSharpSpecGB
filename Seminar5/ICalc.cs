﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB.Seminar5
{
    internal interface ICalc
    {
        event EventHandler<EventArgs> handler;
        Stack<double> _stack { get; set; }
        double _result { get;  set; }
        void Sum(double x);
        void Sub(double x);
        void Mult(double x);
        void Divide(double x);

    }
}
