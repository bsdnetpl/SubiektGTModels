using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhDokument
{
    public int KdkId { get; set; }

    public int KdkIdKontrahenta { get; set; }

    public int KdkIdKategorii { get; set; }

    public bool KdkZablokowany { get; set; }

    public DateTime KdkDataModyfikacji { get; set; }

    public string KdkNazwa { get; set; } = null!;

    public string KdkOpis { get; set; } = null!;

    public byte[] KdkTresc { get; set; } = null!;

    public string KdkTyp { get; set; } = null!;

    public int KdkIdPersonelu { get; set; }

    public virtual SlKategoriaDokumentu KdkIdKategoriiNavigation { get; set; } = null!;

    public virtual KhKontrahent KdkIdKontrahentaNavigation { get; set; } = null!;

    public virtual PdUzytkownik KdkIdPersoneluNavigation { get; set; } = null!;
}
