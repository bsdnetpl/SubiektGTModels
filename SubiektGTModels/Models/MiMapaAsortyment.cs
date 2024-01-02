using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MiMapaAsortyment
{
    public int MimId { get; set; }

    public int MimIdParametru { get; set; }

    public string MimIdProduktu { get; set; } = null!;

    public string MimOpisProduktu { get; set; } = null!;

    public int? MimIdTowaru { get; set; }

    public decimal MimCenaNetto { get; set; }

    public int? MimIdTowaruPromocyjnego { get; set; }

    public virtual MiSprzedazParametr MimIdParametruNavigation { get; set; } = null!;

    public virtual TwTowar? MimIdTowaruNavigation { get; set; }

    public virtual TwTowar? MimIdTowaruPromocyjnegoNavigation { get; set; }
}
