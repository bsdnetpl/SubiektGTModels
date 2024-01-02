using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwKlienci
{
    public int AdrId { get; set; }

    public int KhId { get; set; }

    public bool KhZablokowany { get; set; }

    public int KhTyp { get; set; }

    public int KhRodzaj { get; set; }

    public string? KhSymbol { get; set; }

    public string AdrNazwa { get; set; } = null!;

    public string AdrNazwaPelna { get; set; } = null!;

    public int? IdFirmy { get; set; }

    public string? Firma { get; set; }

    public string AdrMiejscowosc { get; set; } = null!;

    public string? AdrNip { get; set; }

    public string? KhRegon { get; set; }

    public string AdrKod { get; set; } = null!;

    public string AdrAdres { get; set; } = null!;

    public string AdrTelefon { get; set; } = null!;

    public string KhEmail { get; set; } = null!;

    public string KhGaduGadu { get; set; } = null!;

    public string KhSkype { get; set; } = null!;

    public string? KhWww { get; set; }

    public string? KhPracownik { get; set; }

    public string? PkTelefon { get; set; }

    public string? PkEmail { get; set; }

    public string? KhUwagi { get; set; }

    public bool? KhZgodaDo { get; set; }

    public bool? KhZgodaMark { get; set; }

    public bool? KhZgodaEmail { get; set; }

    public int? AdrIdPanstwo { get; set; }

    public int? AdrIdWojewodztwo { get; set; }

    public int? PkIdKh { get; set; }

    public int? KhIdGrupa { get; set; }

    public int? KhIdRodzajKontaktu { get; set; }

    public int? KhIdPozyskany { get; set; }

    public int? KhIdBranza { get; set; }

    public int? KhIdRegion { get; set; }

    public int? KhIdDzial { get; set; }

    public string? KhStanowisko { get; set; }

    public int? KhLiczbaPrac { get; set; }

    public int KhPotencjalny { get; set; }

    public int KhJednorazowy { get; set; }

    public int? KhIdOpiekun { get; set; }

    public int? KhIdDodal { get; set; }

    public int? KhIdZmienil { get; set; }

    public DateTime? KhDataDodania { get; set; }

    public DateTime? KhDataZmiany { get; set; }

    public DateTime? KhDataOkolicznosciowa { get; set; }

    public bool? PkPodstaw { get; set; }

    public string? KhPole1 { get; set; }

    public string? KhPole2 { get; set; }

    public string? KhPole3 { get; set; }

    public string? KhPole4 { get; set; }

    public string? KhPole5 { get; set; }

    public string? KhPole6 { get; set; }

    public string? KhPole7 { get; set; }

    public string? KhPole8 { get; set; }

    public string AdrFaks { get; set; } = null!;

    public string? KhPesel { get; set; }
}
