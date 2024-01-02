using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PkKartotekaPozycja
{
    public int KwpId { get; set; }

    public int KwpIdKartoteki { get; set; }

    public string KwpNazwa { get; set; } = null!;

    public string KwpNrAnalityki { get; set; } = null!;

    public virtual PkKartoteka KwpIdKartotekiNavigation { get; set; } = null!;
}
