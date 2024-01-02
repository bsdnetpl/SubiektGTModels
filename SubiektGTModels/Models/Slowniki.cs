using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class Slowniki
{
    public int Id { get; set; }

    public string Tabela { get; set; } = null!;

    public string SelectTwardosci { get; set; } = null!;

    public string? IdTabeli { get; set; }
}
