using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDekl
{
    public int DeId { get; set; }

    public int DeIdWzorca { get; set; }

    public int DeTypObiektu { get; set; }

    public int? DeIdObiektu { get; set; }

    public string DeNazwaObiektu { get; set; } = null!;

    public DateTime DeOkresOd { get; set; }

    public DateTime DeOkresDo { get; set; }

    public string DeOkres { get; set; } = null!;

    public DateTime DeDataAktualizacji { get; set; }

    public decimal? DeDoZaplaty { get; set; }

    public bool? DeKorekta { get; set; }

    public int? DeIdDeklGlownej { get; set; }

    public bool? DeCzyGlownyZal { get; set; }

    public int WysStatus { get; set; }

    public decimal? DePdstSkladkiZdrowotnej { get; set; }

    public bool? DeWersjaRobocza { get; set; }

    public decimal? DeDochodPrzychodPdstSklZdr { get; set; }
}
