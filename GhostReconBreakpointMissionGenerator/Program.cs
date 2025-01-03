﻿Random random = new Random();
string[] typeArray = { "EPISODE 1", "EPISODE 2", "EPISODE 3", "HARUHI ITO", "A LONG ROAD TO VICTORY", "MADS SCHULZ", "STAYING SAFE", "OPERATION AMBER SKY", "RESISTANCE",
                       "OPERATION MOTHERLAND", "OPERATION SILVERSTONE" };
string[] EPISODE1Array = { "OPERATION GREENSTONE", "LTC. COLE D. WALKER", "JACE SKELL", "MAURICE FOX", "AUROA ARCHIPELAGO", "FLYCATCHER", "ROSEBUD", "PAULA MADERA",
                           "CHRISTINA CROMWELL", "SILVERBACK", "CARL CHISUM", "AYANA PURI" };
string[] OPERATIONGREENSTONEArray = { "NO WAY OUT", "EAGLES DOWN" };
string[] LTCCOLEDWALKERArray = { "CHECKMATE", "INTO THE WOLF'S DEN", "BROTHER VS BROTHER" };
string[] JACESKELLArray = { "BACK TO THE BASICS", "SKELL ON THE MOVE", "THE ENEMY OF MY ENEMY" };
string[] AUROAARCHIPELAGOArray = { "THE PRICE OF TRUST", "GHOSTS OF THE PAST", "CRITICAL MASS", "GET THE SCOOP", "ONE MAN'S HELL", "COVER UP", "FOR HONOR", "SONG FOR A REVOLUTION",
                                   "DON'T KILL THE MESSENGER", "PIRATE RADIO", "ICARUS BLUES", "WRITTEN ON STONE", "A SANE NEW WORLD", "TOVARISH", "HORN OF PLENTY", "NATURAL MEDICINE",
                                   "TWISTED NERVES", "KEEP IT ON ICE", "BRING YOUR OWN", "A NEW PERSPECTIVE", "GONE FISHING", "ECO-WARRIOR", "MIND OVER MATTER", "HOME INVASION",
                                   "FIREPOWER", "TREASURE ISLAND", "DEATH ON PRIME TIME", "WEAPONS OF REVENGE", "A SOUL IN REST", "BAD HARVEST", "THE MEETING", "The Titan Program",
                                   "SACRED LAND", "THE SIREN'S CALL" };
string[] PAULAMADERAArray = { "INNOCENT SLAUGHTER", "ONE LAST THING", "AN INGENUOUS GENIUS", "WITHOUT A TRACE", "COLDISH HEART", };
string[] CHRISTINACROMWELLArray = { "RETALIATORY MEASURES", "BLAKE'S LAW", "POWER FAILURE", "GUARDIAN ANGEL", "AN EYE FOR AN A.I." };
string[] CARLCHISUMArray = { "SHOW ME THE WAY", "UNDER HERZOG'S CONTROL", "A MAN OF CONFIDENCE", "MOUNTAIN SIEGE", "A GREAT ESCAPE" };
string[] EPISODE2Array = { "OPERATION CHECKMATE", "THE STRATEGIST", "SAM FISHER", "STEPHANIE BURGESS", "HOLLIE MACKENZIE", "KAREL SEKULIC", "GENERAL PAXTON", "WILLAM VAN DYKE" };
string[] EPISODE3Array = { "MANTICORE", "BASILISK", "ORACLE", "HARPY", "SPHINX", "CYCLOPS", "ATLAS", "GRIFFIN", "MEDUSA", "KRAKEN" };
string[] HARUHIITOArray = { "THE GUN RUNNER", "CROSS THE LINE", "WHISTLEBLOWER", "RALLYING CRY", "HOSTILE TAKEOVER", "LOSS OF INNOCENCE" };
string[] MADSSCHULZArray = { "BREAK THE RULES", "PROOF OF LIFE", "A DEADLY TRAP", "SCIENCE WITHOUT CONSCIENCE", "PATIENT ZERO", "REDEEMING REMEDY" };
string[] OPERATIONAMBERSKYArray = { "THE ROOT OF ALL EVIL", "DESPERATE MEASURES", "DRASTIC REMEDY", "CHASING AN APOCALYPSE", "THE DEVIL WE WANT",
                                    "FIGHT FIRE WITH FIRE", "BREAKING THE WHEEL", "SLUMBERING BEAST", "HUMAN TRIAL(S)" };
