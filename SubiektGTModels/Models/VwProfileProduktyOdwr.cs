using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileProduktyOdwr
{
    public int EprId { get; set; }

    public string EprNazwa { get; set; } = null!;

    public int? EprLiczbaStanowisk { get; set; }

    public int? EprWykorzystanie { get; set; }

    public int EprStatusNowosci { get; set; }
}
