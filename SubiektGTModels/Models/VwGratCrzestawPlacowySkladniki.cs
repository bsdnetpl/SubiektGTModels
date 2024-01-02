using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrzestawPlacowySkladniki
{
    public int IdSkladnika { get; set; }

    public int IdZp { get; set; }

    public string Nazwa { get; set; } = null!;

    public int Typ { get; set; }

    public int Rodzaj { get; set; }

    public bool PodstawaEmeryturyRenty { get; set; }

    public bool PodstawaChorobowego { get; set; }

    public bool PodstawaZdrowotnego { get; set; }
}
