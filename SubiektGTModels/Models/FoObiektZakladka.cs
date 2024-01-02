using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FoObiektZakladka
{
    public int FozId { get; set; }

    public int FozIdDefinicji { get; set; }

    public string FozNazwa { get; set; } = null!;

    public int? FozUpidPokaz { get; set; }

    public int? FozUpidEdytuj { get; set; }

    public bool? FozStworzUprawnienia { get; set; }

    public int? FozKolejnosc { get; set; }

    public virtual FoObiektDefinicja FozIdDefinicjiNavigation { get; set; } = null!;
}
