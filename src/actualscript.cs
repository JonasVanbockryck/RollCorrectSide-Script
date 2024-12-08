using System;
using System.Collections.Generic;
using HarmonyLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using BepInEx;
using System.Linq;

namespace BaseMod
{
    internal class CoinRollCorrectSide : MonoBehaviour
    {
        public static void Setup(Harmony harmony)
        {
            ClassInjector.RegisterTypeInIl2Cpp<CoinRollCorrectSide>();
            harmony.PatchAll(typeof(CoinRollCorrectSide));
        }

        [HarmonyPatch(typeof(CoinModel), nameof(CoinModel.Roll))]
        [HarmonyPrefix]
        private static void Roll(CoinModel __instance, float prob, BattleActionModel action)
        {
            if (__instance.GetOperatorType() == OPERATOR_TYPE.SUB)
            {
                __instance._result = COIN_RESULT.TAIL;
            }
            else
            {
                __instance._result = COIN_RESULT.HEAD;
            }
        }
    }
}
