using System;
using System.Collections.Generic;
using System.Configuration;
using HarmonyLib;
using JetBrains.Annotations;
using UnityModManagerNet;

namespace HideSorcererMarksMod
{
    static class Main
    {
        internal static bool Load([NotNull] UnityModManager.ModEntry modEntry)
        {
            try
            {
                var harmony = new Harmony(modEntry.Info.Id);
                FileLog.Reset();
                harmony.PatchAll();
            }
            catch (Exception ex)
            {
                modEntry.Logger.Error(ex.ToString());
                throw;
            }

            return true;
        }
    }

    /*
     * EXPLANATION:
     * The necessity to replace default view of body decoration and eyes is set in morphotypeSubclassFilterTag flag 
     * (GraphicsDefinitions.MorphotypeSubclassFilterTag) for Sorcerer based characters. For example, morphotypeSubclassFilterTag
     * equals to "SorcererManaPainter" for corresponding subclass and so on for other Sorcerer's subclasses, while for other 
     * subclasses it equals to "Default". Basically we need to set this flag to "Default" for Sorcerer's subclasses to remove
     * forced body decoration and eyes style. As I couldn't change this flag, because it's read only, I found another easy
     * solution to set subClass argument of CharacterBuildingManager.BuildMorphotypeOptionsList method to null, since
     * we only need it to read morphotypeSubclassFilterTag value. While subClass is null, "Default" morphotypeSubclassFilterTag
     * will be used - this is what we needed. This logic will be performed one time during character's creation screen, so
     * this mod can be deleted after character's creation.
     */
    [HarmonyPatch(typeof(CharacterBuildingManager), nameof(CharacterBuildingManager.BuildMorphotypeOptionsList))]
    static class Patch_HideSorcererMarks
    {
        static void Prefix(ref CharacterSubclassDefinition subClass)
        {
            subClass = null;
        }
    }
}