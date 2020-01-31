using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCore.TemplateMethod
{
    public abstract class BasePizzaStore
    {
        protected IPizza PizzaForDelivery;

        public IPizza CreatePizzaForDelivery()
        {
            TakeOrder();
            ProcessPayment();
            MakePizza();
            CookPizza();
            DeliverPizza();

            return PizzaForDelivery;
        }

        public abstract void TakeOrder();
       
        public abstract void MakePizza();
        
        public abstract void CookPizza();

        internal void ProcessPayment()
        {

        }

        internal void DeliverPizza()
        {

        }
    }

    public interface IPizza
    {
    }
}
