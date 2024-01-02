using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlVatOznaczeniaJpkzakup
{
    public int SlvjzId { get; set; }

    public int SlvjzIdSlTypEwidVat { get; set; }

    public int SlvjzOznaczenieDowodu { get; set; }

    public bool SlvjzMpp { get; set; }

    public bool SlvjzImp { get; set; }
}
