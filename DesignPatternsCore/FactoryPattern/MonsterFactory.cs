using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsCore.FactoryPattern;

namespace DesignPatternsCore.FactoryPattern
{
    public static class MonsterFactory
    {
        public static Monster CreateRandomMonster()
        {
            var randomMonster = DoTheMonsterMash();

            switch (randomMonster)
            {
                case 1:
                    return new FlyingMonster();
                case 2:
                    return new LandMonster();
                default:
                    return new SeaMonster();
            }
        }

        private static int DoTheMonsterMash()
        {
            return 3;
        }
    }
}
