using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DwPozycja
{
    public int DwewpId { get; set; }

    public int DwewpIdDowWew { get; set; }

    public string DwewpNazwa { get; set; } = null!;

    public string DwewpJm { get; set; } = null!;

    public decimal DwewpIlosc { get; set; }

    public decimal DwewpCena { get; set; }

    public decimal DwewpWartosc { get; set; }

    public virtual DwDokument DwewpIdDowWewNavigation { get; set; } = null!;
}
