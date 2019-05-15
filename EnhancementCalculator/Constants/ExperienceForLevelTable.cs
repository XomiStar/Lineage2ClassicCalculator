﻿using System.Collections.Generic;

namespace EnhancementCalculator.Constants
{
    public static class ExperienceForLevelTable
    {
        public static IEnumerable<int> LevelRanges => ExperienceForLevel.Keys;
        public static IReadOnlyDictionary<int, ulong> ExperienceForLevel = new Dictionary<int, ulong>()
        {
               {40,  3395961},
               {41,  4041192},
               {42,  4809020},
               {43,  5722733},
               {44,  6810052},
               {45,  8103962},
               {46,  9724755},
               {47,  11669705},
               {48,  14003647},
               {49,  16804376},
               {50,  20165251},
               {51,  24198302},
               {52,  29037962},
               {53,  34845554},
               {54,  41814665},
               {55,  50177598},
               {56,  60213118},
               {57,  72255741},
               {58,  86706889},
               {59,  104048268},
               {60,  124857920},
               {61,  149829505},
               {62,  179795406},
               {63,  215754487},
               {64,  258905385},
               {65,  310686461},
               {66,  372823754},
               {67,  447388504},
               {68,  541340090},
               {69,  655021510},
               {70,  799126241},
               {71,  982925277},
               {72,  1218827343},
               {73,  1523534179},
               {74,  1919653065},
               {75,  2437959394},
               {76,  3120588023},
               {77,  4056764430},
               {78,  5476631981},
               {79,  7667284774},
               {80,  11500927160},
               {81,  17251390740},
               {82,  25877086110},
               {83,  38815629165},
               {84,  58223443748},
               {85,  87335165621}
        };
        public static bool IsLevelUpPossible(int currentLevel)
        {
            return ExperienceForLevel.ContainsKey(currentLevel+1);
        }
    }
}

