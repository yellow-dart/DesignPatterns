using DesignPatternsCore.FactoryPattern;
using DesignPatternsCore.TemplateMethod;

namespace DesignPatternsCore
{
    class Program
    {
        public static void Main()
        {
            var player = PlayerFactory.LoadPlayer();

            var monster = MonsterFactory.CreateRandomMonster();

            var falbos = new MilwaukeeStylePizzaStore();
            falbos.CreatePizzaForDelivery();
        }

        public static void TakeABunchOfOrders()
        {
            var myCoolPizzaStore = PizzaStoreFactory.CreateMeAPizzaStore("falbos");
            myCoolPizzaStore.CreatePizzaForDelivery();
            
            myCoolPizzaStore = PizzaStoreFactory.CreateMeAPizzaStore("zaffiros");
            myCoolPizzaStore.CreatePizzaForDelivery();
        }
    }

    internal class PizzaStoreFactory
    {
        public static BasePizzaStore CreateMeAPizzaStore(string falbos)
        {
            return new MilwaukeeStylePizzaStore();
        }
    }
}
