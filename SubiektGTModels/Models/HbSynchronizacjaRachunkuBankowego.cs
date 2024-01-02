using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbSynchronizacjaRachunkuBankowego
{
    public int HbsId { get; set; }

    public int HbsIdRachunkuBankowego { get; set; }

    public DateTime? HbsOstatniaModyfikacja { get; set; }

    public virtual RbRachBankowy HbsIdRachunkuBankowegoNavigation { get; set; } = null!;
}
