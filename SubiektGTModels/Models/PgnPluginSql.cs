using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PgnPluginSql
{
    public int PgnsId { get; set; }

    public int PgnsTyp { get; set; }

    public string PgnsNazwa { get; set; } = null!;

    public string PgnsDefinicja { get; set; } = null!;

    public string PgnsTytulDialoguParametrow { get; set; } = null!;
}
