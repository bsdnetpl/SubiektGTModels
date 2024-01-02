using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGrupaDokumentow
{
    public int GdId { get; set; }

    public string GdNazwa { get; set; } = null!;

    public int GdRodzajDokumentuGlownego { get; set; }

    public int? GdTypDokumentuGlownego { get; set; }

    public int? GdTypDokumentuPowiazanego { get; set; }

    public int GdProgramy { get; set; }

    public virtual ICollection<DpDokument> DpDokuments { get; set; } = new List<DpDokument>();

    public virtual ICollection<KsefFakturyKsiegowosc> KsefFakturyKsiegowoscs { get; set; } = new List<KsefFakturyKsiegowosc>();

    public virtual ICollection<PbDokument> PbDokuments { get; set; } = new List<PbDokument>();
}
