using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DesignPatternsCore.FactoryPattern;

namespace DesignPatternsCore
{
    class Program
    {
        public static void Main()
        {
            var player = PlayerFactory.LoadPlayer();

            var monster = MonsterFactory.CreateRandomMonster();
        }
    }
}
