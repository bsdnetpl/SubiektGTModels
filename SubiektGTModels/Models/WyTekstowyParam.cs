using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyTekstowyParam
{
    public int WtxId { get; set; }

    public string WtxNazwaKomputera { get; set; } = null!;

    public string WtxPort { get; set; } = null!;

    public int WtxStronaKodowa { get; set; }

    public int WtxLiczbaLinii { get; set; }

    public int WtxKodSterujacyId { get; set; }

    public int WtxCpi { get; set; }

    public bool WtxNlq { get; set; }

    public bool WtxDrukujLinie { get; set; }

    public bool WtxZezwalajTylkoTekstowe { get; set; }
}
