using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MkPrzesuniecie
{
    public int PmkId { get; set; }

    public int PmkIdKoszt { get; set; }

    public string PmkNumer { get; set; } = null!;

    public DateTime PmkData { get; set; }

    public int PmkIdMpk { get; set; }

    public int? PmkIdKategoria { get; set; }

    public string PmkOpis { get; set; } = null!;

    public virtual SlKategorium? PmkIdKategoriaNavigation { get; set; }

    public virtual MkKoszt PmkIdKosztNavigation { get; set; } = null!;

    public virtual StMpk PmkIdMpkNavigation { get; set; } = null!;
}
