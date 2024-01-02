using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrzPrzychod
{
    public int PrzId { get; set; }

    public string PrzNrDokumentu { get; set; } = null!;

    public DateTime PrzDataZapisu { get; set; }

    public DateTime PrzDataZdarzenia { get; set; }

    public int? PrzIdKh { get; set; }

    public string PrzNazwaKh { get; set; } = null!;

    public string PrzNazwaPelnaKh { get; set; } = null!;

    public string PrzUlicaKh { get; set; } = null!;

    public string PrzMiastoKh { get; set; } = null!;

    public string PrzKodPocztowyKh { get; set; } = null!;

    public string PrzNipkh { get; set; } = null!;

    public int PrzRodzaj { get; set; }

    public decimal PrzKwota { get; set; }

    public int PrzTypObiektu { get; set; }

    public int? PrzIdObiektu { get; set; }

    public string PrzUwagi { get; set; } = null!;

    public string PrzOpis { get; set; } = null!;

    public int? PrzIdKategorii { get; set; }

    public bool PrzKorektaSn { get; set; }

    public bool PrzImportowany { get; set; }

    public int? PrzIdDokImport { get; set; }

    public int? PrzTypDokImport { get; set; }

    public int PrzIdOkresu { get; set; }

    public int? PrzStawkaVat { get; set; }

    public string PrzSymbolKh { get; set; } = null!;

    public int? PrzIdPanstwaKonsumpcji { get; set; }

    public int? PrzStawkaVatOss { get; set; }

    public int? PrzIdObiektuVatOss { get; set; }

    public string? PrzNumerKseF { get; set; }

    public virtual ICollection<PrzDanePrzychodu> PrzDanePrzychodus { get; set; } = new List<PrzDanePrzychodu>();

    public virtual SlKategorium? PrzIdKategoriiNavigation { get; set; }

    public virtual KhKontrahent? PrzIdKhNavigation { get; set; }

    public virtual PdOkre PrzIdOkresuNavigation { get; set; } = null!;

    public virtual SlPanstwo? PrzIdPanstwaKonsumpcjiNavigation { get; set; }
}
