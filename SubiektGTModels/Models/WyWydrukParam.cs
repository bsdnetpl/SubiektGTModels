using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyWydrukParam
{
    public int WpId { get; set; }

    public byte WpEksportNazwaTyp { get; set; }

    public string? WpEksportNumerZnakiNiedozwoloneNa { get; set; }

    public string? WpEksportDowolnaNazwa { get; set; }

    public int? WpParamEwidId { get; set; }

    public byte WpEksportPlikNazwaTyp { get; set; }

    public string? WpEksportPlikNumerZnakiNiedozwoloneNa { get; set; }

    public string? WpEksportPlikDowolnaNazwa { get; set; }

    public bool WpPodpisujDokumentyBiblioteki { get; set; }

    public virtual ParEwid? WpParamEwid { get; set; }
}
