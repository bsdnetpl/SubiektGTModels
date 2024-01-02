using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MkKorektum
{
    public int KmkId { get; set; }

    public int KmkIdKoszt { get; set; }

    public string KmkNumer { get; set; } = null!;

    public DateTime KmkData { get; set; }

    public decimal KmkKwotaPrzedKorekta { get; set; }

    public decimal KmkKwota { get; set; }

    public decimal KmkKwotaPoKorekcie { get; set; }

    public int KmkStatusKsiegowy { get; set; }

    public int? KmkIdKategoria { get; set; }

    public string KmkOpis { get; set; } = null!;

    public virtual SlKategorium? KmkIdKategoriaNavigation { get; set; }

    public virtual MkKoszt KmkIdKosztNavigation { get; set; } = null!;
}
