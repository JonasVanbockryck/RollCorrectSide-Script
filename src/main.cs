using System;
using System.Diagnostics;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using HarmonyLib;
using Il2CppDumper;
using Il2CppSystem.IO;
using Il2CppSystem.Security.Cryptography;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using Random = System.Random;

namespace BaseMod;

[BepInPlugin(GUID, NAME, VERSION)]
public class main : BasePlugin
{
    public const string GUID = AUTHOR + "." + NAME;
    public const string NAME = "RollCorrectSideScript";
    public const string VERSION = "0.0.1";
    public const string AUTHOR = "Froggo";

    public override void Load()
    {
        var harmony = new Harmony(NAME);

        CoinRollCorrectSide.Setup(harmony);
    }
}
