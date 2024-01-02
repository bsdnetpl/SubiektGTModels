using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DksKasaBo
{
    public int KsoId { get; set; }

    public int KsoIdKasy { get; set; }

    public string KsoWaluta { get; set; } = null!;

    public decimal KsoKwota { get; set; }

    public virtual DksKasa KsoIdKasyNavigation { get; set; } = null!;

    public virtual SlWalutum KsoWalutaNavigation { get; set; } = null!;
}
