using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwKonfiguracja
{
    public string VwcgSection { get; set; } = null!;

    public int VwcgUser { get; set; }

    public int VwcgService { get; set; }

    public byte[]? VwcgData { get; set; }

    public byte[]? VwcgFiltersData { get; set; }
}
