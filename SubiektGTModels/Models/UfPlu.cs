using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfPlu
{
    public int UplId { get; set; }

    public int UplIdKonfiguracja { get; set; }

    public int UplIdTowar { get; set; }

    public int UplKodPlu { get; set; }

    public int UplRodzaj { get; set; }

    public virtual UfKonfiguracja UplIdKonfiguracjaNavigation { get; set; } = null!;

    public virtual TwTowar UplIdTowarNavigation { get; set; } = null!;
}
