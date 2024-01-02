using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MiSprzedaz
{
    public int MisId { get; set; }

    public int MisIdPartnera { get; set; }

    public int MisIdZamowienia { get; set; }

    public DateTime MisDataUtworzenia { get; set; }

    public DateTime MisDataPlatnosci { get; set; }

    public DateTime MisDataRozdzielenia { get; set; }

    public DateTime MisDataModyfikacji { get; set; }

    public string MisIdPlatnosci { get; set; } = null!;

    public decimal? MisWartoscBrutto { get; set; }

    public string? MisOpis { get; set; }

    public string MisKhTypIdentyfikatora { get; set; } = null!;

    public string MisKhIdentyfikator { get; set; } = null!;

    public string MisKhEmail { get; set; } = null!;

    public int MisKhIdAdresu { get; set; }

    public int? MisKhIdPowiazania { get; set; }

    public int? MisDokIdPowiazania { get; set; }

    public int? MisDokPapierowyIdAdresu { get; set; }

    public int? MisDokIdMaila { get; set; }

    public int? MisDokPrzyjeciaIdPowiazania { get; set; }

    public int MisStatusMapowania { get; set; }

    public int MisStatusKontrahenta { get; set; }

    public int MisStatusPrzetworzenia { get; set; }

    public bool MisStatusObsluzeniaSerwisu { get; set; }

    public DateTime MisDataPobrania { get; set; }

    public string? MisWersjaPobrania { get; set; }

    public virtual ICollection<MiSprzedazPozycja> MiSprzedazPozycjas { get; set; } = new List<MiSprzedazPozycja>();

    public virtual MiSprzedazAdre? MisDokPapierowyIdAdresuNavigation { get; set; }

    public virtual MiSprzedazAdre MisKhIdAdresuNavigation { get; set; } = null!;

    public virtual KhKontrahent? MisKhIdPowiazaniaNavigation { get; set; }
}
