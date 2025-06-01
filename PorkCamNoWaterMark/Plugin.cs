using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace PorkCamNoWaterMark
{
    [BepInDependency("org.pokruk.gorillatag.cameramod")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        Plugin()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}
