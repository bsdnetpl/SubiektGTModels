using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyWzDomyslny
{
    public int WzdId { get; set; }

    public int WzdWzorzecId { get; set; }

    public string? WzdNazwaKomputera { get; set; }

    public int WzdTyp { get; set; }

    public virtual WyWzorzec WzdWzorzec { get; set; } = null!;
}
