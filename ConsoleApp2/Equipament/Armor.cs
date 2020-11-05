﻿using WarriorWars.Enum;

namespace WarriorWars.Equipament
{
    class Armor
    {
        private int GOOD_GUY_ARMOR;
        private int BAD_GUY_ARMOR;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }

        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}
