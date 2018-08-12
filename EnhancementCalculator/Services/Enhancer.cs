﻿using EnhancementCalculator.Constants;

namespace EnhancementCalculator.Services
{
    public static class Enhancer
    {
        private const double ssBonus = 0.3;
        public static (int patack, int matack) EnhanceItem(int basePatak, int baseMatak, int enhancementLevel, WeaponClass weaponType)
        {
            int finalPatack = basePatak;
            int finalMatack = baseMatak;
            var enhancementBonus = GetEnhancementBonus(weaponType);
            if (enhancementLevel>3)
            {
                finalPatack += enhancementBonus.patack * 3;
                finalMatack += enhancementBonus.matack * 3;
                int overEnhancementLevel = enhancementLevel - 3;
                finalPatack += overEnhancementLevel * enhancementBonus.patack * 2;
                finalMatack += overEnhancementLevel * enhancementBonus.matack * 2;
            }
            else
            {
                finalPatack += enhancementLevel * enhancementBonus.patack;
                finalMatack += enhancementLevel * enhancementBonus.matack;
            }
            return (finalPatack, finalMatack);
        }

        public static double CalculateSsBonus(int enhancementLevel)
        {
            return enhancementLevel * ssBonus;
        }

        private static (int patack, int matack) GetEnhancementBonus(WeaponClass weaponType)
        {
            int patackBonus = 0;
            int matackBonus = 0;
            switch (weaponType)
            {
                case WeaponClass.Daggers:
                case WeaponClass.OnehandedSwords:
                case WeaponClass.OnehandedBlunts:
                    patackBonus = 4;
                    matackBonus = 3;
                    break;
                case WeaponClass.TwohandedSwords:
                case WeaponClass.TwohandedBlunts:
                case WeaponClass.DualSwords:
                case WeaponClass.Fists:
                    patackBonus = 5;
                    matackBonus = 3;
                    break;
                case WeaponClass.Bows:
                    patackBonus = 8;
                    matackBonus = 3;
                    break;
                default:
                    break;
            }
            return (patackBonus, matackBonus);
        }
    }
}
