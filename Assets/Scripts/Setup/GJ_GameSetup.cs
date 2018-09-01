﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameJam.Setup
{
    /// <summary>
    /// here there are all the const variables for the game so they 
    /// can be hardcoded just one time and use them everywhere
    /// </summary>
    public static class GJ_GameSetup
    {
        public static class PlayerPrefs
        {
            public const string LAST_LANGUAGE = "lastLanguagePP";
            public const string MAIN_VOLUME = "mainVolumePP";
        }

        public static class DefaultValues
        {
            public const string CHARACTER_NAME = "Ethan";
            public const int CHARACTER_LEVEL = 1;
            public const int CHARACTER_LIVES = 1;
            public const float CHARACTER_EXPERIENCE = 0;
            public const int CHARACTER_GOLD = 0;
            public const int CHARACTER_REFLEXES = 100;
            public const int CHARACTER_DEFENSES = 100;
        }

        public static class Tags
        {

        }

        public static class Core
        {
            public const int MAX_LEVEL = 100;
        }

        public static class SaveData
        {
            public const bool ALWAYS_NEW_GAME = true;
        }
    }

}