string[] RESISTANCEArray = { "COUNTERATTACK", "FRIENDS IN NEED", "HIT THE ROAD", "HEARTS AND SOULS", "LICENSE EXPIRED", "BRAIN DRAIN", "A SAFER PLACE",
                             "SILENT RECOVERY", "TRAFFIC CONTROL" };
string[] OPERATIONSILVERSTONEArray = { "PREPARATION MISSIONS", "NORTH EAST MISSIONS", "DARKWOOD ISLAND MISSIONS", "NORTH WEST MISSIONS", "WEST COAST MISSIONS", "SOUTH ISLANDS MISSIONS", "SOUTH EAST MISSIONS", "EAST SIDE MISSIONS", "ALPINE REGION MISSIONS" };
string[] PREPARATIONMISSIONSArray = { "EP|P1|SHIPPING CENTER", "EP|P2|CHEM-EXTRACTION COMPLEX", "EP|P3|AIRSHIP STATION", "EP|P4|DRONE STATION TIGER 04" };
string[] NORTHEASTMISSIONSArray = { "NE|E1|AIRSHIP STATION", "NE|E2|ENEMY LAND BASE", "NE|E3|EQUIPMENT DEPOT", "NE|E4|AMMUNITION DEPOT", "NE|E5|RADAR STATION NORTH", "NE|E6|EDGEWOOD NORTH", "NE|E7|CAMP TIGER", "NE|V1|ANCIENT HARBOR", "NE|V2|ANTI-AIRCRAFT RUINS",
                                    "NE|V3|EDGEHOD SOUTH", "NE|C1|STATION W052", "NE|D1|CONTROL STATION TIGER 02", "NE|D2|DRONE STATION W051", "NE|D3|DRONE STATION TIGER 03", "NE|D4|DRONE STATION TIGER 04", "NE|D5|FEN BOG TESTING ZONE" };
string[] DARKWOODISLANDMISSIONSArray = { "DW|C1|UNDERWATER CABLE STATION", "DW|C2|COMMS CENTER", "DW|C3|D1|CAMPUS RELAY STATION", "DW|D2|A.I. EXPERIMENTAL CENTER", "DW|D3|DRIFTWOOD ISLETS TEST ZONE", "DW|V1|E1|CAMP KODIAK", "DW|E2|BLACK MOUNT BUNKER" };
string[] NORTHWESTMISSIONSArray = { "NW|E1|COMPOSITE FACTORY", "NW|E2|MAUNGA NUI PORT", "NW|E3|YOUTH SPRING", "NW|E4|STORAGE DEPOT", "NW|E5|TOXIC STORAGE DEPOT", "NW|E6|ANCIENT HARBOR", "NW|E7|OUTPOST BLUE TIGER", "NW|D1|AUROA MATERIALS DEPOT",
                                    "NW|D2|SPANISH FORTRESS", "DW|C1|D3|DRONE STATION W011", "NW|D4|CONTROL STATION TIGER 01", "NW|D5|HYBRID ENGINE FACTORY", "NW|D6|ELECTRIC ENGINE FACTORY", "NW|V1|OUTPOST RED TIGER" };
string[] WESTCOASTMISSIONSArray = { "WC|E1|WHALERS BAY AIRFIELD", "WC|E2|ANCIENT HARBOR", "WC|E3|ANCIENT VILLAGE", "WC|E4|OCEANIC POWER PLANT", "WC|E5|ELECTRIC GRID CONTROL", "WC|D1|DRONE STATION W061", "WC|D2|LAND CHASSIS FACTORY", "WC|D3|AIR CHASSIS FACTORY",
                                    "WC|D4|DRONE STATION W111", "WC|D5|CHANNELS R&D CENTER" };
