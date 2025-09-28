Random random = new Random();
string[] typeArray = { "EPISODE 1", "EPISODE 2", "EPISODE 3", "HARUHI ITO", "A LONG ROAD TO VICTORY", "MADS SCHULZ", "STAYING SAFE", "OPERATION AMBER SKY", "RESISTANCE",
                       "OPERATION MOTHERLAND", "OPERATION SILVERSTONE", "OPERATION FIRST STRIKE" };
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
string[] OPERATIONFIRSTSTRIKEMISSIONSArray = { "OPERATION FIRST STRIKE 1", "OPERATION FIRST STRIKE 2", "OPERATION FIRST STRIKE 3", "OPERATION FIRST STRIKE 4" };
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
                                "AUROA MATERIALS DEPOSIT", "POLYMORPH MODELING", "FOXGLOVE STATION", "OLEANDER STATION", "CHECKPOINT TIGER ALPHA", "EMERGENCY CENTER" };
string[] SINKINGCOUNTRYArray = { "ANCIENT HARBOR", "HOWARD AIRFIELD", "CARACARAS SAM SITE", "HARRIER SAM SITE", "SCHULZ HOMESTEAD", "RADAR STATION NORTH", "OSPREY SAM SITE", "CHECKPOINT TIGER GOLF", "BUNKER EDGEHOD NORTH", "ANTI-AIRCRAFT RUINS", "HOWARD PORT",
                                 "AMMUNITION DEPOT", "CHECKPOINT TIGER INDIA", "SPARROWHAWK SAM SITE", "SENTINEL CORP. LAND BASE", "CHECKPOINT TIGER JULIET", "CAMP TIGER", "EQUIPMENT DEPOT", "CHECKPOINT TIGER KILO", "RUSSELL HOMESTEAD", "BUNKER EDGEHOD SOUTH" };
string[] WILDCOASTArray = { "ANCIENT HARBOR", "HOWARD AIRFIELD", "CARACARAS SAM SITE", "HARRIER SAM SITE", "SCHULZ HOMESTEAD", "RADAR STATION NORTH", "OSPREY SAM SITE", "CHECKPOINT TIGER GOLF", "BUNKER EDGEHOD NORTH", "ANTI-AIRCRAFT RUINS", "HOWARD PORT",
                            "AMMUNITION DEPOT", "CHECKPOINT TIGER INDIA", "SPARROWHAWK SAM SITE", "SENTINEL CORP. LAND BASE", "CHECKPOINT TIGER JULIET", "CAMP TIGER", "EQUIPMENT DEPOT", "CHECKPOINT TIGER KILO", "RUSSELL HOMESTEAD", "BUNKER EDGEHOD SOUTH" };
string[] MOUNTHODGSONArray = { "CHEM-EXTRACTION COMPLEX", "BALD PEAK MINE", "SILENT VALLEY MINE", "DRONE STATION W041", "CHECKPOINT TIGER ECHO" };
string[] FENBOGArray = { "AIRSHIP AIR STATION", "WHITESTONE FARM", "ANCIENT RUINS", "SHIPPING CENTER", "LONGFORD FARM", "DRONE STATION W052", "BEHEMOTH DEFENSE AREA", "ANDERSONS FARM", "CONTROL STATION TIGER 02", "CHECKPOINT TIGER BRAVO", "CONTROL STATION TIGER 03",
                         "HARRIS HOMESTEAD", "DRONE STATION W051", "BLUECORP STARTUP", "ANCIENT VILLAGE", "SUMMERS HOMESTEAD", "FEN BOG PORT", "PHOTOVOLTAIC PARK W01", "FEN BOG TESTING ZONE", "RECYCLING FACILITY" };
string[] OBJECTIVESArray = { "Neutralise all hostiles.", "(Tier 1) Stay undetected.", "Disable all S.A.M.S.", "Destroy all enemy vehicles.", "Eliminate the enemy HVTs.", "Interrogate enemy HVTs.", "Disable or destroy enemy mortars, turrets, helicopters and generators.",
                        "Capture an enemy HVT.", "Obtain any laptops and deliver them to Erewhon.", "Perform this mission during the night.", "Perform this mission during the day.", "Rescue captives.", "Destroy enemy antennas.", "Add tracker to enemy containers.",
                        "Steal enemy vehicles.", "Return the information in the biometric rooms to Erewhon." };
