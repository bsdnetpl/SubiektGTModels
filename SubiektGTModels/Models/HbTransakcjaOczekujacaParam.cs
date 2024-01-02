using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbTransakcjaOczekujacaParam
{
    public int HbtopId { get; set; }

    public bool HbtopZamianaZnakow { get; set; }

    public bool HbtopOczekujNaSrodki { get; set; }
}
