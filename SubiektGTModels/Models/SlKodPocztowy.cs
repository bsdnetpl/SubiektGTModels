using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKodPocztowy
{
    public int KcId { get; set; }

    public string KcK { get; set; } = null!;

    public string KcW { get; set; } = null!;

    public string KcP { get; set; } = null!;

    public string KcG { get; set; } = null!;

    public string KcM { get; set; } = null!;

    public string? KcU { get; set; }
}
