using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksTowarKodySync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public string? Producent { get; set; }

    public string KodEan { get; set; } = null!;

    public string? KodIsbn { get; set; }

    public string? KodBloz7 { get; set; }

    public string? KodBloz12 { get; set; }

    public string? KodUproducenta { get; set; }
}
