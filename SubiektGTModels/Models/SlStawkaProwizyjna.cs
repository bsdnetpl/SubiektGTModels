using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStawkaProwizyjna
{
    public int SpId { get; set; }

    public string SpNazwa { get; set; } = null!;

    public int SpTypStawki { get; set; }

    public decimal? SpLiniowaPrzelicznik { get; set; }
}