string[] SKULLSArray = { "You can only heal after you melee an enemy.", "HUD does not display on the screen.", "Ghost trades his Night Vision for Optical Camo", "Auto aim features disabled for all weapons.",
                    "The map is disabled.", "(Tier 3) Players cannot pick up or use enemy weapons.", "Headshots only.", "Dying in co-op resets the mission.", "(Tier 2) Sniper rifles only.", "(Tier 1) No suppressors are allowed.", "No class items are allowed.", "No class techniques are allowed.",
                    "No drones are allowed.", "No voice communication is allowed.", "Optical Camo has been disabled.", "No Primary Weapons.", "No Secondary Weapons.", "No Equipment Item Wheel." };
string[] GEARSCOREArray = { "On", "Off" };
string[] WEAPONTYPEArray = { "ASSAULT RIFLES", "LIGHT MACHINE GUNS", "SHOTGUNS", "SUBMACHINE GUNS", "SNIPER RIFLES", "DESIGNATED MARKSMAN RIFLES", "GRENADE LAUNCHERS", "None" };
string[] ITEMWHEELArray = { "AGILITY RATION", "BINOCULARS", "BREACH TORCH", "C4 CHARGE MK.1", "C4 CHARGE MK.2", "DEXTERITY RATION ADVANCED", "DEXTERITY RATION BASIC", "DEXTERITY RATION EXTREME", "DIV. LURE", "EMP GRENADE MK.1", "EMP GRENADE MK.2", "EMP GRENADE MK.3",
                            "ENDURANCE RATION ADVANCED", "ENDURANCE BASIC", "FITNESS RATION ADVANCED", "FITNESS RATION BASIC", "FITNESS RATION EXTREME", "FLASHBANG", "FRAG GRENADE MK.1", "FRAG GRENADE MK.2", "GAS FILTER", "INTEL GRENADE", "MINE MK.1", "MINE MK.2",
                            "PROJECTION RATION", "PROTECTIVE RATION ADVANCED", "PROTECTIVE RATION BASIC", "PROTECTIVE RATION EXTREME", "RECOVERY RATION ADVANCED", "RECOVERY RATION BASIC", "RESILIENCE RATION ADVANCED", "RESILIENCE RATION BASIC", "ROCKET LAUNCHER",
                            "RUSSIAN RATION", "SYNC SHOT DRONE", "SYRINGE MK.1", "SYRINGE MK.2", "WATER CANTEEN", "VIGOR RATION", "VISUAL ACUITY RATION ADVANCED", "VISUAL ACUITY RATION BASIC", "VISUAL ACUITY RATION EXTREME" };
string[] ASSAULTRIFLESArray = { "AK12", "AK47", "AK47 Assault", "AK74", "AK74 Assault", "AUG", "AUG Assault", "805 BREN", "SC-20K", "G36C", "416", "416 Assault Special", "416 Shorty", "A2", "A2 Shorty", "KOBLIN", "M4A1", "M4A1 Assault", "M4A1 Tactical",
                                "Silver Stake", "Silver Stake Tactical", "MK17", "MK17 Shorty", "516", "516 Shorty", "553", "TAVOR", "TAVOR Assault", "VHSD2", "MK17 Assault", "AR-18", "Resistance ASR", "ARX200", "416 Shorty | Brown", "M4A1 Assault | Valor",
                                "MK17 Assault | Wolves", "SC-40K", "SC-40K | Brown", "MK17 Shorty | Gargoyle", "VHSD2 | Sentinel", "M4A1 CQC", "FAL", "G2", "416 Assault | Custom", "516 | Survival", "AK74 Assault | Survival", "4-AC", "4-AC | Brown", "L85-C", "MDR",
                                "VHSD2 | Survival", "TAVOR | Custom", "MK18", "ACR", "AC-AR", "ACR Assault", "Resistance ASR Shorty", "SR-3M", "SR-3M Tactical", "ACR | Brown", "AK47 Shorty", "K1A" };
string[] HANDGUNSArray = { "Desert Eagle", "F40", "5.7 USG", "M1911", "M1911 | Promise", "M9", "Gibson's M9", "P227", "P227 | Survival", "P320", "P45T", "PX4", "USP Tactical", "SHARP THUNDER", "C-SFP", "Stainless Extended .45", "Maxim 9", "Maxim 9 | Echelon",
                           "Maxim 9 | Custom", "MK 23", "MK 23 | Echelon", "SC IS HDG", "C-SFP | BAAL", "Desert Eagle | Custom", "P320 | Sentinel", "Bailiff 410", "Desert Eagle | Survival" };