string[] SOUTHISLANDSMISSIONSArray = { "SI|E1|NAVY FUELING STATION", "SI|E2|FUEL DEPOT", "SI|E3|VULTURE SAM SITE", "SI|E4|WEST RADAR STATION", "SI|E5|FUEL STORAGE", "SI|E6|ANTI-AIRCRAFT BATTERY", "SI|E7|ABANDONED BARRACKS", "SI|E8|NAVAL BASE",
                                       "SI|E9|AMMUNITION STORAGE", "SI|E10|NAVAL BASE AIRFIELD", "SI|D1|ARROW TESTING ZONE", "SI|C1|D2|DRONE STATION S01" };
string[] SOUTHEASTMISSIONSArray = { "SE|E1|LIBERTY AIRPORT", "SE|E2|AUROA PARLIAMENT", "SE|E3|LIBERTY CITY", "SE|E4|LIBERTY PORT", "SE|E5|LIBERTY TRANSPORT HUB", "SE|E6|JACE SKELL DAM", "SE|E7|FREEMAN RESIDENCES", "SE|E8|CAMP FOX", "SE|E9|ANCIENT FORT",
                                    "SE|E10|ANCIENT VILLAGE", "SE|D1|DRONE STATION W191", "SE|D2|DRONE STATION W192", "SE|D3|CONTROL STATION FOX 02", "SE|D4|CONTROL STATION FOX 01", "SE|D5|TRAINING CENTER", "SE|D6|CONTROL STATION FOX 01", "SE|D7|PROTOTYPE WORKSHOP",
                                    "SE|D8|MAINTENANCE AREA", "SE|D9|ASSEMBLY HALL OMEGA 01", "SE|D10|DRONE STATION W132", "SE|C1|STATION W161", "SE|C2|STATION W131" };
string[] EASTSIDEMISSIONSArray = { "ES|E1|OUTPOST GREEN VIPER", "ES|E2|AUROA AIRPORT", "ES|E3|SKELL SECURITY", "ES|E4|VEGA RESIDENCES", "ES|E5|TWO LAKES RESIDENCES", "ES|E6|ANCIENT FORT", "ES|E7|ANCIENT VILLAGE", "ES|E8|ANCIENT FORT", "ES|V1|OUTPOST BLACK TIGER",
                                   "ES|D1|RED VIPER OUTPOST", "ES|D2|PROTOTYPE WORKSHOP", "ES|D3|SKELL SECURITY ASSEMBLY HALL", "ES|D4|CONTROL STATION VIPER 04" };
string[] ALPINEREGIONMISSIONSArray = { "AR|E1|MINING CONTROL CENTER", "AR|E2|MATHILDAS PLACE", "AR|E3|FOOD STOCKPILE", "AR|E4|OUTPOST RED FERRET", "AR|C1|AUROA INTRANET CONTROL", "AR|C2|SUBMARINE CABLE CONTROL", "AR|C3|AUROA WEATHER CONTROL",
                                       "AR|V1|RED WEASEL OUTPOST", "AR|D1|DRONE STATION W041", "AR|D2|CAMP BLACK WIDOW", "AR|D3|DRONE STATION W071", "AR|D4|NATURAL HAZARDS CONTROL", "AR|D5|ASSEMBLY HALL OMEGA 02", "AR|D6|GOLD TRAIL TESTING ZONE" };
string[] provinceArray = { "SECTOR 03", "SECTOR 01", "SECTOR 02", "CAPE NORTH", "DRIFTWOOD ISLETS", "SMUGGLER COVES", "SINKING COUNTRY", "WILD COAST", "MOUNT HODGSON", "FEN BOG",
                           "NEW ARGYLL", "SILENT MOUNTAIN", "WHALER'S BAY", "INFINITY", "LAKE COUNTRY", "GOOD HOPE MOUNTAIN", "CHANNELS", "NEW STIRLING", "RESTRICTED AREA 01",
                           "SEAL ISLANDS", "LIBERTY", "EGG ISLAND", "WINDY ISLANDS" };
