using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwWiarygodnaSciezkaAudytu
{
    public int? Id { get; set; }

    public string? Nazwa { get; set; }

    public string? Numer { get; set; }

    public DateTime? DataWyst { get; set; }

    public decimal? WartoscBrutto { get; set; }

    public decimal? WartoscNetto { get; set; }

    public string? Wystawil { get; set; }

    public string? Kontrahent { get; set; }

    public string? Kategoria { get; set; }

    public int? IdOryg { get; set; }
}
