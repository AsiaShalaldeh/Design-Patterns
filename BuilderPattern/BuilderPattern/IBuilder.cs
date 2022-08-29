using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void StartOperations();
        void MakeDough();
        void PourDough();
        void AddToppingIngredients();
        void BakePizza();
        void EndOperations();
        Pizza getPizza();
    }
}
