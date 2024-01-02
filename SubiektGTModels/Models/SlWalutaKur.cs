using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWalutaKur
{
    public int WkId { get; set; }

    public DateTime WkData { get; set; }

    public int WkIdWaluty { get; set; }

    public string WkSymbol { get; set; } = null!;

    public decimal WkZakup { get; set; }

    public decimal WkSprzedaz { get; set; }

    public decimal WkSredni { get; set; }

    public int? WkIdTabeli { get; set; }

    public virtual SlWalutaTabelaKursow? WkIdTabeliNavigation { get; set; }

    public virtual SlWalutum WkSymbolNavigation { get; set; } = null!;
}
