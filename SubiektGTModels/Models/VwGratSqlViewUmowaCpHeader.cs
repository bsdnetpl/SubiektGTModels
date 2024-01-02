using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratSqlViewUmowaCpHeader
{
    public int Ident { get; set; }

    public string Nazwisko { get; set; } = null!;

    public string Imie { get; set; } = null!;

    public string Imie2 { get; set; } = null!;

    public string NumerUmowy { get; set; } = null!;
}
