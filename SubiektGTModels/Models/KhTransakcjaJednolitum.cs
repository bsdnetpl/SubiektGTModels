using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhTransakcjaJednolitum
{
    public int KtjId { get; set; }

    public int KtjIdKontrahenta { get; set; }

    public bool KtjAktywna { get; set; }

    public decimal KtjWartPrzewidywana { get; set; }

    public string KtjNumer { get; set; } = null!;

    public string KtjNazwa { get; set; } = null!;

    public string KtjOpis { get; set; } = null!;

    public virtual KhKontrahent KtjIdKontrahentaNavigation { get; set; } = null!;
}
