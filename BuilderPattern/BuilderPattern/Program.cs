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
            /// We use Builder Pattern when we want to create an object without knowing 
            /// the details and complexity and steps of creating the object
            Director director = new Director();

            //// Prepare Margherita
            IBuilder margherita = new Margherita("Thin-Crust", "Small");
            director.Make(margherita);
            Console.WriteLine(margherita.getPizza().Show());

            //// Prepare Pepperoni
            IBuilder pepperoni = new Pepperoni("Deep-Pan", "Large");
            director.Make(pepperoni);
            Console.WriteLine(pepperoni.getPizza().Show());
        }
    }
}
