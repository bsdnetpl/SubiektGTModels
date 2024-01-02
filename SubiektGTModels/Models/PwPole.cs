using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PwPole
{
    public int PwpId { get; set; }

    public int PwpTypObiektu { get; set; }

    public string PwpPole { get; set; } = null!;

    public int PwpTyp { get; set; }

    public int PwpFormat { get; set; }

    public string PwpNazwa { get; set; } = null!;

    public int PwpRodzajSlownika { get; set; }

    public bool PwpWymagane { get; set; }

    public int? PwpDefData { get; set; }

    public int? PwpDefLiczba { get; set; }

    public string? PwpDefTekst { get; set; }

    public decimal? PwpDefKwota { get; set; }

    public int? PwpIdSlownika { get; set; }

    public string? PwpSelect { get; set; }

    public int? PwpDefFk { get; set; }

    public bool? PwpSortSelect { get; set; }

    public string? PwpSelectWhere { get; set; }

    public bool? PwpDefFlaga { get; set; }

    public virtual SlSlownik? PwpIdSlownikaNavigation { get; set; }
}
