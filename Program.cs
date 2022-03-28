using System;
using poo_em_c_.Entities;

namespace dotnet___poo
{
    class Program
    {
        static void Main(string[] args)
        {
            knight arus = new knight("Arus", 23, "Knight");
            wizard wizard = new wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));


        }
    }
}


