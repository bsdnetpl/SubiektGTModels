using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbTransakcjaElektroniczna
{
    public int HbteId { get; set; }

    public int? HpteTransakcjaOczekujacaId { get; set; }

    public int? HbteIdRachunkuBankowego { get; set; }

    public virtual HbPowiazanieTransakcji? HbPowiazanieTransakcji { get; set; }

    public virtual RbRachBankowy? HbteIdRachunkuBankowegoNavigation { get; set; }
}
