using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwImpListaPlac
{
    public int LpId { get; set; }

    public DateTime LpDataWyplaty { get; set; }

    public DateTime LpDataSkladek { get; set; }

    public DateTime? LpDataZaliczek { get; set; }

    public int LpStatusKsiegowyLp { get; set; }

    public int LpStatusKsiegowySkladki { get; set; }

    public int? LpStatusKsiegowyZaliczki { get; set; }

    public string LpNumer { get; set; } = null!;

    public string LpTytul { get; set; } = null!;

    public int? LpIdKategorii { get; set; }

    public int LpStatusKsiegowyPpk { get; set; }

    public DateTime LpDataWplatyPpk { get; set; }
}
