using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class OssParametr
{
    public int OsspId { get; set; }

    public int? OsspParamEwidId { get; set; }

    public int OsspKsKolumna { get; set; }

    public int OsspKsDataWpisu { get; set; }

    public int OsspKsDataZdGosp { get; set; }

    public bool OsspKsWgParam { get; set; }

    public bool OsspPrzepisywanieKh { get; set; }

    public bool OsspPrzepisywanieOpisu { get; set; }

    public bool OsspPrzepisywanieKategorii { get; set; }

    public bool OsspPrzepisywaniePanstwaKonsumpcji { get; set; }

    public bool OsspPrzepisywaniePanstwaRozpWysylki { get; set; }

    public bool OsspPrzepisywanieInformacjiDodatkowych { get; set; }

    public bool OsspPrzepisywanieTransakcjiVat { get; set; }

    public bool OsspPrzepisywanieWalutyDokumentu { get; set; }

    public bool OsspPrzepisywanieDatyWystawienia { get; set; }

    public bool OsspPrzepisywanieDatyZakDostawy { get; set; }

    public bool OsspPrzepisywanieMiesiacaNaliczenia { get; set; }

    public bool OsspPrzepisywanieTerminuPlatnosci { get; set; }

    public bool OsspKontrolaUniqNrDokumentu { get; set; }

    public bool OsspOstrzegajBrakKontrahentaWkartotece { get; set; }

    public bool OsspOstrzegajBrakKontrahentaNaDokumencie { get; set; }

    public bool OsspPrzeniesienieDatyWystawienia { get; set; }

    public bool OsspPrzeniesienieWartosciBrutto { get; set; }

    public bool OsspUzupelnienieDatyZaplaty { get; set; }

    public int OsspDataZaplatyWgPola { get; set; }

    public bool OsspPrzepisywanieEwidVat { get; set; }

    public virtual ParEwid? OsspParamEwid { get; set; }
}
