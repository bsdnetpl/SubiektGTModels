using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaCpprzelewy
{
    public int UcppId { get; set; }

    public int UcppIdUmowy { get; set; }

    public int? UcppIdRachunku { get; set; }

    public int UcppMetodaPrzelewu { get; set; }

    public decimal? UcppKwota { get; set; }

    public decimal? UcppProcent { get; set; }

    public int UcppPriorytet { get; set; }

    public virtual RbRachBankowy? UcppIdRachunkuNavigation { get; set; }

    public virtual PlbUmowaCp UcppIdUmowyNavigation { get; set; } = null!;
}
