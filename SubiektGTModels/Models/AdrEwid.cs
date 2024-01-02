using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class AdrEwid
{
    public int AdrId { get; set; }

    public int AdrIdObiektu { get; set; }

    public int AdrTypAdresu { get; set; }

    public string AdrNazwa { get; set; } = null!;

    public string AdrNazwaPelna { get; set; } = null!;

    public string AdrTelefon { get; set; } = null!;

    public string AdrFaks { get; set; } = null!;

    public string AdrUlica { get; set; } = null!;

    public string AdrNrDomu { get; set; } = null!;

    public string AdrNrLokalu { get; set; } = null!;

    public string AdrAdres { get; set; } = null!;

    public string AdrKod { get; set; } = null!;

    public string AdrMiejscowosc { get; set; } = null!;

    public int? AdrIdWojewodztwo { get; set; }

    public int? AdrIdPanstwo { get; set; }

    public string AdrNip { get; set; } = null!;

    public string AdrPoczta { get; set; } = null!;

    public string AdrGmina { get; set; } = null!;

    public string AdrPowiat { get; set; } = null!;

    public string AdrSkrytka { get; set; } = null!;

    public string AdrSymbol { get; set; } = null!;

    public int? AdrIdGminy { get; set; }

    public int? AdrIdWersja { get; set; }

    public int? AdrIdZmienil { get; set; }

    public DateTime? AdrDataZmiany { get; set; }

    public string? AdrNrUrzeduSkarbowego { get; set; }

    public string AdrNrEori { get; set; } = null!;

    public virtual ICollection<AdrEmail> AdrEmails { get; set; } = new List<AdrEmail>();

    public virtual ICollection<AdrHistorium> AdrHistoria { get; set; } = new List<AdrHistorium>();

    public virtual SlPanstwo? AdrIdPanstwoNavigation { get; set; }

    public virtual SlWojewodztwo? AdrIdWojewodztwoNavigation { get; set; }

    public virtual ICollection<HbTransakcjaOczekujaca> HbTransakcjaOczekujacas { get; set; } = new List<HbTransakcjaOczekujaca>();

    public virtual ICollection<KhListaKh> KhListaKhs { get; set; } = new List<KhListaKh>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual ICollection<TelEwid> TelEwids { get; set; } = new List<TelEwid>();

    public virtual ICollection<ZdUczestnik> ZdUczestniks { get; set; } = new List<ZdUczestnik>();

    public virtual ICollection<ZdZadanie> ZdZadanies { get; set; } = new List<ZdZadanie>();

    public virtual ICollection<ZsRezerwacjaUczestnik> ZsRezerwacjaUczestniks { get; set; } = new List<ZsRezerwacjaUczestnik>();
}
