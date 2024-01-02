using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrzParametr
{
    public int PrzpId { get; set; }

    public int? PrzpIdKategoriiPrz { get; set; }

    public int? PrzpIdKategoriiSn { get; set; }

    public bool PrzpPrzepisywanieDtZapisu { get; set; }

    public bool PrzpPrzepisywanieDtZdarzenia { get; set; }

    public bool PrzpPrzepisywanieKategorii { get; set; }

    public bool PrzpPrzepisywanieOpisu { get; set; }

    public bool PrzpPrzepisywanieKh { get; set; }

    public bool PrzpKontrolaUniqNrDokumentu { get; set; }

    public bool PrzpPrzepisywanieVat { get; set; }

    public bool PrzpBrakKontrahenta { get; set; }

    public int? PrzpDomyslnaStawkaVat { get; set; }

    public bool PrzpPrzepisywanieStawkaVat { get; set; }

    public bool PrzpPrzepisywanieVatOss { get; set; }

    public bool PrzpPrzepisywaniePanstwoKonsumpcji { get; set; }

    public bool PrzpPrzepisywanieStawkaVatOss { get; set; }

    public bool PrzpUkryjVatoss { get; set; }

    public int PrzpStawkiNaWydruku { get; set; }

    public virtual SlKategorium? PrzpIdKategoriiPrzNavigation { get; set; }

    public virtual SlKategorium? PrzpIdKategoriiSnNavigation { get; set; }
}
