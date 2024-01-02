using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SfDefinicjaWzorzec
{
    public int SfdwId { get; set; }

    public int SfdwKolumna { get; set; }

    public string SfdwFunkcja { get; set; } = null!;

    public string SfdwKonto { get; set; } = null!;

    public bool SfdwKorygujaco { get; set; }

    public int SfdwIdPola { get; set; }

    public virtual SfPole SfdwIdPolaNavigation { get; set; } = null!;
}
