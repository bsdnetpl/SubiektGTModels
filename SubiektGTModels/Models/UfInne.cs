using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfInne
{
    public int UinIdKonfiguracja { get; set; }

    public int UinIdInneUf { get; set; }

    public int UinIdWlasneSb { get; set; }

    public virtual UfKonfiguracja UinIdKonfiguracjaNavigation { get; set; } = null!;
}
