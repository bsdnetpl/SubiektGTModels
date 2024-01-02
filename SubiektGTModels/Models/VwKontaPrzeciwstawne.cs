using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwKontaPrzeciwstawne
{
    public int IdZapisu { get; set; }

    public string Konto { get; set; } = null!;

    public string? Przeciwstawne { get; set; }

    public int? IloscKont { get; set; }
}
