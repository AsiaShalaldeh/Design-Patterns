using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        IBuilder builder;
        public void Make(IBuilder builder)
        {
            this.builder = builder;
            builder.StartOperations();
            builder.MakeDough();
            builder.PourDough();
            builder.AddToppingIngredients();
            builder.BakePizza();
            builder.EndOperations();
        }
    }
}
