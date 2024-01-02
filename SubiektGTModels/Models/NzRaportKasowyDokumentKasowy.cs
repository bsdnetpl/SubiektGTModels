using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzRaportKasowyDokumentKasowy
{
    public int RkdId { get; set; }

    public int RkdIdRk { get; set; }

    public int RkdIdDk { get; set; }

    public bool RkdKorekta { get; set; }

    public string RkdTytulem { get; set; } = null!;

    public virtual NzFinanse RkdIdDkNavigation { get; set; } = null!;

    public virtual NzRaportKasowy RkdIdRkNavigation { get; set; } = null!;
}
