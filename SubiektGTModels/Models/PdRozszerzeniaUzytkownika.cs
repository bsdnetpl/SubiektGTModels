using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdRozszerzeniaUzytkownika
{
    public Guid RuId { get; set; }

    public string? RuNazwa { get; set; }

    public string? RuOpis { get; set; }

    public string? RuWersjaZainstalowania { get; set; }

    public string? RuWersjaRozszerzenia { get; set; }

    public byte[]? RuSkryptPrzedKonwersja { get; set; }

    public byte[]? RuSkryptPoKonwersji { get; set; }
}
