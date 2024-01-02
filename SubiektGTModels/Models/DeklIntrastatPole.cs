using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklIntrastatPole
{
    public int DipId { get; set; }

    public int DipIdDeklaracji { get; set; }

    public int DipNrPozycji { get; set; }

    public string? DipOpisTowaru { get; set; }

    public string? DipKodKrajuWysPrzez { get; set; }

    public string? DipKodWarunkowDostawy { get; set; }

    public int? DipKodRodzajuTransakcji { get; set; }

    public string? DipKodTowaru { get; set; }

    public int? DipKodRodzajuTransportu { get; set; }

    public string? DipKodKrajuPochodzenia { get; set; }

    public decimal? DipMasaNetto { get; set; }

    public decimal? DipIloscWuzupJm { get; set; }

    public decimal? DipWartoscFakturowaPln { get; set; }

    public decimal? DipWartoscStatystycznaPln { get; set; }

    public string? DipNrIdentyfikacyjnyVatKh { get; set; }

    public virtual DeklEwid DipIdDeklaracjiNavigation { get; set; } = null!;
}
