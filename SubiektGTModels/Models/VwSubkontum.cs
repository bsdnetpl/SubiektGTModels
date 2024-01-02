using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwSubkontum
{
    public int? Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public int? IdParser { get; set; }

    public int? IdPosrednika { get; set; }
}
