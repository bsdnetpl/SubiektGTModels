using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwSerwisyChmurowePowiazanium
{
    public int IdZrodlo { get; set; }

    public int TypZrodlo { get; set; }

    public int? IdZapis { get; set; }

    public int? TypZapis { get; set; }
}
