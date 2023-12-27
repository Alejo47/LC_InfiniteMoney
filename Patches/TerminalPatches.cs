using HarmonyLib;

namespace InfiniteMoney.Patches
{
    public static class TerminalPatches {
        [HarmonyPatch(typeof(Terminal), nameof(Terminal.RunTerminalEvents))]
        [HarmonyPostfix]
        static void InfMoney(ref int ___groupCredits) {
            ___groupCredits = 69420;
        }
    }
}
