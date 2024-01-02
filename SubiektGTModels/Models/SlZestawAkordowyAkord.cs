using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlZestawAkordowyAkord
{
    public int ZalId { get; set; }

    public int ZalIdZestawu { get; set; }

    public int ZalIdStawkiAkrodowej { get; set; }

    public virtual SlStawkaAkordowa ZalIdStawkiAkrodowejNavigation { get; set; } = null!;

    public virtual SlZestawAkordowy ZalIdZestawuNavigation { get; set; } = null!;
}
