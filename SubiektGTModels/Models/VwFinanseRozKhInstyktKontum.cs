using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozKhInstyktKontum
{
    public string Konto { get; set; } = null!;

    public int RokObrotowy { get; set; }

    public int? Ident { get; set; }

    public int Typ { get; set; }
}
