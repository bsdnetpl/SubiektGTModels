using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwRozszerzeniaSferyczne
{
    public int Sf2ksId { get; set; }

    public string Sf2ksNazwa { get; set; } = null!;

    public string Sf2ksWersja { get; set; } = null!;

    public string Sf2ksProducentNazwa { get; set; } = null!;

    public string Sf2ksProducentWww { get; set; } = null!;

    public string Sf2ksProducentEmail { get; set; } = null!;

    public int? Sf2ksPliki { get; set; }
}
