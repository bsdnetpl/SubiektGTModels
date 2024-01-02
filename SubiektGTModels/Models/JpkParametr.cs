using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class JpkParametr
{
    public int JprId { get; set; }

    public int JprEmailZrodlo { get; set; }

    public string JprEmail { get; set; } = null!;

    public bool JprPusteSprzedaz { get; set; }

    public bool JprPusteZakup { get; set; }

    public int JprImportKh { get; set; }

    public int JprUzupelnianieKh { get; set; }

    public byte[]? JprParametryDomyslneRejVat { get; set; }

    public int JprPodpisJpkVat { get; set; }

    public int JprPodpisJpkInne { get; set; }

    public int JprTelefonZrodlo { get; set; }

    public string JprTelefon { get; set; } = null!;

    public bool JprPeselJakoNrKontrahenta { get; set; }

    public bool JprCzyPobieracKwotyZapisowZeStawkaZwDlaVatZakupu { get; set; }

    public bool JprCzyPobieracKwotyZapisowZeStawka0DlaVatZakupu { get; set; }
}
