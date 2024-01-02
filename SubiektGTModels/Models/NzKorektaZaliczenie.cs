using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzKorektaZaliczenie
{
    public int NkzId { get; set; }

    public int NkzIdKorekta { get; set; }

    public bool NkzNieZaliczaj { get; set; }

    public DateTime NkzData { get; set; }

    public DateTime? NkzMiesiac { get; set; }

    public DateTime? NkzDataSplaty { get; set; }

    public decimal? NkzSumaSplat { get; set; }

    public decimal? NkzKwota { get; set; }

    public string NkzUwagi { get; set; } = null!;

    public virtual ICollection<DeklPitZdPole> DeklPitZdPoles { get; set; } = new List<DeklPitZdPole>();

    public virtual NzKorektaPit NkzIdKorektaNavigation { get; set; } = null!;
}