string[] LIGHTMACHINEGUNSArray = { "MG121", "L86A1", "CTMMG", "MK48", "MK48 Compact", "6P41", "CTMMG | Baal", "STONER", "STONER Compact", "T95" };
string[] SHOTGUNSArray = { "BOSG12", "M4", "M4 Assault", "M4 Shorty", "KSG12", "Silverback's KSG12", "SASG12", "RU12SG", "RU12SG Assault", "SPAS-12", "ACS12", "ACS12 | Custom", "M590A1", "M590A1 | Survival" };
string[] SUBMACHINEGUNSArray = { "MP5", "MP7", "MPX", "MPX Tactical", "P90", "Flycatcher's P90", "Bullpup PDR", "SCORPION EVO3", "SCORPION EVO3 CQC", "SCORPION EVO3 Tactical", "UMP", "Vector", "Vector Shorty", "Vector | Quantum", "SN-9mm", "MP5 | SHD", "UZI 9mm",
                                 "Echelon SMG", "Echelon SMG | Custom", "UMP CQC", "Honey Badger", "Honey Badger | Brown" };
string[] SNIPERRIFLESArray = { "TAC50", "HTI", "L115A3", "M82", "Zastava M93", "Recon-A1", "Scorpio", "HTI | Survival", "TAC50 | Brown", "Paladin 9 SNR", "M82 | Cerberus", "Paladin 9 SNR | Survival", "HTI | Brown", "M82 | Survival", "TAC50 | Wolves", "MSR", "SR-1",
                               "VSK-50" };
string[] DESIGNATEDMARKSMANRIFLESArray = { "AK74 Scout", "G36C Scout", "416 Scout", "553 Scout", "TAVOR Scout", "M4A1 Scout", "MK17 Scout", "M4A1 SCT | Custom", "553 Scout | Sentinel", "AUG Scout", "SR-3M Scout", "SR-3M Scout | Survival", "Scorpio Scout | Quiet",
                                           "Scorpio Scout", "SVD-63", "FRF2", "G28", "G28 | Wilderness", "G28 Scout | Wolves", "MK14", "MK14 Assault | Brown", "MK14 | Termination", "G28 Scout", "MK14 Assault", "SVD-63 | Patchwork", "OTS-O3", "M110" };

