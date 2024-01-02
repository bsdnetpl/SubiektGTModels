using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlSzablonUmowyOprace
{
    public int SupId { get; set; }

    public string SupNazwa { get; set; } = null!;

    public byte[] SupTekst { get; set; } = null!;

    public int SupRodzaj { get; set; }
}
