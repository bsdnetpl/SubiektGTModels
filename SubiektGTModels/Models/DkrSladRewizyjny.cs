using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrSladRewizyjny
{
    public int SrwId { get; set; }

    public string SrwNrDokumentu { get; set; } = null!;

    public int SrwOperacja { get; set; }

    public DateTime SrwData { get; set; }

    public string SrwUzytkownik { get; set; } = null!;

    public int SrwIdRoku { get; set; }

    public DateTime SrwDataDekretacji { get; set; }

    public string SrwDokumentZrodlowy { get; set; } = null!;

    public string SrwRejestr { get; set; } = null!;

    public virtual PdRokObrotowy SrwIdRokuNavigation { get; set; } = null!;

    public virtual SlRejestrKsiegowy SrwRejestrNavigation { get; set; } = null!;

    public virtual PdUzytkownik SrwUzytkownikNavigation { get; set; } = null!;
}
