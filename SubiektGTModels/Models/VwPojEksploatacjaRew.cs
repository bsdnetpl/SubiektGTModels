using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPojEksploatacjaRew
{
    public int PprId { get; set; }

    public int PprIdPojazdu { get; set; }

    public int PprTyp { get; set; }

    public int PprZaksiegowany { get; set; }

    public DateTime? PprDataOtrzymania { get; set; }

    public DateTime PprData { get; set; }

    public string PprCel { get; set; } = null!;

    public string PprTrasa { get; set; } = null!;

    public decimal? PprKm { get; set; }

    public decimal? PprCenaKm { get; set; }

    public decimal? PprWartoscP { get; set; }

    public decimal? PprWartoscR { get; set; }

    public string PprNrDok { get; set; } = null!;

    public int? PprIdKh { get; set; }

    public string PprKhNazwa { get; set; } = null!;

    public string PprKhUlica { get; set; } = null!;

    public string PprKhMiasto { get; set; } = null!;

    public string PprKhKodPocztowy { get; set; } = null!;

    public string PprKhNip { get; set; } = null!;

    public int? PprIdKategorii { get; set; }

    public string PprOpis { get; set; } = null!;

    public string PprUwagi { get; set; } = null!;

    public bool PprCzyVat { get; set; }

    public DateTime? PprDataZakDost { get; set; }

    public string PprKierowca { get; set; } = null!;

    public decimal? PprStanLicznika { get; set; }

    public bool PprUdostepnienie { get; set; }

    public string PprKhNazwaPelna { get; set; } = null!;

    public int? PprMalyPojazd { get; set; }

    public int? PprStawkaVat { get; set; }

    public int PprPrzypadekSzczegolnyPit { get; set; }

    public int PprNettoBrutto { get; set; }

    public decimal PprWartoscZrachunku { get; set; }

    public int? SsTypObiektu { get; set; }

    public int? SsTypObiektuEx { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }
}
