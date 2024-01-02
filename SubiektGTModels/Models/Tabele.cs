using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class Tabele
{
    public string NazwaTabeli { get; set; } = null!;

    public string PrzedrostekAtrybutu { get; set; } = null!;

    public string Opis { get; set; } = null!;

    public string? Autor { get; set; }

    public bool Skonczona { get; set; }

    public string? Duplikaty { get; set; }

    public string? Produkt { get; set; }
}
