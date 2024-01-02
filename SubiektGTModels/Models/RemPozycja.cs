using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RemPozycja
{
    public int RpId { get; set; }

    public int RpIdRemanentu { get; set; }

    public int RpTypZrodla { get; set; }

    public int? RpIdZrodla { get; set; }

    public string RpKod { get; set; } = null!;

    public string RpNazwa { get; set; } = null!;

    public string RpJm { get; set; } = null!;

    public decimal RpIlosc { get; set; }

    public decimal RpCena { get; set; }

    public decimal RpWartosc { get; set; }

    public string RpNrKorektyKup { get; set; } = null!;

    public int? RpIdKorektyKup { get; set; }

    public virtual KprKsiega? RpIdKorektyKupNavigation { get; set; }

    public virtual RemEwid RpIdRemanentuNavigation { get; set; } = null!;
}
