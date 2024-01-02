using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SkParametr
{
    public int SkpId { get; set; }

    public int SkpParamEwidId { get; set; }

    public int SkpIdNumeracji { get; set; }

    public bool SkpKontrolaDatDokumentow { get; set; }

    public bool SkpLimitNierozliczonychSesji { get; set; }

    public bool SkpOtworzSesjePoZalogowaniu { get; set; }

    public bool SkpOtworzSesjePoZalogowaniuPos { get; set; }

    public int SkpOtworzSesjeDla { get; set; }

    public bool SkpZamknijSesjePoWylogowaniu { get; set; }

    public virtual SlFormatNumeracji SkpIdNumeracjiNavigation { get; set; } = null!;

    public virtual ParEwid SkpParamEwid { get; set; } = null!;
}
