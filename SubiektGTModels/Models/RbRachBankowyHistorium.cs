using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RbRachBankowyHistorium
{
    public int RbhId { get; set; }

    public int RbhIdRachunku { get; set; }

    public string RbhNumer { get; set; } = null!;

    public string RbhBank { get; set; } = null!;

    public bool RbhIban { get; set; }

    public string RbhIdWaluty { get; set; } = null!;

    public int? RbhIdObiektu { get; set; }

    public int RbhTypObiektu { get; set; }

    public string RbhNumerZnormalizowany { get; set; } = null!;

    public virtual ICollection<HbTransakcjaOczekujaca> HbTransakcjaOczekujacas { get; set; } = new List<HbTransakcjaOczekujaca>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual RbRachBankowy RbhIdRachunkuNavigation { get; set; } = null!;

    public virtual SlWalutum RbhIdWalutyNavigation { get; set; } = null!;
}
