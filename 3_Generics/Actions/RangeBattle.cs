﻿using System;
using System.Collections.Generic;

using StrategyGame.Warriors.Abstractions;
using StrategyGame.Warriors.Models;
using StrategyGame.Warriors.Models.Infantry;

using static ITEA_Collections.Common.Extensions;

namespace StrategyGame.Actions
{
    public class RangeBattle : Battle<Gunner, Bowman>
    {
        private List<Knight> knight;
        private List<Bowman> bowmen;

        public RangeBattle(IEnumerable<Gunner> army1, IEnumerable<Bowman> army2) : base(army1, army2)
        {
        }

        public RangeBattle(List<Knight> knight, List<Bowman> bowmen)
        {
            this.knight = knight;
            this.bowmen = bowmen;
        }

        protected override int CountPoints(IEnumerable<CombatUnit> army)
        {
            int total = 0;
            int count = 0;
            foreach (var item in army)
            {
                count++;
                total += item.Health + item.Strength;
            }
            ToConsole($"Total army count: {count}", ConsoleColor.DarkYellow);
            ToConsole($"Total army strength: {total}", ConsoleColor.DarkYellow);
            return total;
        }
    }
}
