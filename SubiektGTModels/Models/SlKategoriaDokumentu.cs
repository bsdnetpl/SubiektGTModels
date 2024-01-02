using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKategoriaDokumentu
{
    public int KdId { get; set; }

    public string KdNazwa { get; set; } = null!;

    public string KdOpis { get; set; } = null!;

    public bool KdDomyslna { get; set; }

    public bool KdGratyfikant { get; set; }

    public virtual ICollection<DokDokBiblioteka> DokDokBibliotekas { get; set; } = new List<DokDokBiblioteka>();

    public virtual ICollection<KhDokument> KhDokuments { get; set; } = new List<KhDokument>();

    public virtual ICollection<PdDokument> PdDokuments { get; set; } = new List<PdDokument>();

    public virtual ICollection<PrDokument> PrDokuments { get; set; } = new List<PrDokument>();

    public virtual ICollection<TwDokument> TwDokuments { get; set; } = new List<TwDokument>();
}
