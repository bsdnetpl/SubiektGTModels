using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratUmowy
{
    public int UpId { get; set; }

    public int PrId { get; set; }

    public string Pracownik { get; set; } = null!;

    public DateTime PrDataUrodzenia { get; set; }

    public string UpNumer { get; set; } = null!;

    public int UpRodzaj { get; set; }

    public DateTime UpDataOd { get; set; }

    public DateTime? UpDataDo { get; set; }

    public DateTime? UpDataRozwiazania { get; set; }

    public string ZatrudnienieKrotkie { get; set; } = null!;

    public string? Zatrudnienie { get; set; }

    public string? DziNazwa { get; set; }

    public string? StnNazwa { get; set; }

    public DateTime? DataOstatniejWyplaty { get; set; }

    public int UpIdPracownika { get; set; }

    public int? DziId { get; set; }

    public int? UkId { get; set; }

    public string? SlkNazwa { get; set; }

    public string? Wymiar { get; set; }

    public string PrNip { get; set; } = null!;

    public string PrPesel { get; set; } = null!;

    public int? StnId { get; set; }

    public int UpUczen { get; set; }

    public DateTime? DataZawarcia { get; set; }
}