string[] GRENADELAUNCHERSArray = { "MGL", "MGL | Terminator", "MGL | Quantum" };
string[] TACTICSArray = { "ASSAULT", "SHARPSHOOTER", "PANTHER", "FIELD MEDIC", "ENGINEER", "ECHELON", "PATHFINDER" };
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
        int type = random.Next(0, 12);
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
        else if (type == 11)
        {
            int OPERATIONFIRSTSTRIKEMISSIONS = random.Next(0, 4);
            Console.WriteLine(OPERATIONFIRSTSTRIKEMISSIONSArray[OPERATIONFIRSTSTRIKEMISSIONS]);
        }
        int OBJECTIVES = random.Next(0, 16);
        Console.WriteLine(OBJECTIVESArray[OBJECTIVES]);
        OBJECTIVES = random.Next(0, 16);
        Console.WriteLine(OBJECTIVESArray[OBJECTIVES]);
        int SKULLS = random.Next(0, 18);
        Console.WriteLine(SKULLSArray[SKULLS]);
        int GEARSCORE = random.Next(0, 2);
        Console.WriteLine("Gear Score: " + GEARSCOREArray[GEARSCORE]);
        int WEAPONTYPE = random.Next(0, 8);
        Console.WriteLine("Primary Weapon Type: " + WEAPONTYPEArray[WEAPONTYPE]);
        if (WEAPONTYPE == 0)
        {
            int ASSAULTRIFLES = random.Next(0, 62);
            Console.WriteLine("Primary Weapon: " + ASSAULTRIFLESArray[ASSAULTRIFLES]);
        }
        if (WEAPONTYPE == 1)
        {
            int LIGHTMACHINEGUNS = random.Next(0, 10);
            Console.WriteLine("Primary Weapon: " + LIGHTMACHINEGUNSArray[LIGHTMACHINEGUNS]);
        }
        if (WEAPONTYPE == 2)
        {
            int SHOTGUNS = random.Next(0, 14);
            Console.WriteLine("Primary Weapon: " + SHOTGUNSArray[SHOTGUNS]);
        }
        if (WEAPONTYPE == 3)
        {
            int SUBMACHINEGUNS = random.Next(0, 22);
            Console.WriteLine("Primary Weapon: " + SUBMACHINEGUNSArray[SUBMACHINEGUNS]);
        }
        if (WEAPONTYPE == 4)
        {
            int SNIPERRIFLES = random.Next(0, 18);
            Console.WriteLine("Primary Weapon: " + SNIPERRIFLESArray[SNIPERRIFLES]);
        }
        if (WEAPONTYPE == 5)
        {
            int DESIGNATEDMARKSMANRIFLES = random.Next(0, 27);
            Console.WriteLine("Primary Weapon: " + DESIGNATEDMARKSMANRIFLESArray[DESIGNATEDMARKSMANRIFLES]);
        }
        if (WEAPONTYPE == 6)
        {
            int GRENADELAUNCHERS = random.Next(0, 3);
            Console.WriteLine("Primary Weapon: " + GRENADELAUNCHERSArray[GRENADELAUNCHERS]);
        }
        int HANDGUNS = random.Next(0, 27);
        Console.WriteLine("Secondary Weapon: " + HANDGUNSArray[HANDGUNS]);
        for (int x = 0; x < 6; x++)
        {
            int ITEMWHEEL = random.Next(0, 42);
            int slot = x + 1;
            Console.WriteLine("Item Wheel Slot " + slot + ": " + ITEMWHEELArray[ITEMWHEEL]);
        }
        int TACTICS = random.Next(0, 7);
        Console.WriteLine("TACTICS: " + TACTICSArray[TACTICS]);
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
            int SMUGGLERCOVES = random.Next(0, 16);
            Console.WriteLine(SMUGGLERCOVESArray[SMUGGLERCOVES]);
        }
        if (province == 6)
        {
            int SINKINGCOUNTRY = random.Next(0, 21);
            Console.WriteLine(SINKINGCOUNTRYArray[SINKINGCOUNTRY]);
        }
        if (province == 7)
        {
            int WILDCOAST = random.Next(0, 21);
            Console.WriteLine(WILDCOASTArray[WILDCOAST]);
        }
        if (province == 8)
        {
            int MOUNTHODGSON = random.Next(0, 5);
            Console.WriteLine(MOUNTHODGSONArray[MOUNTHODGSON]);
        }
        if (province == 9)
        {
            int FENBOG = random.Next(0, 19);
            Console.WriteLine(FENBOGArray[FENBOG]);
        }
        int OBJECTIVES = random.Next(0, 16);
        Console.WriteLine(OBJECTIVESArray[OBJECTIVES]);
        OBJECTIVES = random.Next(0, 16);
        Console.WriteLine(OBJECTIVESArray[OBJECTIVES]);
        int SKULLS = random.Next(0, 18);
        Console.WriteLine(SKULLSArray[SKULLS]);
        int GEARSCORE = random.Next(0, 2);
        Console.WriteLine("Gear Score: " + GEARSCOREArray[GEARSCORE]);
        int WEAPONTYPE = random.Next(0, 8);
        Console.WriteLine("Primary Weapon Type: " + WEAPONTYPEArray[WEAPONTYPE]);
        if (WEAPONTYPE == 0)
        {
            int ASSAULTRIFLES = random.Next(0, 62);
            Console.WriteLine("Primary Weapon: " + ASSAULTRIFLESArray[ASSAULTRIFLES]);
        }
        if (WEAPONTYPE == 1)
        {
            int LIGHTMACHINEGUNS = random.Next(0, 10);
            Console.WriteLine("Primary Weapon: " + LIGHTMACHINEGUNSArray[LIGHTMACHINEGUNS]);
        }
        if (WEAPONTYPE == 2)
        {
            int SHOTGUNS = random.Next(0, 14);
            Console.WriteLine("Primary Weapon: " + SHOTGUNSArray[SHOTGUNS]);
        }
        if (WEAPONTYPE == 3)
        {
            int SUBMACHINEGUNS = random.Next(0, 22);
            Console.WriteLine("Primary Weapon: " + SUBMACHINEGUNSArray[SUBMACHINEGUNS]);
        }
        if (WEAPONTYPE == 4)
        {
            int SNIPERRIFLES = random.Next(0, 18);
            Console.WriteLine("Primary Weapon: " + SNIPERRIFLESArray[SNIPERRIFLES]);
        }
        int HANDGUNS = random.Next(0, 27);
        Console.WriteLine("Secondary Weapon: " + HANDGUNSArray[HANDGUNS]);
        for (int x = 0; x < 6; x++)
        {
            int ITEMWHEEL = random.Next(0, 42);
            int slot = x + 1;
            Console.WriteLine("Item Wheel Slot " + slot + ": " + ITEMWHEELArray[ITEMWHEEL]);
        }
        int TACTICS = random.Next(0, 7);
        Console.WriteLine("TACTICS: " + TACTICSArray[TACTICS]);
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
