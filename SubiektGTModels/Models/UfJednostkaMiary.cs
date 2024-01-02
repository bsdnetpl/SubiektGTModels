using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfJednostkaMiary
{
    public int UjmIdKonfiguracja { get; set; }

    public int UjmIdJednostkaUf { get; set; }

    public string UjmJednostkaSb { get; set; } = null!;

    public virtual UfKonfiguracja UjmIdKonfiguracjaNavigation { get; set; } = null!;
}
