using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwRozliczeniaMiedzyokresoweKosztow
{
    public int? Id { get; set; }

    public int StatusKsiegowy { get; set; }

    public int Typ { get; set; }

    public string NazwaKosztu { get; set; } = null!;

    public string NumerKosztu { get; set; } = null!;

    public string NumerDok { get; set; } = null!;

    public DateTime Data { get; set; }

    public decimal WartoscKosztu { get; set; }

    public decimal WartoscRozliczenia { get; set; }

    public int? Kategoria { get; set; }

    public int IdKosztu { get; set; }

    public int StatusKosztu { get; set; }
}
