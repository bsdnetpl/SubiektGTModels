using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EsSprawozdanieFinElement
{
    public int SfeId { get; set; }

    public int SfeIdNaglowka { get; set; }

    public int SfeIdWersja { get; set; }

    public int SfeRodzaj { get; set; }

    public int? SfeIdSprawozdania { get; set; }

    public byte[]? SfeXml { get; set; }

    public bool SfeZatwierdzony { get; set; }

    public virtual EsSprawozdanieFinNaglowek SfeIdNaglowkaNavigation { get; set; } = null!;
}
