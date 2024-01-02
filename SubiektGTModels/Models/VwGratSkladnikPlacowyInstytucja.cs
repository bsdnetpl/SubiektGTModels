using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratSkladnikPlacowyInstytucja
{
    public int InstytucjaId { get; set; }

    public string InstytucjaSymbol { get; set; } = null!;

    public int InstytucjaRodzaj { get; set; }

    public string InstytucjaWww { get; set; } = null!;

    public string InstytucjaEmail { get; set; } = null!;

    public string InstytucjaNazwa { get; set; } = null!;

    public string InstytucjaNazwapelna { get; set; } = null!;

    public string InstytucjaTelefon { get; set; } = null!;

    public string InstytucjaFaks { get; set; } = null!;

    public string InstytucjaAdres { get; set; } = null!;

    public string InstytucjaKod { get; set; } = null!;

    public string InstytucjaMiejscowosc { get; set; } = null!;

    public string InstytucjaGmina { get; set; } = null!;

    public string InstytucjaPowiat { get; set; } = null!;

    public string InstytucjaNip { get; set; } = null!;
}
