using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FlWartosc
{
    public int FlwIdGrupyFlag { get; set; }

    public int FlwTypObiektu { get; set; }

    public int FlwIdObiektu { get; set; }

    public int? FlwIdFlagi { get; set; }

    public string FlwKomentarz { get; set; } = null!;

    public int FlwIdUzytkownika { get; set; }

    public DateTime FlwCzasOstatniejZmiany { get; set; }

    public virtual FlFlagi? FlwIdFlagiNavigation { get; set; }

    public virtual FlGrupy FlwIdGrupyFlagNavigation { get; set; } = null!;

    public virtual PdUzytkownik FlwIdUzytkownikaNavigation { get; set; } = null!;
}
