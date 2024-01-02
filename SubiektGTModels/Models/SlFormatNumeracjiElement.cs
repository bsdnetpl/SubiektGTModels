using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlFormatNumeracjiElement
{
    public int FneId { get; set; }

    public int FneIdFormatu { get; set; }

    public int FneTyp { get; set; }

    public int FnePozycja { get; set; }

    public int? FneLicznikId { get; set; }

    public int FneLicznikFmt { get; set; }

    public int? FneLicznikZliczanie { get; set; }

    public int? FneRokFmt { get; set; }

    public int? FneMiesiacFmt { get; set; }

    public string FneTekst { get; set; } = null!;

    public string? FneSeparator { get; set; }

    public int? FneMpk { get; set; }

    public virtual SlFormatNumeracji FneIdFormatuNavigation { get; set; } = null!;

    public virtual SlLicznikNumeracji? FneLicznik { get; set; }
}
