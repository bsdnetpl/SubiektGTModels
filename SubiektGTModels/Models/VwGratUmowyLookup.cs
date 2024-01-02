using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratUmowyLookup
{
    public int Ident { get; set; }

    public int Typ { get; set; }

    public int? PodTyp { get; set; }

    public string Numer { get; set; } = null!;

    public DateTime DataOd { get; set; }

    public DateTime? DataDo { get; set; }

    public DateTime? DataZak { get; set; }

    public string PracImie { get; set; } = null!;

    public string PracNazwisko { get; set; } = null!;

    public DateTime PracDataUr { get; set; }

    public int NaCzas { get; set; }

    public int? IdDzialu { get; set; }

    public int IdPrac { get; set; }

    public string PracNazwiskoImie { get; set; } = null!;
}
