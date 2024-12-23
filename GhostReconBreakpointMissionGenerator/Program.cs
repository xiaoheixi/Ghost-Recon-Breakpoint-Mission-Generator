﻿Random random = new Random();
string[] typeArray = { "EPISODE 1", "EPISODE 2", "EPISODE 3", "HARUHI ITO", "A LONG ROAD TO VICTORY", "MADS SCHULZ", "STAYING SAFE", "OPERATION AMBER SKY", "RESISTANCE",
                       "OPERATION MOTHERLAND" };
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
string[] provinceArray = { "SECTOR 03", "SECTOR 01", "SECTOR 02", "CAPE NORTH", "DRIFTWOOD ISLETS", "SMUGGLER COVES", "SINKING COUNTRY", "WILD COAST", "MOUNT HODGSON", "FEN BOG",
                           "NEW ARGYLL", "SILENT MOUNTAIN", "WHALER'S BAY", "INFINITY", "LAKE COUNTRY", "GOOD HOPE MOUNTAIN", "CHANNELS", "NEW STIRLING", "RESTRICTED AREA 01",
                           "SEAL ISLANDS", "LIBERTY", "EGG ISLAND", "WINDY ISLANDS" };
string[] SECTOR03Array = { "PROTOTYPE WORKSHOP", "LAVADUCT", "LAVA SHIELD", "SCANDIUM MINE", "NO MAN'S LAND", "RED PHOENIX OUTPOST" };
string[] SECTOR01Array = { "CHEMICAL PIPELINE", "CHEMICAL REFINERY", "GOLEM ISLAND HELIPORT", "GOLEM ISLAND SATELLITE DISH", "ANCIENT HARBOR" };
string[] SECTOR02Array = { "CAMP SALAMANDER", "CAMP PHOENIX", "FORGOTTEN SANCTUARY", "GOLEM ISLAND TESTING ZONE", "MISSILE SITE RUINS", "QUANTUM COMPUTER CENTER" };
string[] CAPENORTHArray = { "A.I. EXPERIMENTAL CENTER", "DRIFTWOOD ISLETS TESTING ZONE", "CAMPUS RELAY STATION", "CAMPUS DATA FARM", "UNDERWATER CABLE STATION", "CONSTRUCTION SITE", "SKELL FOUNDATION CAMPUS", "DARKWOOD ISLAND PORT" };
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
        int type = random.Next(0, 9);
        Console.WriteLine(typeArray[type]);
        if (type == 0)
        {
            int EPISODE1 = random.Next(0, 11);
            Console.WriteLine(EPISODE1Array[EPISODE1]);
            if (EPISODE1 == 0)
            {
                int OPERATIONGREENSTONE = random.Next(0, 1);
                Console.WriteLine(OPERATIONGREENSTONEArray[OPERATIONGREENSTONE]);
            }
            if (EPISODE1 == 1)
            {
                int LTCCOLEDWALKER = random.Next(0, 2);
                Console.WriteLine(LTCCOLEDWALKERArray[LTCCOLEDWALKER]);
            }
            if (EPISODE1 == 2)
            {
                int JACESKELL = random.Next(0, 2);
                Console.WriteLine(JACESKELLArray[JACESKELL]);
            }
            if (EPISODE1 == 4)
            {
                int AUROAARCHIPELAGO = random.Next(0, 32);
                Console.WriteLine(AUROAARCHIPELAGOArray[AUROAARCHIPELAGO]);
            }
            if (EPISODE1 == 7)
            {
                int PAULAMADERA = random.Next(0, 4);
                Console.WriteLine(PAULAMADERAArray[PAULAMADERA]);
            }
            if (EPISODE1 == 8)
            {
                int CHRISTINACROMWELL = random.Next(0, 4);
                Console.WriteLine(CHRISTINACROMWELLArray[CHRISTINACROMWELL]);
            }
            if (EPISODE1 == 10)
            {
                int CARLCHISUM = random.Next(0, 4);
                Console.WriteLine(CARLCHISUMArray[CARLCHISUM]);
            }
        }
        else if (type == 1)
        {
            int EPISODE2 = random.Next(0, 7);
            Console.WriteLine(EPISODE2Array[EPISODE2]);
        }
        else if (type == 2)
        {
            int EPISODE3 = random.Next(0, 9);
            Console.WriteLine(EPISODE3Array[EPISODE3]);
        }
        else if (type == 3)
        {
            int HARUHIITO = random.Next(0, 5);
            Console.WriteLine(HARUHIITOArray[HARUHIITO]);
        }
        else if (type == 4)
        {
            int ALONGROADTOVICTORY = random.Next(1, 6);
            Console.WriteLine("Mission " + ALONGROADTOVICTORY);
        }
        else if (type == 5)
        {
            int MADSSCHULZ = random.Next(0, 5);
            Console.WriteLine(MADSSCHULZArray[MADSSCHULZ]);
        }
        else if (type == 6)
        {
            int STAYINGSAFE = random.Next(1, 6);
            Console.WriteLine("Mission " + STAYINGSAFE);
        }
        else if (type == 7)
        {
            int OPERATIONAMBERSKY = random.Next(0, 8);
            Console.WriteLine(OPERATIONAMBERSKYArray[OPERATIONAMBERSKY]);
        }
        else if (type == 8)
        {
            int RESISTANCE = random.Next(0, 8);
            Console.WriteLine(RESISTANCEArray[RESISTANCE]);
        }
        else if (type == 9)
        {

        }
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
        int province = random.Next(0, 22);
        Console.WriteLine(provinceArray[province]);
        if(province == 0)
        {
            int SECTOR03 = random.Next(0, 5);
            Console.WriteLine(SECTOR03Array[SECTOR03]);
        }
        if(province == 1)
        {
            int SECTOR01 = random.Next(0, 4);
            Console.WriteLine(SECTOR01Array[SECTOR01]);
        }
        if(province == 2)
        {
            int SECTOR02 = random.Next(0, 5);
            Console.WriteLine(SECTOR02Array[SECTOR02]);
        }
        if (province == 3)
        {
            int CAPENORTH = random.Next(0, 7);
            Console.WriteLine(CAPENORTHArray[CAPENORTH]);
        }
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
