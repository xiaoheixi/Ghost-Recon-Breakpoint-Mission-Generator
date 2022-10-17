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
string[] EPISODE2Array = { "OPERATION CHECKMATE", "THE STRATEGIST", "SAM FISHER", "STEPHANIE BURGESS", "HOLLIE MACKENZIE", "KAREL SEKULIC", "GENERAL PAXTON", "WILLAM VAN DYKE" };
string[] EPISODE3Array = { "MANTICORE", "BASILISK", "ORACLE", "HARPY", "SPHINX", "CYCLOPS", "ATLAS", "GRIFFIN", "MEDUSA", "KRAKEN" };
string[] HARUHIITOArray = { "THE GUN RUNNER", "CROSS THE LINE", "WHISTLEBLOWER", "RALLYING CRY", "HOSTILE TAKEOVER", "LOSS OF INNOCENCE" };
string[] MADSSCHULZArray = { "BREAK THE RULES", "PROOF OF LIFE", "A DEADLY TRAP", "SCIENCE WITHOUT CONSCIENCE", "PATIENT ZERO", "REDEEMING REMEDY" };
string[] OPERATIONAMBERSKYArray = { "THE ROOT OF ALL EVIL", "DESPERATE MEASURES", "DRASTIC REMEDY", "CHASING AN APOCALYPSE", "THE DEVIL WE WANT",
                                    "FIGHT FIRE WITH FIRE", "BREAKING THE WHEEL", "SLUMBERING BEAST", "HUMAN TRIAL(S)" };
string[] RESISTANCEArray = { "COUNTERATTACK", "FRIENDS IN NEED", "HIT THE ROAD", "HEARTS AND SOULS", "LICENSE EXPIRED", "BRAIN DRAIN", "A SAFER PLACE",
                             "SILENT RECOVERY", "TRAFFIC CONTROL" };
Console.WriteLine("Hello, Ghost!");
Console.WriteLine("Welcome to Breakpoint Mission Generator created by Justin Zhao");
Console.WriteLine("Press 1 to randomly generator your mission.");
Console.WriteLine("Press 0 to exit");
string input = Console.ReadLine();
while (Convert.ToInt32(input) != 0)
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
        if(EPISODE1 == 1)
        {
            int LTCCOLEDWALKER = random.Next(0, 2);
            Console.WriteLine(LTCCOLEDWALKERArray[LTCCOLEDWALKER]);
        }
        if(EPISODE1 == 2)
        {
            int JACESKELL = random.Next(0, 2);
            Console.WriteLine(JACESKELLArray[JACESKELL]);
        }
        if(EPISODE1 == 4)
        {
            int AUROAARCHIPELAGO = random.Next(0, 32);
            Console.WriteLine(AUROAARCHIPELAGOArray[AUROAARCHIPELAGO]);
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
    else
    {
        Console.WriteLine("Please contact Justin, there has been a bug in the program.");
    }
    Console.WriteLine("Enter 1 if you would like a different mission.");
    Console.WriteLine("Enter 0 to exit.");
    input = Console.ReadLine();
    if (Convert.ToInt32(input) == 0)
    {
        continue;
    }
}
Console.WriteLine("Thanks for using the Ghost Recon Breakpoint Mission Generator created by Justin Zhao");
