using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class AdrHistorium
{
    public int AdrhId { get; set; }

    public int AdrhIdAdresu { get; set; }

    public string AdrhNazwa { get; set; } = null!;

    public string AdrhNazwaPelna { get; set; } = null!;

    public string AdrhTelefon { get; set; } = null!;

    public string AdrhFaks { get; set; } = null!;

    public string AdrhUlica { get; set; } = null!;

    public string AdrhNrDomu { get; set; } = null!;

    public string AdrhNrLokalu { get; set; } = null!;

    public string AdrhAdres { get; set; } = null!;

    public string AdrhKod { get; set; } = null!;

    public string AdrhMiejscowosc { get; set; } = null!;

    public int? AdrhIdWojewodztwo { get; set; }

    public int? AdrhIdPanstwo { get; set; }

    public string AdrhNip { get; set; } = null!;

    public string AdrhPoczta { get; set; } = null!;

    public string AdrhGmina { get; set; } = null!;

    public string AdrhPowiat { get; set; } = null!;

    public string AdrhSkrytka { get; set; } = null!;

    public string AdrhSymbol { get; set; } = null!;

    public int? AdrhIdGminy { get; set; }

    public int? AdrhIdWersja { get; set; }

    public int? AdrhIdZmienil { get; set; }

    public DateTime? AdrhDataZmiany { get; set; }

    public string? AdrhNrUrzeduSkarbowego { get; set; }

    public string AdrhNrEori { get; set; } = null!;

    public virtual AdrEwid AdrhIdAdresuNavigation { get; set; } = null!;

    public virtual ICollection<HbTransakcjaOczekujaca> HbTransakcjaOczekujacas { get; set; } = new List<HbTransakcjaOczekujaca>();

    public virtual ICollection<KhAdresyDostawy> KhAdresyDostawies { get; set; } = new List<KhAdresyDostawy>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();
}
