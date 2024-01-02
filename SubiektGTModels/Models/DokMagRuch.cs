using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokMagRuch
{
    public int MrId { get; set; }

    public int? MrDoId { get; set; }

    public int MrSeriaId { get; set; }

    public int MrPozId { get; set; }

    public int MrTowId { get; set; }

    public int? MrMagId { get; set; }

    public DateTime MrData { get; set; }

    public decimal MrIlosc { get; set; }

    public decimal MrPozostalo { get; set; }

    public decimal MrCena { get; set; }

    public DateTime? MrTermin { get; set; }

    public virtual ICollection<DokMagDysp> DokMagDysps { get; set; } = new List<DokMagDysp>();

    public virtual DokPozycja MrPoz { get; set; } = null!;
}
