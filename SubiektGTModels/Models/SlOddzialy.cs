using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlOddzialy
{
    public int SoId { get; set; }

    public string SoSymbol { get; set; } = null!;

    public string SoNazwa { get; set; } = null!;

    public string? SoOpis { get; set; }

    public string? SoEmail { get; set; }

    public string? SoLink { get; set; }

    public int? SoIdKonta { get; set; }

    public bool SoAktywny { get; set; }

    public bool SoBiezacy { get; set; }

    public virtual ICollection<PdUzytkownikOddzial> PdUzytkownikOddzials { get; set; } = new List<PdUzytkownikOddzial>();

    public virtual ICollection<SlOddzialKasa> SlOddzialKasas { get; set; } = new List<SlOddzialKasa>();

    public virtual ICollection<SlOddzialMagazyn> SlOddzialMagazyns { get; set; } = new List<SlOddzialMagazyn>();
}
