using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdDokument
{
    public int PdkId { get; set; }

    public int PdkIdPodmiotu { get; set; }

    public int PdkIdKategorii { get; set; }

    public bool PdkZablokowany { get; set; }

    public DateTime PdkDataModyfikacji { get; set; }

    public string PdkNazwa { get; set; } = null!;

    public string PdkOpis { get; set; } = null!;

    public byte[] PdkTresc { get; set; } = null!;

    public string PdkTyp { get; set; } = null!;

    public int PdkIdPersonelu { get; set; }

    public virtual SlKategoriaDokumentu PdkIdKategoriiNavigation { get; set; } = null!;

    public virtual PdUzytkownik PdkIdPersoneluNavigation { get; set; } = null!;

    public virtual PdPodmiot PdkIdPodmiotuNavigation { get; set; } = null!;
}
