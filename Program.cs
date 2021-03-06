﻿using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static int epoch = 500;

    static void Main(string[] args)
    {
        // vytvor nahodne hrace
        List<HoubarovoChovani> hraci = new List<HoubarovoChovani>();
        hraci.Add(new NahodnyHrac());
        hraci.Add(new HladovyHrac());

        Svet s = new Svet(32, 32, hraci, 15, 25, 100);
        for (int i = 0; i < epoch; ++i)
        {
            Console.WriteLine($"Epocha {i}");
            s.ukazMapu();
            s.krok();
            Thread.Sleep(100);
            Console.Clear();
        }
    }
}
