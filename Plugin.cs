﻿﻿using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using MyCroakinBod;

namespace FrogDetectiveAP;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public const string PluginGUID = "com.Albrekka.FroggyAP";
    public const string PluginName = "FroggyAP";
    public const string PluginVersion = "0.0.1";
    internal static new ManualLogSource Log;

    public override void Load()
    {
        // Plugin startup logic
        Log = base.Log;
        Log.LogInfo($"Plugin {PluginGUID} is loaded!");
    }
}
