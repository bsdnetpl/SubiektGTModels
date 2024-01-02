using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlSzablonUmowyCp
{
    public int SucpId { get; set; }

    public string SucpNazwa { get; set; } = null!;

    public byte[] SucpTekst { get; set; } = null!;
}
