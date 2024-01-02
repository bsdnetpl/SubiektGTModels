using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SvsdParametr
{
    public int SsdId { get; set; }

    public int SsdWydaniaMagazynowe { get; set; }

    public int SsdSprzedazDetaliczna { get; set; }

    public int SsdPrzyjeciaMagazynowe { get; set; }

    public int SsdZamowieniaKlienta { get; set; }

    public int SsdFakturySprzedazy { get; set; }

    public int SsdFakturyZakupu { get; set; }

    public int SsdWydaniaOdbiorcy { get; set; }

    public int SsdPrzyjeciaDostawcy { get; set; }
}
