using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaPrzelewy
{
    public int UpppId { get; set; }

    public int UpppIdUmowy { get; set; }

    public int? UpppIdRachunku { get; set; }

    public int UpppMetodaPrzelewu { get; set; }

    public decimal? UpppKwota { get; set; }

    public decimal? UpppProcent { get; set; }

    public int UpppPriorytet { get; set; }

    public virtual RbRachBankowy? UpppIdRachunkuNavigation { get; set; }

    public virtual PlbUmowa UpppIdUmowyNavigation { get; set; } = null!;
}
