using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PkPlanKont
{
    public int KoId { get; set; }

    public int KoIdRokuObrotowego { get; set; }

    public string KoNr { get; set; } = null!;

    public string KoNazwa { get; set; } = null!;

    public string KoNazwaObca1 { get; set; } = null!;

    public string KoNazwaObca2 { get; set; } = null!;

    public string KoOpis { get; set; } = null!;

    public int KoPoziom { get; set; }

    public bool KoJestLisciem { get; set; }

    public bool KoBilansowe { get; set; }

    public bool KoWynikowe { get; set; }

    public bool KoPozabilansowe { get; set; }

    public bool KoRozrachunkowe { get; set; }

    public bool KoPowiazane { get; set; }

    public int? KoIdKartoteki { get; set; }

    public bool KoKartotekowe { get; set; }

    public int? KoIdElementuKartoteki { get; set; }

    public int? KoIdStawkiVat { get; set; }

    public bool KoWalutowe { get; set; }

    public string? KoWaluta { get; set; }

    public bool KoPodlegaWycenie { get; set; }

    public int? KoIdKartoteki01 { get; set; }

    public int? KoIdKartoteki02 { get; set; }

    public int? KoIdKartoteki03 { get; set; }

    public int? KoIdKartoteki04 { get; set; }

    public int? KoIdKartoteki05 { get; set; }

    public int? KoRozrachObjId { get; set; }

    public int? KoRozrachObjTyp { get; set; }

    public int? KoIdBiezacejKartoteki { get; set; }

    public int? KoIdKategorii { get; set; }

    public bool? KoKategoriaWymagana { get; set; }

    public string? KoSyntetyka { get; set; }

    public virtual PkKartoteka? KoIdBiezacejKartotekiNavigation { get; set; }

    public virtual PkKartoteka? KoIdKartoteki01Navigation { get; set; }

    public virtual PkKartoteka? KoIdKartoteki02Navigation { get; set; }

    public virtual PkKartoteka? KoIdKartoteki03Navigation { get; set; }

    public virtual PkKartoteka? KoIdKartoteki04Navigation { get; set; }

    public virtual PkKartoteka? KoIdKartoteki05Navigation { get; set; }

    public virtual PkKartoteka? KoIdKartotekiNavigation { get; set; }

    public virtual PdRokObrotowy KoIdRokuObrotowegoNavigation { get; set; } = null!;

    public virtual SlStawkaVat? KoIdStawkiVatNavigation { get; set; }

    public virtual PkKartoteka? KoRozrachObjTypNavigation { get; set; }
}
