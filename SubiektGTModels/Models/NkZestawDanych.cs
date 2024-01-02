using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NkZestawDanych
{
    public int NzwId { get; set; }

    public int NzwIdZrodlaDanych { get; set; }

    public string NzwNazwa { get; set; } = null!;

    public string NzwKontrolki { get; set; } = null!;

    public bool? NzwLista { get; set; }

    public byte[]? NzwBinListInfo { get; set; }

    public byte[]? NzwBinColumns { get; set; }

    public byte[]? NzwBinTables { get; set; }

    public byte[]? NzwBinVisibility { get; set; }

    public virtual NkZrodloDanych NzwIdZrodlaDanychNavigation { get; set; } = null!;
}
