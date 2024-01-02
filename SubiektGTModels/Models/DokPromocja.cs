using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokPromocja
{
    public int PcId { get; set; }

    public int? PcTwGrId { get; set; }

    public int? PcKhGrId { get; set; }

    public int? PcCenyPoziom { get; set; }

    public decimal? PcRabat { get; set; }

    public string? PcNazwa { get; set; }

    public DateTime? PcOd { get; set; }

    public DateTime? PcDo { get; set; }

    public bool? PcNieaktywna { get; set; }

    public bool? PcWyborTw { get; set; }

    public bool? PcWyborKh { get; set; }

    public int? PcRodzProm { get; set; }

    public decimal? PcCenaNetto { get; set; }

    public decimal? PcCenaBrutto { get; set; }

    public bool PcPos { get; set; }

    public bool PcOgraniczonaCzasowo { get; set; }

    public int PcInterwal { get; set; }

    public bool PcCalyDzien { get; set; }

    public bool PcRobocze { get; set; }

    public DateTime? PcPoczatekZcyklu { get; set; }

    public int PcCoIle { get; set; }

    public int PcDniTygodnia { get; set; }

    public int PcDzienMiesiaca { get; set; }

    public bool? PcDefinicjaZlozona { get; set; }

    public int PcDzienPorzadek { get; set; }

    public int PcDzienRodzaj { get; set; }

    public int PcMiesiac { get; set; }

    public int PcRodzajPowtorzen { get; set; }

    public int PcIlePowtorzen { get; set; }

    public DateTime? PcKoniecPowtorzen { get; set; }

    public bool PcIlePowtorzenWdniach { get; set; }

    public bool PcMultiStore { get; set; }

    public virtual ICollection<DokPromocjaKontrahent> DokPromocjaKontrahents { get; set; } = new List<DokPromocjaKontrahent>();

    public virtual ICollection<DokPromocjaTowar> DokPromocjaTowars { get; set; } = new List<DokPromocjaTowar>();
}
