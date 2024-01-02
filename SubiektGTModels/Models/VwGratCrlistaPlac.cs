using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlac
{
    public int IdLp { get; set; }

    public string Tytul { get; set; } = null!;

    public string Numer { get; set; } = null!;

    public DateTime Miesiac { get; set; }

    public DateTime DataWyplaty { get; set; }
}
