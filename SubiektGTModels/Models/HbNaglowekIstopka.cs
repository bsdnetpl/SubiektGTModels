using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbNaglowekIstopka
{
    public int HbIdNaglowek { get; set; }

    public string? HbNumerRachunkuWyciagu { get; set; }

    public DateTime? HbDataUtworzeniaWyciagu { get; set; }

    public string? HbNumerWyciagu { get; set; }

    public string? HbBilansOtwarciaWaluta { get; set; }

    public int? HbIdRachunku { get; set; }

    public int HbZrodlo { get; set; }

    public virtual RbRachBankowy? HbIdRachunkuNavigation { get; set; }

    public virtual ICollection<HbTransakcja> HbTransakcjas { get; set; } = new List<HbTransakcja>();

    public virtual ICollection<NzWyciagBankowy> NzWyciagBankowies { get; set; } = new List<NzWyciagBankowy>();
}
