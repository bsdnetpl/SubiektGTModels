using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklZu
{
    public int DzId { get; set; }

    public DateTime DzOkres { get; set; }

    public DateTime DzDataAktualizacji { get; set; }

    public string DzOpis { get; set; } = null!;

    public string DzDane { get; set; } = null!;

    public decimal DzWartosc { get; set; }
}
