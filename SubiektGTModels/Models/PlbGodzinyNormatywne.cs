using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbGodzinyNormatywne
{
    public int PlbgnId { get; set; }

    public int PlbgnRok { get; set; }

    public int PlbgnMiesiac { get; set; }

    public int PlbgnGodziny { get; set; }

    public bool PlbgnZmienione { get; set; }
}
