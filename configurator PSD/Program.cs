using System;
using System.Collections.Generic;

class Program
{
    // Datele de compatibilitate intre valve si seringii
    static Dictionary<string, List<string>> compatibility = new Dictionary<string, List<string>>
    {
        { "9537-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "99891-01", new List<string>{
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
} },




        { "99891-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "57252-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
} },


        { "7427-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
} },
        { "8778-01", new List<string>{
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
} },
        { "8778-02", new List<string>{
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },

        { "99892-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
} },
        { "99892-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
} },
        { "8063-01", new List<string>{
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
} },
        { "8063-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
} },
        { "58889-01", new List<string>{
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
} },
        { "99893-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
} },
        { "99893-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "7991-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "7991-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "99894-01", new List<string>{
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "99894-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "9234-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "9234-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "99895-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "99895-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "7992-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "99896-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "99896-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "9998-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "9998-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "99897-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "59943-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "59943-02", new List<string> {
  "69000-20",
  "69000-22",
  "69000-25",
  "69000-30",
  "69000-35",
  "69000-38",
  "69000-40",
  "69000-45",
  "69000-50",
  "69000-55",
  "69005-20",
  "69005-22",
  "69005-30",
  "69005-35",
  "69005-38",
  "69005-40",
  "69005-45"
}
 },
        { "7993-01", new List<string> {
  "5495-10",
  "5495-15",
  "5495-20",
  "5495-22",
  "5495-25",
  "5495-30",
  "5495-35",
  "5495-38",
  "5495-40",
  "5495-45",
  "5495-50",
  "5495-55",
  "8250-15",
  "8250-20",
  "8250-22",
  "8250-25",
  "8250-30",
  "8250-35",
  "8250-37",
  "8250-40",
  "8250-45",
  "8250-50"
}
 },
        { "211323", new List<string> {
 "There are no compatible syringes."
}
 },
        { "10114283", new List<string> {
  "There are no compatible syringes."
}
 }

        // Adaugati aici restul valvei si seringii compatibile
    };

    // Datele pentru accesorii electrice
    static Dictionary<string, string> electricalAccessories = new Dictionary<string, string>
    {
        { "64316-05", "PSD/4/6 & MVP/4 Starter Kit" },
        { "57025-01", "Demo Communication Cable PSD/4" },
        { "4833-01",  "MVP 24V Universal Power Supply" },
        { "355234",   "Power Cord EU 2,5 m (Schuko)" },
        { "355235",   "Power Cable CH 2,5 m" },
        { "355236",   "Power Cable US 2,5 m" },
        { "355237",   "Power Cable UK 2,5 m" },
        { "355238",   "Power Cable China 2,5 m" }
    };

    // Datele de compatibilitate intre seringii si tubings
    static Dictionary<string, List<string>> syringeToTubing = new Dictionary<string, List<string>>
    {
         { "5495-10", new List<string> { "10106145", "10106147" } },
    { "5495-15", new List<string> { "10106145", "10106147" } },
    { "5495-20", new List<string> { "10106145", "10106147" } },
    { "5495-22", new List<string> { "10106145", "10106147" } },
    { "5495-25", new List<string> { "10106145", "10106147" } },
    { "5495-30", new List<string> { "10106145", "10106147" } },
    { "5495-35", new List<string> { "10106145", "10106147" } },
    { "5495-38", new List<string> { "10106145", "10106147" } },
    { "5495-40", new List<string> { "10106148", "10106149" } },
    { "5495-45", new List<string> { "10106148", "10106149" } },
    { "5495-50", new List<string> { "10106148", "10106149" } },
    { "5495-55", new List<string> { "10106148", "10106149" } },
    { "8250-15", new List<string> { "10106148", "10106149" } },
    { "8250-20", new List<string> { "10106148", "10106149" } },
    { "8250-22", new List<string> { "10106148", "10106149" } },
    { "8250-25", new List<string> { "10106148", "10106149" } },
    { "8250-30", new List<string> { "10106148", "10106149" } },
    { "8250-35", new List<string> { "10106148", "10106149" } },
    { "8250-37", new List<string> { "10106148", "10106149" } },
    { "8250-40", new List<string> { "10106148", "10106149" } },
    { "8250-45", new List<string> { "10106148", "10106149" } },
    { "8250-50", new List<string> { "10106148", "10106149" } },

    { "69000-20", new List<string> { "10106145", "10106147" } },
    { "69000-22", new List<string> { "10106145", "10106147" } },
    { "69000-25", new List<string> { "10106145", "10106147" } },
    { "69000-30", new List<string> { "10106145", "10106147" } },
    { "69000-35", new List<string> { "10106145", "10106147" } },
    { "69000-38", new List<string> { "10106145", "10106147" } },
    { "69000-40", new List<string> { "10106148", "10106149" } },
    { "69000-45", new List<string> { "10106148", "10106149" } },
    { "69000-50", new List<string> { "10106148", "10106149" } },
    { "69000-55", new List<string> { "10106148", "10106149" } },
    { "69005-20", new List<string> { "10106148", "10106149" } },
    { "69005-22", new List<string> { "10106148", "10106149" } },
    { "69005-30", new List<string> { "10106148", "10106149" } },
    { "69005-35", new List<string> { "10106148", "10106149" } },
    { "69005-38", new List<string> { "10106148", "10106149" } },
    { "69005-40", new List<string> { "10106148", "10106149" } },
    { "69005-45", new List<string> { "10106148", "10106149" } }
        // Adaugati aici restul seringilor si tubings compatibile
    };

    static void Main()
    {
        // Afisare informatii de start
        Console.WriteLine("P/N\t\t\tDescription");
        Console.WriteLine("54848-01\tPSD/4 SYRINGE PUMP ROHS");
        Console.WriteLine();

        while (true)
        {
            // Meniu interactiv
            Console.WriteLine("\n");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Valves");
            Console.WriteLine("2. Syringes");
            Console.WriteLine("3. Tubings");
            Console.WriteLine("4. Electrical Accessories");
            Console.WriteLine("0. Exit");
            Console.WriteLine("\n");
            Console.WriteLine("My option is:");
            string option = Console.ReadLine().Trim();
            

            switch (option)
            {
                case "1":
                    ShowValves();
                    break;
                case "2":
                    ShowSyringes();
                    break;
                case "3":
                    ShowTubings();
                    break;
                case "4":
                    ShowElectricalAccessories();
                    break;
                case "0":
                    Console.WriteLine("Exit aplication...");
                    return;
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }

    static void ShowValves()
    {
        
        Console.WriteLine("Valves:");
        // Adaugă aici restul valvei
        Console.WriteLine("9537-01    \tCTFE - TLL");
        Console.WriteLine("99891-02   \tPTFE - TLL");
        Console.WriteLine("57252-01   \tCeramic - TLL");
        Console.WriteLine("7427-01    \tPCTFE - TLL");
        Console.WriteLine("8778-01    \tHamaflon - TLL");
        Console.WriteLine("8778-02    \tHamaflon - TLL");
        Console.WriteLine("99892-01   \tPCTFE - TLL");
        Console.WriteLine("99892-02   \tPCTFE - TLL");
        Console.WriteLine("8063-01    \tHamaflon - TLL");
        Console.WriteLine("8063-02    \tHamaflon - TLL");
        Console.WriteLine("58889-01   \tCeramic - TLL");
        Console.WriteLine("99893-01   \tHamaflon - TLL");
        Console.WriteLine("99893-02   \tHamaflon - TLL");
        Console.WriteLine("7991-01    \tCeramic - TLL");
        Console.WriteLine("7991-02    \tCeramic - TLL");
        Console.WriteLine("99894-01   \tPCTFE - TLL");
        Console.WriteLine("99894-02   \tPCTFE - TLL");
        Console.WriteLine("9234-01    \tHamaflon - TLL");
        Console.WriteLine("9234-02    \tHamaflon - TLL");
        Console.WriteLine("99895-01   \tCeramic - TLL");
        Console.WriteLine("99895-02   \tCeramic - TLL");
        Console.WriteLine("7992-01    \tPCTFE - TLL");
        Console.WriteLine("99896-01   \tPEEK - TLL");
        Console.WriteLine("99896-02   \tPEEK - TLL");
        Console.WriteLine("9998-01    \tCeramic - TLL");
        Console.WriteLine("9998-02    \tCeramic - TLL");
        Console.WriteLine("99897-01   \tHamaflon - TLL");
        Console.WriteLine("59943-01   \tHamaflon - TLL");
        Console.WriteLine("59943-02   \tHamaflon - TLL");
        Console.WriteLine("7993-01    \tCeramic - TLL");
        Console.WriteLine("211323     \tPCTFE - TLL");
        Console.WriteLine("10114283   \tPEEK - TLL");
        // Adaugati aici restul valvei

        // Selectare valva
        Console.WriteLine("\n");
        Console.WriteLine("Enter the valve PN to see compatible syringes:");
        string selectedValve = Console.ReadLine().Trim();

        if (compatibility.ContainsKey(selectedValve))
        {
            ShowCompatibleSyringes(selectedValve);
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("The selected valve is not compatible.");
        }
    }

    static void ShowCompatibleSyringes(string valveCode)
    {
        Console.WriteLine("\n");
        Console.WriteLine("Compatible syringes for the selected valve:");
        foreach (var syringe in compatibility[valveCode])
        {
            Console.WriteLine(syringe);
        }

        // Selectare seringa pentru a vedea tubings compatibile
        Console.WriteLine("\n");
        Console.WriteLine("Enter the syringe PN to see compatible tubings:");
        string selectedSyringe = Console.ReadLine().Trim();

        if (syringeToTubing.ContainsKey(selectedSyringe))
        {
            ShowCompatibleTubings(selectedSyringe);
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("The selected syringe has no compatible tubings.");
        }
    }

    static void ShowCompatibleTubings(string syringeCode)
    {
        Console.WriteLine("\n");
        Console.WriteLine("Compatible tubings for the selected syringe:");
        foreach (var tubing in syringeToTubing[syringeCode])
        {
            Console.WriteLine(tubing);
        }
    }

    static void ShowSyringes()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Syringes:");
        Console.WriteLine("5495-10   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-15   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-20   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-22   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-25   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-30   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-35   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-38   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-40   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-45   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-50   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("5495-55   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-15   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-20   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-22   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-25   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-30   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-35   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-37   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-40   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-45   \tPTFE Luer Lock (TLL)");
        Console.WriteLine("8250-50   \tPTFE Luer Lock (TLL)");

        Console.WriteLine("\nBubble Free Prime™ (BFP, 5/16\"-28):");
        Console.WriteLine("69000-20   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-22   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-25   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-30   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-35   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-38   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-40   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-45   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-50   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69000-55   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69005-20   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69005-22   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69005-30   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69005-35   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69005-38   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69005-40   \tBubble Free Prime™ (BFP, 5/16\"-28)");
        Console.WriteLine("69005-45   \tBubble Free Prime™ (BFP, 5/16\"-28)");

        // Adaugati aici restul seringii

        // Selectare seringa pentru a vedea tubings compatibile
        Console.WriteLine("\n");
        Console.WriteLine("Enter the syringe code to see compatible tubings:");
        string selectedSyringe = Console.ReadLine().Trim();

        if (syringeToTubing.ContainsKey(selectedSyringe))
        {
            ShowCompatibleTubings(selectedSyringe);
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("The selected syringe has no compatible tubings.");
            Console.WriteLine("\n");
        }
    }

    static void ShowTubings()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Tubings:");
        Console.WriteLine("10106145   \t12");
        Console.WriteLine("10106147   \t18");
        Console.WriteLine("10106148   \t12/18");
        Console.WriteLine("10106149   \t25");
        // Adaugati aici restul tubings
    }

    static void ShowElectricalAccessories()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Electrical Accessories:");
        foreach (var accessory in electricalAccessories)
        {
            Console.WriteLine($"{accessory.Key}\t{accessory.Value}");
        }
    }
}
