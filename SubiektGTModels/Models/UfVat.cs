using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfVat
{
    public int UvaIdKonfiguracja { get; set; }

    public int UvaIdVatUf { get; set; }

    public int UvaIdVatSb { get; set; }

    public virtual UfKonfiguracja UvaIdKonfiguracjaNavigation { get; set; } = null!;

    public virtual SlStawkaVat UvaIdVatSbNavigation { get; set; } = null!;
}
