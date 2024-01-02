using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SfDefinicja
{
    public int SfdId { get; set; }

    public int? SfdIdRokuObrotowego { get; set; }

    public int SfdKolumna { get; set; }

    public string SfdFunkcja { get; set; } = null!;

    public string SfdKonto { get; set; } = null!;

    public bool SfdKorygujaco { get; set; }

    public int SfdIdPola { get; set; }

    public virtual PdRokObrotowy? SfdIdRokuObrotowegoNavigation { get; set; }
}
