using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfCena
{
    public int UceIdKonfiguracja { get; set; }

    public int UceIdCenaUf { get; set; }

    public int UceIdCenaSb { get; set; }

    public virtual UfKonfiguracja UceIdKonfiguracjaNavigation { get; set; } = null!;
}
