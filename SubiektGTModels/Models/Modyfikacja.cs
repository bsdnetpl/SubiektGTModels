using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class Modyfikacja
{
    public int Id { get; set; }

    public string? Kolumna { get; set; }

    public string? Tabela { get; set; }

    public string? Zrodlo { get; set; }
}
