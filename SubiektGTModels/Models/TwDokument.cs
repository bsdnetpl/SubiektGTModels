using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwDokument
{
    public int TdkId { get; set; }

    public int TdkIdTowaru { get; set; }

    public int TdkIdKategorii { get; set; }

    public bool TdkZablokowany { get; set; }

    public DateTime TdkDataModyfikacji { get; set; }

    public string TdkNazwa { get; set; } = null!;

    public string TdkOpis { get; set; } = null!;

    public byte[] TdkTresc { get; set; } = null!;

    public string TdkTyp { get; set; } = null!;

    public int TdkIdPersonelu { get; set; }

    public virtual SlKategoriaDokumentu TdkIdKategoriiNavigation { get; set; } = null!;

    public virtual PdUzytkownik TdkIdPersoneluNavigation { get; set; } = null!;

    public virtual TwTowar TdkIdTowaruNavigation { get; set; } = null!;
}
