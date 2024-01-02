using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DwParametr
{
    public int DwewprId { get; set; }

    public bool DwewprKontrolaUniqNrDokumentu { get; set; }

    public int? DwewprIdKategorii { get; set; }

    public int DwewprKsWyborKolumn { get; set; }

    public int DwewprKolumnaKs { get; set; }

    public string DwewprOpisKs { get; set; } = null!;

    public int DwewprKsWyborKolumnPrzy { get; set; }

    public int DwewprKolumnaKsPrzy { get; set; }

    public string DwewprOpisKsPrzy { get; set; } = null!;

    public int DwewprIdStawkiRyczaltu { get; set; }

    public bool DwewprOpisDokuemnt { get; set; }

    public bool DwewprOpisDokuemntPrzy { get; set; }

    public virtual SlKategorium? DwewprIdKategoriiNavigation { get; set; }
}
