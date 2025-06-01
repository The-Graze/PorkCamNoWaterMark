using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace PorkCamNoWaterMark.Patches
{
    [HarmonyPatch(typeof(CameraMod.Camera.Comps.UI))]
    [HarmonyPatch("FetchWatermarkDeleteUserids", MethodType.Normal)]
    internal class CamPatch
    {
        private static bool Prefix(CameraMod.Camera.Comps.UI __instance)
        {
            __instance.watermarkEnabled = false;
            return false;
        }
    }
}