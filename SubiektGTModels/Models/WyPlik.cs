using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyPlik
{
    public int WplId { get; set; }

    public int WplWzorzecId { get; set; }

    public byte[]? WplPlikRaportu { get; set; }

    public int? WplNrStrony { get; set; }

    public string WplNazwaPliku { get; set; } = null!;

    public string? WplSkrotMd5 { get; set; }

    public int WplWersja { get; set; }
}
