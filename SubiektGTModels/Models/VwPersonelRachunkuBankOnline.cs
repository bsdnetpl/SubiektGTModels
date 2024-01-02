using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPersonelRachunkuBankOnline
{
    public int UzId { get; set; }

    public string UzIdentyfikator { get; set; } = null!;

    public string UzNazwisko { get; set; } = null!;

    public string UzImie { get; set; } = null!;

    public int RbeIdRachunku { get; set; }
}
