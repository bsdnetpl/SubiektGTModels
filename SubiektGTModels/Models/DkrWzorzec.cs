using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrWzorzec
{
    public int DkrwId { get; set; }

    public int DkrwTyp { get; set; }

    public string DkrwNazwa { get; set; } = null!;

    public string? DkrwRejestr { get; set; }

    public int DkrwKontrolaBilansowania { get; set; }

    public string DkrwWaluta { get; set; } = null!;

    public string DkrwWalutaWyswietlana { get; set; } = null!;

    public decimal DkrwKursDokumentu { get; set; }

    public int DkrwRodzajKursu { get; set; }

    public decimal DkrwKwota { get; set; }

    public decimal DkrwKwotaWaluta { get; set; }

    public decimal? DkrwKwotaVat { get; set; }

    public string DkrwUwagi { get; set; } = null!;

    public int? DkrwIdKategorii { get; set; }

    public DateTime? DkrwDataWykonania { get; set; }

    public int DkrwTypObiektu { get; set; }

    public int? DkrwIdObiektu { get; set; }

    public int? DkrwIdKh { get; set; }

    public string DkrwSymbolKh { get; set; } = null!;

    public virtual ICollection<DkrWzorzecPozycja> DkrWzorzecPozycjas { get; set; } = new List<DkrWzorzecPozycja>();

    public virtual SlKategorium? DkrwIdKategoriiNavigation { get; set; }

    public virtual SlRejestrKsiegowy? DkrwRejestrNavigation { get; set; }

    public virtual SlWalutum DkrwWalutaNavigation { get; set; } = null!;
}
