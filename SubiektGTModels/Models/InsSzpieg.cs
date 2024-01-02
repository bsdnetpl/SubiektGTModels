using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class InsSzpieg
{
    public int InssId { get; set; }

    public int InssTypObiektu { get; set; }

    public int InssTypObiektuEx { get; set; }

    public int InssIdObiektu { get; set; }

    public string? InssNazwaObiektu { get; set; }

    public int InssTypOperacji { get; set; }

    public DateTime InssCzasOperacji { get; set; }

    public int InssIdUzytkownika { get; set; }

    public string InssUzytkownik { get; set; } = null!;

    public int? InssPoziomUprawnienIdUzytkownika { get; set; }

    public string? InssPoziomUprawnienUzytkownik { get; set; }

    public string InssStanowisko { get; set; } = null!;

    public string InssObiektXml { get; set; } = null!;
}
