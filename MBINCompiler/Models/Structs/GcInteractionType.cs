﻿namespace MBINCompiler.Models.Structs
{
    public class GcInteractionType : NMSTemplate

    // the custom interactions have been added to allow for exactly that. They are not handled differently by the game files and using them might cause interactions to be a bit... weird...
    {
        public int InteractionType;
        public string[] InteractionTypeValues()
        {
            return new[]
            {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
				"Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
				"NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
				"MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth", "Epilogue",
                "CUSTOMINTERACTION0", "CUSTOMINTERACTION1", "CUSTOMINTERACTION2", "CUSTOMINTERACTION3", "CUSTOMINTERACTION4"
            };
        }
    }
}
