using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CenCennikKolumna
{
    public int CkoId { get; set; }

    public int CkoIdSzablon { get; set; }

    public int CkoLp { get; set; }

    public string CkoNazwa { get; set; } = null!;

    public int CkoIdCena { get; set; }

    public decimal CkoRabat { get; set; }

    public int CkoIdWaluta { get; set; }

    public decimal CkoKurs { get; set; }

    public virtual CenCennikSzablon CkoIdSzablonNavigation { get; set; } = null!;
}
