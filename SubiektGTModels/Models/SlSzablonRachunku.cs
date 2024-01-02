using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlSzablonRachunku
{
    public int SrId { get; set; }

    public string SrNazwa { get; set; } = null!;

    public byte[] SrTekst { get; set; } = null!;
}
