using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RozPlikRozszerzenium
{
    public int RozprId { get; set; }

    public int RozprIdRozszerzenia { get; set; }

    public string RozprNazwaPliku { get; set; } = null!;

    public byte[] RozprPlik { get; set; } = null!;

    public string RozprHash { get; set; } = null!;

    public int RozprTypPliku { get; set; }

    public int RozprRejestrowany { get; set; }

    public virtual RozRozszerzenie RozprIdRozszerzeniaNavigation { get; set; } = null!;
}
