using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrkartaWynagrodzenAdresGmina
{
    public int AdresId { get; set; }

    public int AdresIdobiektu { get; set; }

    public int AdresTyp { get; set; }

    public string AdresKodMiejscowosc { get; set; } = null!;

    public string? Gmina { get; set; }
}
