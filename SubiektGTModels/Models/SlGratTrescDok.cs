using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGratTrescDok
{
    public int TdId { get; set; }

    public bool TdDomyslna { get; set; }

    public string TdOpis { get; set; } = null!;

    public int TdTypDokumentu { get; set; }

    public byte[]? TdTresc { get; set; }

    public int? TdFormat { get; set; }

    public virtual ICollection<PlbRachunekDoUmowyCp> PlbRachunekDoUmowyCps { get; set; } = new List<PlbRachunekDoUmowyCp>();

    public virtual ICollection<PlbUmowaCpParametryZestaw> PlbUmowaCpParametryZestawUpzRachTrescRachunkuNavigations { get; set; } = new List<PlbUmowaCpParametryZestaw>();

    public virtual ICollection<PlbUmowaCpParametryZestaw> PlbUmowaCpParametryZestawUpzUmowaIdTresciNavigations { get; set; } = new List<PlbUmowaCpParametryZestaw>();

    public virtual ICollection<PlbUmowaCp> PlbUmowaCpUcpIdSzablonuRachunkuNavigations { get; set; } = new List<PlbUmowaCp>();

    public virtual ICollection<PlbUmowaCp> PlbUmowaCpUcpIdSzablonuUmowyNavigations { get; set; } = new List<PlbUmowaCp>();

    public virtual ICollection<PlbUmowaCpharmonogram> PlbUmowaCpharmonograms { get; set; } = new List<PlbUmowaCpharmonogram>();

    public virtual ICollection<PlbUmowa> PlbUmowas { get; set; } = new List<PlbUmowa>();

    public virtual ICollection<SlHarmonogramUmowyCp> SlHarmonogramUmowyCps { get; set; } = new List<SlHarmonogramUmowyCp>();
}
