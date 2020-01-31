using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCore.TemplateMethod
{
    public class MilwaukeeStylePizzaStore : BasePizzaStore
    {
        public override void TakeOrder()
        {
            PizzaForDelivery = PizzaFactory.CreateMeAPizza("Milwaukee");
        }

        public override void MakePizza()
        {
            throw new NotImplementedException();
        }

        public override void CookPizza()
        {
            throw new NotImplementedException();
        }
    }

    public class PizzaFactory
    {
        public static IPizza CreateMeAPizza(string pizzaStoreStyle)
        {
            switch (pizzaStoreStyle)
            {
                case "Milwaukee": 
                    return new MilwaukeePizza("Your toppings passed in some where before you just blindly create a pizza");
                default:
                    throw new Exception("There is only one type of pizza worthwhile.");
            }
        }
    }

    public class MilwaukeePizza : IPizza
    {
        public MilwaukeePizza()
        {
            
        }

        public MilwaukeePizza(string toppingsMaybe)
        {
            
        }
    }
}
