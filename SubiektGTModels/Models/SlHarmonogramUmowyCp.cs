using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlHarmonogramUmowyCp
{
    public int HucpId { get; set; }

    public string HucpNazwa { get; set; } = null!;

    public int HucpRodzajPozycji { get; set; }

    public int HucpRodzajCyklu { get; set; }

    public int HucpOkresSposobOkreslenia { get; set; }

    public int HucpOkresWydluzOkres { get; set; }

    public int? HucpDataRachDzien { get; set; }

    public int? HucpDataRachDzienTygodnia { get; set; }

    public bool HucpRozliczAkordy { get; set; }

    public bool HucpRozliczProwizje { get; set; }

    public bool HucpRozliczEcp { get; set; }

    public int? HucpRozliczEcpmiesiac { get; set; }

    public int? HucpIdSzablonuWydruku { get; set; }

    public int? HucpRodzajPrzychodu { get; set; }

    public bool HucpRyczalt { get; set; }

    public bool HucpRozliczEwidGodzinPracy { get; set; }

    public int? HucpRozliczEwidGodzinPracyMiesiac { get; set; }

    public virtual SlGratTrescDok? HucpIdSzablonuWydrukuNavigation { get; set; }
}
