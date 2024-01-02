using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGmina
{
    public int GmId { get; set; }

    public string GmNazwa { get; set; } = null!;

    public int GmTyp { get; set; }

    public string GmKodGus { get; set; } = null!;

    public string GmPowiat { get; set; } = null!;

    public string? GmGmina { get; set; }

    public bool GmAktualna { get; set; }
}
