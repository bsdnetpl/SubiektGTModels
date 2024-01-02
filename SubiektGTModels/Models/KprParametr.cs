using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KprParametr
{
    public int KprpId { get; set; }

    public int? KprpIdKategoriiPrz { get; set; }

    public int? KprpIdKategoriiZak { get; set; }

    public int? KprpIdKategoriiSn { get; set; }

    public bool KprpPrzepisywanieDtZdarzenia { get; set; }

    public bool KprpPrzepisywanieKategorii { get; set; }

    public bool KprpPrzepisywanieOpisu { get; set; }

    public bool KprpPrzepisywanieKh { get; set; }

    public bool KprpKontrolaUniqNrDokumentu { get; set; }

    public bool KprpPrzepisywanieVat { get; set; }

    public int KprpWersjaKpiR { get; set; }

    public int KprpWersjaKpiRinfo { get; set; }

    public bool KprpPrzepisywanieDtZdarzeniaGospodarczego { get; set; }

    public bool KprpKosztyUzupelnianieDblClck { get; set; }

    public bool KprpPrzepisywanieKorektyKup { get; set; }

    public bool KprpKorygowanieKup { get; set; }

    public bool KprpPrzepisywanieDatyZaplaty { get; set; }

    public bool KprpBrakKontrahenta { get; set; }

    public bool KprpKupmsgBox { get; set; }

    public int? KprpDomyslnaStawkaVatprzychod { get; set; }

    public int? KprpDomyslnaStawkaVatwydatek { get; set; }

    public bool KprpPrzepisywaniePrzypadek { get; set; }

    public bool KprpPrzepisywanieStawkaVat { get; set; }

    public bool KprpPrzepisywanieTypOpisuBr { get; set; }

    public bool KprpPrzepisywanieOpisBr { get; set; }

    public bool KprpPrzepisywanieVatOss { get; set; }

    public bool KprpPrzepisywaniePanstwoKonsumpcji { get; set; }

    public bool KprpPrzepisywanieStawkaVatOss { get; set; }

    public bool KprpUkryjVatoss { get; set; }

    public bool KprpInfoSklUbezpKsiegZaliczka { get; set; }

    public virtual SlKategorium? KprpIdKategoriiPrzNavigation { get; set; }

    public virtual SlKategorium? KprpIdKategoriiSnNavigation { get; set; }

    public virtual SlKategorium? KprpIdKategoriiZakNavigation { get; set; }
}
