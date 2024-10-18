﻿using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using Newtonsoft.Json;
using System.IO;
using UnhollowerRuntimeLib;
using UnityEngine;


namespace FrogDetectiveAP 
{

    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin 
    {
        public const string PluginGUID = "com.Albrekka.FrogDetectiveAP";
        public const string PluginName = "FrogDetectiveAP";
        public const string PluginVersion = "0.0.1";
        public static string SettingsPath = Application.persistentDataPath + "/Randomizer/Settings.json";
        public static string ItemTrackerPath = Application.persistentDataPath + "/Randomizer/ItemTracker.json";
        public static string SpoilerLogPath = Application.persistentDataPath + "/Randomizer/Spoiler.log";
        public ManualLogSource FroggyLogger;

        public void Awake()
        {
            FroggyLogger = new ManualLogSource("FrogDetectiveAP");
            FroggyLogger.LogInfo("Ribbit!  We're live!");
        }
    }
}
            
