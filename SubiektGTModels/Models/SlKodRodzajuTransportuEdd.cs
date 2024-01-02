using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKodRodzajuTransportuEdd
{
    public int SlkrtId { get; set; }

    public string SlkrtWartosc { get; set; } = null!;

    public bool SlkrtAktywna { get; set; }

    public virtual ICollection<DokDokument> DokDokuments { get; set; } = new List<DokDokument>();

    public virtual ICollection<EddParametr> EddParametrs { get; set; } = new List<EddParametr>();
}
