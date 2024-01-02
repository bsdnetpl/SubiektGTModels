using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PkWzorzec
{
    public string KowNr { get; set; } = null!;

    public string KowNazwa { get; set; } = null!;

    public int KowPoziom { get; set; }

    public bool KowBilansowe { get; set; }

    public bool KowWynikowe { get; set; }

    public bool KowPozabilansowe { get; set; }

    public bool KowRozrachunkowe { get; set; }

    public bool KowPowiazane { get; set; }

    public int? KowIdKartoteki { get; set; }

    public int? KowIdStawkiVat { get; set; }

    public bool KowDlaSpCywilnej { get; set; }

    public bool KowDlaSpHandlowej { get; set; }

    public bool KowDlaDzHandlowej { get; set; }

    public bool KowDlaDzUslugowej { get; set; }

    public bool KowDlaDzProdukcyjnej { get; set; }

    public bool KowDlaJednoosobowej { get; set; }

    public int? KowIdKartoteki01 { get; set; }

    public int? KowIdKartoteki02 { get; set; }

    public int? KowIdKartoteki03 { get; set; }

    public int? KowIdKartoteki04 { get; set; }

    public int? KowIdKartoteki05 { get; set; }

    public virtual PkKartoteka? KowIdKartotekiNavigation { get; set; }

    public virtual SlStawkaVat? KowIdStawkiVatNavigation { get; set; }
}