string[] SECTOR03Array = { "PROTOTYPE WORKSHOP", "LAVADUCT", "LAVA SHIELD", "SCANDIUM MINE", "NO MAN'S LAND", "RED PHOENIX OUTPOST" };
string[] SECTOR01Array = { "CHEMICAL PIPELINE", "CHEMICAL REFINERY", "GOLEM ISLAND HELIPORT", "GOLEM ISLAND SATELLITE DISH", "ANCIENT HARBOR" };
string[] SECTOR02Array = { "CAMP SALAMANDER", "CAMP PHOENIX", "FORGOTTEN SANCTUARY", "GOLEM ISLAND TESTING ZONE", "MISSILE SITE RGUINS", "QUANTUM COMPUTER CENTER" };
string[] CAPENORTHArray = { "A.I. EXPERIMENTAL CENTER", "DRIFTWOOD ISLETS TESTING ZONE", "CAMPUS RELAY STATION", "CAMPUS DATA FARM", "UNDERWATER CABLE STATION", "CONSTRUCTION SITE", "SKELL FOUNDATION CAMPUS", "DARKWOOD ISLAND PORT" };
string[] DRIFTWOODISLETSArray = { "DRIFTWOOD ISLETS TESTING ZONE", "CAMP KODIAK" };
string[] SMUGGLERCOVESArray = { "MAUNGA NUI PORT", "SPANISH FORTRESS", "CHECKPOINT TIGER CHARLIE", "SMUGGLER COVES FREIGHT YARD", "CHECKPOINT TIGER BRAVO", "COMPOSITE FACTORY", "CHECKPOINT TIGER DELTA", "DRONE STATION W011", "OUTPOST RED TIGER", "WIND FARM W01",
                                "AUROA MATERIALS DEPOSIT", "POLYMORPH MODELING", "FOXGLOVE STATION", "OLEANDER STATION", "CHECKPOINT TIGER ALPHA" };
string[] OBJECTIVESArray = { "Neutralise all hostiles.", "Stay undetected.", "Disable all S.A.M.S.", "Destroy all enemy vehicles.", "Eliminate the enemy HVTs.", "Interrogate enemy HVTs.", "Disable or destroy enemy mortars, turrets, helicopters and generators.",
                        "Capture an enemy HVT.", "Obtain any laptops and deliver them to Erewhon.", "Perform this mission during the night.", "Perform this mission during the day.", "Rescue captives.", "Destroy enemy antennas.", "Add tracker to enemy containers.",
                        "Steal enemy vehicles.", "Return the information in biometric rooms to Erewhon." };
string[] SKULLSArray = { "You can only heal after you melee an enemy.", "HUD does not display on screen.", "Ghost trades his Night Vision for Optical Camo", "Auto aim features disabled for all weapons.",
                    "Map is disabled.", "Players cannot pickup or use enemy weapons", "Headshots only.", "Dying in co-op resets the mission.", "Sniper rifles only.", "No suppressors are allowed.", "No class items are allowed.", "No class techniques are allowed.",
                    "No drones are allowed.", "No voice communication is allowed.", "Optical Camo has been disabled." };
