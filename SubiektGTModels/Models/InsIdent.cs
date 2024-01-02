using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class InsIdent
{
    public int IdoWartosc { get; set; }

    public string IdoNazwa { get; set; } = null!;

    public int? IdoMinIdValue { get; set; }
}
