using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Margherita : IBuilder
    {
        private string pizzaStyle;
        private string pizzaSize;

        private Pizza pizza;
        public Margherita(string pizzaStyle,string pizzaSize)
        {
            pizza = new Pizza();
            this.pizzaStyle = pizzaStyle;
            this.pizzaSize = pizzaSize;
        }
        void IBuilder.StartOperations()
        {
            pizza.Add("Start Preparing Pizza of Style " + this.pizzaStyle +
                " And " + this.pizzaSize+ " sSize: ");
        }
        void IBuilder.MakeDough()
        {
            pizza.Add("Dough Is Ready");
        }
        void IBuilder.PourDough()
        {
            pizza.Add("Pour the dough");
        }
        void IBuilder.AddToppingIngredients()
        {
            pizza.Add("Toppings Are Added");
        }
        void IBuilder.BakePizza()
        {
            pizza.Add("Bake the Pizza");
        }
        void IBuilder.EndOperations()
        {
            pizza.Add("End Preparing Pizza.");
        }
        Pizza IBuilder.getPizza()
        {
            return this.pizza;
        }
    }

} 
