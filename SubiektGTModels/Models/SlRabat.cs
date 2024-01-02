using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlRabat
{
    public int RtId { get; set; }

    public string? RtNazwa { get; set; }

    public int RtRodzaj { get; set; }

    public decimal RtProcent { get; set; }

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhParametr> KhParametrs { get; set; } = new List<KhParametr>();

    public virtual ICollection<TwTowar> TwTowars { get; set; } = new List<TwTowar>();
}
