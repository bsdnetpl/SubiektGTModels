using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZpkKsiega
{
    public int ZpkId { get; set; }

    public int ZpkIdRoku { get; set; }

    public DateTime ZpkDataZdarzenia { get; set; }

    public int ZpkRodzaj { get; set; }

    public bool ZpkUniewazniony { get; set; }

    public int ZpkTypObiektu { get; set; }

    public int? ZpkIdObiektu { get; set; }

    public bool ZpkImportowany { get; set; }

    public DateTime ZpkDataZdarzeniaGospodarczego { get; set; }

    public string ZpkNrDokumentu { get; set; } = null!;

    public int? ZpkKhId { get; set; }

    public string ZpkKhSymbol { get; set; } = null!;

    public string ZpkKhNazwa { get; set; } = null!;

    public string ZpkKhNazwaPelna { get; set; } = null!;

    public string ZpkKhUlica { get; set; } = null!;

    public string ZpkKhMiasto { get; set; } = null!;

    public string ZpkKhKodPocztowy { get; set; } = null!;

    public string ZpkKhNip { get; set; } = null!;

    public string ZpkOpis { get; set; } = null!;

    public decimal ZpkPrzychodDzialNieodpl { get; set; }

    public decimal ZpkPrzychodSpTowIusl { get; set; }

    public decimal ZpkPrzychodPozostale { get; set; }

    public decimal? ZpkPrzychodRazem { get; set; }

    public decimal ZpkKosztyUp { get; set; }

    public decimal ZpkKosztyPozostale { get; set; }

    public string ZpkUwagi { get; set; } = null!;

    public int? ZpkKategoriaId { get; set; }

    public bool ZpkBilansOtwarcia { get; set; }

    public bool ZpkDochodWolny { get; set; }

    public int ZpkPrzychodRodzaj { get; set; }

    public bool ZpkWydDochZwol { get; set; }

    public bool ZpkWydDochZwolLataUb { get; set; }

    public int? ZpkIdDokImport { get; set; }

    public int? ZpkTypDokImport { get; set; }

    public int ZpkImportPochodzenie { get; set; }

    public bool ZpkKorektaSn { get; set; }

    public string? ZpkNumerKseF { get; set; }

    public virtual SlKategorium? ZpkKategoria { get; set; }

    public virtual KhKontrahent? ZpkKh { get; set; }
}
