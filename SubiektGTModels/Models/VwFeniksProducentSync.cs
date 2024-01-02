using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksProducentSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public string KhSymbol { get; set; } = null!;

    public string KhRegon { get; set; } = null!;

    public string KhWww { get; set; } = null!;

    public string KhEmail { get; set; } = null!;

    public string AdrNazwa { get; set; } = null!;

    public string AdrNazwaPelna { get; set; } = null!;

    public string AdrTelefon { get; set; } = null!;

    public string AdrFaks { get; set; } = null!;

    public string AdrNip { get; set; } = null!;
}
