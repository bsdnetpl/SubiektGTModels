using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NavParametry
{
    public int NvpId { get; set; }

    public bool NvpLogowanieLicencji { get; set; }

    public bool NvpDymekDodaj { get; set; }

    public bool NvpDymekWczytaj { get; set; }

    public bool NvpDymekUsun { get; set; }

    public bool NvpDymekZapisz { get; set; }

    public bool NvpDymekDrukuj { get; set; }

    public byte[]? NvpKolejnoscWzw { get; set; }

    public bool NvpProfilowanieKlientowStylGt { get; set; }

    public bool NvpProfilowanieSlownikowTylkoLista { get; set; }
}
