using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokMagDysp
{
    public int MdId { get; set; }

    public int MdPozId { get; set; }

    public int MdSpid { get; set; }

    public decimal MdIlosc { get; set; }

    public DateTime MdCzas { get; set; }

    public int? MdDoId { get; set; }

    public decimal MdDoIlosc { get; set; }

    public virtual DokMagRuch Md { get; set; } = null!;
}