Console.WriteLine("Hello, Ghost!");
Console.WriteLine("Welcome to Breakpoint Mission Generator created by Justin Zhao");
Console.WriteLine("Enter 1 to randomly generate your in game mission.");
Console.WriteLine("Enter 2 to randomly generate a base.");
Console.WriteLine("Enter 0 to exit");
string input = Console.ReadLine();
while (Convert.ToInt32(input) != 0)
{
    if(Convert.ToInt32(input) == 1)
    {
        int type = random.Next(0, 11);
        Console.WriteLine(typeArray[type]);
        if (type == 0)
        {
            int EPISODE1 = random.Next(0, 12);
            Console.WriteLine(EPISODE1Array[EPISODE1]);
            if (EPISODE1 == 0)
            {
                int OPERATIONGREENSTONE = random.Next(0, 2);
                Console.WriteLine(OPERATIONGREENSTONEArray[OPERATIONGREENSTONE]);
            }
            if (EPISODE1 == 1)
            {
                int LTCCOLEDWALKER = random.Next(0, 3);
                Console.WriteLine(LTCCOLEDWALKERArray[LTCCOLEDWALKER]);
            }
            if (EPISODE1 == 2)
            {
                int JACESKELL = random.Next(0, 3);
                Console.WriteLine(JACESKELLArray[JACESKELL]);
            }
            if (EPISODE1 == 4)
            {
                int AUROAARCHIPELAGO = random.Next(0, 33);
                Console.WriteLine(AUROAARCHIPELAGOArray[AUROAARCHIPELAGO]);
            }
            if (EPISODE1 == 7)
            {
                int PAULAMADERA = random.Next(0, 5);
                Console.WriteLine(PAULAMADERAArray[PAULAMADERA]);
            }
            if (EPISODE1 == 8)
            {
                int CHRISTINACROMWELL = random.Next(0, 5);
                Console.WriteLine(CHRISTINACROMWELLArray[CHRISTINACROMWELL]);
            }
            if (EPISODE1 == 10)
            {
                int CARLCHISUM = random.Next(0, 5);
                Console.WriteLine(CARLCHISUMArray[CARLCHISUM]);
            }
        }
        else if (type == 1)
        {
            int EPISODE2 = random.Next(0, 8);
            Console.WriteLine(EPISODE2Array[EPISODE2]);
        }
        else if (type == 2)
        {
            int EPISODE3 = random.Next(0, 10);
            Console.WriteLine(EPISODE3Array[EPISODE3]);
        }
        else if (type == 3)
        {
            int HARUHIITO = random.Next(0, 6);
            Console.WriteLine(HARUHIITOArray[HARUHIITO]);
        }
        else if (type == 4)
        {
            int ALONGROADTOVICTORY = random.Next(1, 7);
            Console.WriteLine("Mission " + ALONGROADTOVICTORY);
        }
        else if (type == 5)
        {
            int MADSSCHULZ = random.Next(0, 6);
            Console.WriteLine(MADSSCHULZArray[MADSSCHULZ]);
        }
        else if (type == 6)
        {
            int STAYINGSAFE = random.Next(1, 7);
            Console.WriteLine("Mission " + STAYINGSAFE);
        }
        else if (type == 7)
        {
            int OPERATIONAMBERSKY = random.Next(0, 9);
            Console.WriteLine(OPERATIONAMBERSKYArray[OPERATIONAMBERSKY]);
        }
        else if (type == 8)
        {
            int RESISTANCE = random.Next(0, 9);
            Console.WriteLine(RESISTANCEArray[RESISTANCE]);
        }
        else if (type == 9)
        {

        }
        else if (type == 10)
        {
            int OPERATIONSILVERSTONE = random.Next(0, 9);
            Console.WriteLine(OPERATIONSILVERSTONEArray[OPERATIONSILVERSTONE]);
            if (OPERATIONSILVERSTONE == 0)
            {
                int PREPARATIONMISSIONS = random.Next(0, 4);
                Console.WriteLine(PREPARATIONMISSIONSArray[PREPARATIONMISSIONS]);
            }
            if (OPERATIONSILVERSTONE == 1)
            {
                int NORTHEASTMISSIONS = random.Next(0, 16);
                Console.WriteLine(NORTHEASTMISSIONSArray[NORTHEASTMISSIONS]);
            }
            if (OPERATIONSILVERSTONE == 2)
            {
                int DARKWOODISLANDMISSIONS = random.Next(0, 7);
                Console.WriteLine(DARKWOODISLANDMISSIONSArray[DARKWOODISLANDMISSIONS]);
            }
            if (OPERATIONSILVERSTONE == 3)
            {
                int NORTHWESTMISSIONS = random.Next(0, 14);
                Console.WriteLine(NORTHWESTMISSIONSArray[NORTHWESTMISSIONS]);
            }
            if (OPERATIONSILVERSTONE == 4)
            {
                int WESTCOASTMISSIONS = random.Next(0, 10);
                Console.WriteLine(WESTCOASTMISSIONSArray[WESTCOASTMISSIONS]);
            }
            if (OPERATIONSILVERSTONE == 5)
            {
                int SOUTHISLANDSMISSIONS = random.Next(0, 12);
                Console.WriteLine(SOUTHISLANDSMISSIONSArray[SOUTHISLANDSMISSIONS]);
            }
            if (OPERATIONSILVERSTONE == 6)
            {
                int SOUTHEASTMISSIONS = random.Next(0, 22);
                Console.WriteLine(SOUTHEASTMISSIONSArray[SOUTHEASTMISSIONS]);
            }
            if (OPERATIONSILVERSTONE == 7)
            {
                int EASTSIDEMISSIONS = random.Next(0, 13);
                Console.WriteLine(EASTSIDEMISSIONSArray[EASTSIDEMISSIONS]);
            }
            if (OPERATIONSILVERSTONE == 8)
            {
                int ALPINEREGIONMISSIONS = random.Next(0, 14);
                Console.WriteLine(ALPINEREGIONMISSIONSArray[ALPINEREGIONMISSIONS]);
            }
            
        }
        int OBJECTIVES = random.Next(0, 16);
        Console.WriteLine(OBJECTIVESArray[OBJECTIVES]);
        OBJECTIVES = random.Next(0, 16);
        Console.WriteLine(OBJECTIVESArray[OBJECTIVES]);
        int SKULLS = random.Next(0, 15);
        Console.WriteLine(SKULLSArray[SKULLS]);
        Console.WriteLine("Enter 1 if you would like a different in game mission.");
        Console.WriteLine("Enter 2 to randomly generate a base.");
        Console.WriteLine("Enter 0 to exit.");
        input = Console.ReadLine();
        if (Convert.ToInt32(input) == 0)
        {
            continue;
        }
    }
    else if (Convert.ToInt32(input) == 2)
    {
        int province = random.Next(0, 23);
        Console.WriteLine(provinceArray[province]);
        if(province == 0)
        {
            int SECTOR03 = random.Next(0, 6);
            Console.WriteLine(SECTOR03Array[SECTOR03]);
        }
        if(province == 1)
        {
            int SECTOR01 = random.Next(0, 5);
            Console.WriteLine(SECTOR01Array[SECTOR01]);
        }
        if(province == 2)
        {
            int SECTOR02 = random.Next(0, 6);
            Console.WriteLine(SECTOR02Array[SECTOR02]);
        }
        if (province == 3)
        {
            int CAPENORTH = random.Next(0, 8);
            Console.WriteLine(CAPENORTHArray[CAPENORTH]);
        }
        if (province == 4)
        {
            int DRIFTWOODISLETS = random.Next(0, 2);
            Console.WriteLine(DRIFTWOODISLETSArray[DRIFTWOODISLETS]);
        }
        if (province == 5)
        {
            int SMUGGLERCOVES = random.Next(0, 15);
            Console.WriteLine(SMUGGLERCOVESArray[SMUGGLERCOVES]);
        }
        int OBJECTIVES = random.Next(0, 16);
        Console.WriteLine(OBJECTIVESArray[OBJECTIVES]);
        OBJECTIVES = random.Next(0, 16);
        Console.WriteLine(OBJECTIVESArray[OBJECTIVES]);
        int SKULLS = random.Next(0, 15);
        Console.WriteLine(SKULLSArray[SKULLS]);
        Console.WriteLine("Enter 1 for an in game mission.");
        Console.WriteLine("Enter 2 if you would like a different base.");
        Console.WriteLine("Enter 0 to exit.");
        input = Console.ReadLine();
        if (Convert.ToInt32(input) == 0)
        {
            continue;
        }
    }
}
Console.WriteLine("Thanks for using the Ghost Recon Breakpoint Mission Generator created by Justin Zhao");
