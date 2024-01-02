using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwSesjeKasowe
{
    public int SksId { get; set; }

    public string SksNumer { get; set; } = null!;

    public int SksIdUzytkownika { get; set; }

    public int SksIdKasy { get; set; }

    public DateTime SksDataOtwarcia { get; set; }

    public int SksIdUzOtworzyl { get; set; }

    public DateTime? SksDataZamkniecia { get; set; }

    public int? SksIdUzZamknal { get; set; }

    public DateTime? SksDataRozliczenia { get; set; }

    public int? SksStatusZgodnosci { get; set; }

    public int SksStatus { get; set; }

    public string? SksImieNazwiskoUzytkownik { get; set; }

    public string? SksImieNazwiskoOtworzyl { get; set; }

    public string? SksImieNazwiskoZamknal { get; set; }
}
