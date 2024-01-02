using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlZwolnienieZvat
{
    public int SlpzvId { get; set; }

    public bool SlpzvAktywna { get; set; }

    public int SlpzvSystemowa { get; set; }

    public int SlpzvZrodloZwolnienia { get; set; }

    public string SlpzvNazwa { get; set; } = null!;

    public string SlpzvOpis { get; set; } = null!;

    public int SlpzvRodzajZwolnienia { get; set; }

    public virtual ICollection<DokDokument> DokDokuments { get; set; } = new List<DokDokument>();

    public virtual ICollection<VatMetodaRozl> VatMetodaRozls { get; set; } = new List<VatMetodaRozl>();
}
