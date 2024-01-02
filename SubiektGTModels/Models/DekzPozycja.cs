using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DekzPozycja
{
    public int DzpId { get; set; }

    public int DzpIdDeklaracji { get; set; }

    public int DzpLp { get; set; }

    public int DzpNrPola { get; set; }

    public string DzpWartosc { get; set; } = null!;
}
