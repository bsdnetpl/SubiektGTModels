using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmProperty
{
    public int EpId { get; set; }

    public int EpUserId { get; set; }

    public int? EpKontoId { get; set; }

    public int? EpWyslijOdbierz { get; set; }

    public bool EpAutomat { get; set; }

    public bool? EpWyslijOdRazu { get; set; }

    public bool? EpWyslijZamknij { get; set; }

    public int? EpCoIle { get; set; }

    public bool? EpHtml { get; set; }

    public bool EpPrzeczytane { get; set; }

    public int EpCzasPrzeczyt { get; set; }
}
