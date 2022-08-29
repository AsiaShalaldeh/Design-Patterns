using System;
using System.Globalization;
using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using BuilderPattern;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder margherita = new Margherita("Thin-Crust", "Small");
            IBuilder pepperoni = new Pepperoni("Deep-Pan", "Large");

            // Prepare Margherita
            director.Make(margherita);
            Pizza margheritaPizza = margherita.getPizza();
            Console.WriteLine(margheritaPizza.Show());
            // Prepare Pepperoni
            director.Make(pepperoni);
            Pizza pepperoniPizza = pepperoni.getPizza();
            Console.WriteLine(pepperoniPizza.Show());
        }
    }
}
