using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratZfss
{
    public int Zfssid { get; set; }

    public int Rok { get; set; }

    public int Typ { get; set; }

    public DateTime Data { get; set; }

    public decimal Kwota { get; set; }

    public string Opis { get; set; } = null!;

    public string? Odbiorca { get; set; }
}
