using RimWorld;
using Verse;
using UnityEngine;
using System.Collections.Generic;
using LudeonTK;
using RimWorld.Planet;
using System.Linq;
using System;
using HarmonyLib;

namespace FactionFixer
{
    public class FactionFixer : Mod
    {
        public FactionFixer(ModContentPack content) : base(content)
        {
            Log.Message($"Hewwo!");
        }

        [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
        public class ReloadableAttribute : Attribute { }

        [DebugAction("FactionFixer", "Regenerate Factions", false, false, false, false, false, 0, false, allowedGameStates = AllowedGameStates.PlayingOnWorld)]
        [Reloadable]
        private static void DebugActionRegenerateSettlements()
        {
            var world = Current.Game.World;
            var genFactions = world.genData.world.info.factions;

            genFactions.RemoveAll(fac => world.worldObjects.Settlements.Any(x => x.Faction.def.defName == fac.defName));

            FactionGenerator.GenerateFactionsIntoWorldLayer(PlanetLayer.Selected, genFactions);//factions.Select(x => x.def).ToList());

            var factions = Find.FactionManager.AllFactions.Where(x => !x.def.isPlayer && !x.Name.Contains("Player") && !x.temporary);
            var props = AccessTools.GetDeclaredProperties(typeof(Faction));

            foreach (var faction in factions)
            {
                var pstr = "";

                foreach (var prop in props)
                {
                    pstr += $"{prop.Name}: {prop.GetValue(faction) ?? "null"}\n";
                }

                Log.Message(pstr);

                if (faction.leader == null)
                {
                    var success = faction.TryGenerateNewLeader();

                    Log.Message($"Generating new leader for {faction.Name}! Success: {success}");
                }
            }

            Log.Message($"Faction Re-generation completed.");
        }
    }
}