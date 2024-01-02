using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SkStan
{
    public int SkstId { get; set; }

    public int SkstIdSesji { get; set; }

    public string SkstWaluta { get; set; } = null!;

    public int SkstFormaPlatnosci { get; set; }

    public decimal SkstStanPoczatkowy { get; set; }

    public decimal SkstStanKoncowy { get; set; }

    public decimal SkstSaldo { get; set; }

    public virtual SkSesja SkstIdSesjiNavigation { get; set; } = null!;

    public virtual SlWalutum SkstWalutaNavigation { get; set; } = null!;
}
