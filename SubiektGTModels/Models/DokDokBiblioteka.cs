using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokDokBiblioteka
{
    public int DdkbId { get; set; }

    public int DdkbIdDokumentu { get; set; }

    public int DdkbIdKategorii { get; set; }

    public bool DdkbZablokowany { get; set; }

    public DateTime DdkbDataModyfikacji { get; set; }

    public string DdkbNazwa { get; set; } = null!;

    public string DdkbOpis { get; set; } = null!;

    public byte[] DdkbTresc { get; set; } = null!;

    public string DdkbTyp { get; set; } = null!;

    public int DdkbIdPersonelu { get; set; }

    public virtual DokDokument DdkbIdDokumentuNavigation { get; set; } = null!;

    public virtual SlKategoriaDokumentu DdkbIdKategoriiNavigation { get; set; } = null!;

    public virtual PdUzytkownik DdkbIdPersoneluNavigation { get; set; } = null!;
}
