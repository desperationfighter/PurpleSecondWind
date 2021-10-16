﻿#if SN1
namespace UnobtaniumBatteries.Patches
{
    using HarmonyLib;

    [HarmonyPatch(typeof(Inventory), nameof(Inventory.Pickup))]
    public static class Inventory_Pickup_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Pickupable pickupable)
        {
            if(pickupable.GetTechType() == TechType.Warper)
            {
                Warper warper = pickupable.GetComponent<Warper>();
                if(warper != null && warper.spawner != null)
                {
                    warper.spawner.warper = null;
                    warper.spawner.OnWarpOut();
                    warper.spawner = null;
                }
            }
        }
    }
}
#endif