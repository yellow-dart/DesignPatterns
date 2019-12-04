using System;

namespace DesignPatternsCore.FactoryPattern
{
    public static class PlayerFactory
    {
        public static Player LoadPlayer()
        {
            var playerType = GetSomePlayerType();

            switch (playerType)
            {
                case 1:
                    return new Player(100, 20000, 500000);
                case 2:
                    return new Player(10, 0, 50);
                default:
                    throw new Exception("I pity the fool who didn't choose the right player type.");
            }
        }

        private static int GetSomePlayerType()
        {
            return 2;
        }
    }
}