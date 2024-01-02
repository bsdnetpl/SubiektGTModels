using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzKorektaPit
{
    public int NkpId { get; set; }

    public int NkpIdRozrachunku { get; set; }

    public int NkpStatus { get; set; }

    public DateTime NkpData { get; set; }

    public DateTime? NkpMiesiac { get; set; }

    public decimal? NkpKwota { get; set; }

    public decimal? NkpSumaSplat { get; set; }

    public decimal? NkpKwotaSplat { get; set; }

    public decimal? NkpPozostaje { get; set; }

    public string NkpUwagi { get; set; } = null!;

    public virtual ICollection<DeklPitZdPole> DeklPitZdPoles { get; set; } = new List<DeklPitZdPole>();

    public virtual NzFinanse NkpIdRozrachunkuNavigation { get; set; } = null!;

    public virtual ICollection<NzKorektaZaliczenie> NzKorektaZaliczenies { get; set; } = new List<NzKorektaZaliczenie>();
}
