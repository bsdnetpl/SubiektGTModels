using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KomFrParametr
{
    public int FprId { get; set; }

    public int FprFormat { get; set; }

    public bool FprDts { get; set; }

    public string FprSciezka { get; set; } = null!;

    public string FprRozszerzenie { get; set; } = null!;

    public int FprTyp { get; set; }

    public string FprNazwa { get; set; } = null!;

    public string FprKolumnaId { get; set; } = null!;
}
