using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MkRatum
{
    public int RmkId { get; set; }

    public int RmkIdKoszt { get; set; }

    public string RmkNumer { get; set; } = null!;

    public int RmkTyp { get; set; }

    public DateTime RmkData { get; set; }

    public decimal RmkKwota { get; set; }

    public int? RmkIdKategoria { get; set; }

    public int RmkStatusKsiegowy { get; set; }

    public string RmkOpis { get; set; } = null!;

    public virtual SlKategorium? RmkIdKategoriaNavigation { get; set; }

    public virtual MkKoszt RmkIdKosztNavigation { get; set; } = null!;
}
