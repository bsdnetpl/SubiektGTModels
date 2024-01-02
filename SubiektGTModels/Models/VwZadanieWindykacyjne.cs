using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZadanieWindykacyjne
{
    public int ZdIdWind { get; set; }

    public string? FdwNazwa { get; set; }

    public int? ZdNotaOdsetkowa { get; set; }

    public int? ZdWezwanieDoZaplaty { get; set; }

    public int? ZdTypDokumentu { get; set; }

    public string? ZdTypDokumentuOpis { get; set; }
}
