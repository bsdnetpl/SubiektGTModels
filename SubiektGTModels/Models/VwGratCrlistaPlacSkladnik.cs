using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSkladnik
{
    public int IdSkladnika { get; set; }

    public string Nazwa { get; set; } = null!;

    public int Typ { get; set; }

    public int Rodzaj { get; set; }

    public bool Opodatkowany { get; set; }

    public int PlatnyPrzez { get; set; }

    public bool Aktywny { get; set; }
}
