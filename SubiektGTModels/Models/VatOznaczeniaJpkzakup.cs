using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatOznaczeniaJpkzakup
{
    public int VjzId { get; set; }

    public int VjzIdEwidVat { get; set; }

    public int? VjzOznaczenieDowodu { get; set; }

    public bool? VjzMpp { get; set; }

    public bool? VjzImp { get; set; }

    public virtual VatEwidVat VjzIdEwidVatNavigation { get; set; } = null!;
}
