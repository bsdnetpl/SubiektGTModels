using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSzczegolowyOdcinekSkladniki
{
    public int IdRecordu { get; set; }

    public int IdWyplaty { get; set; }

    public int IdSkladnika { get; set; }

    public string? Nazwa { get; set; }

    public decimal Wartosc { get; set; }

    public int Typ { get; set; }

    public bool Opodatkowany { get; set; }
}
