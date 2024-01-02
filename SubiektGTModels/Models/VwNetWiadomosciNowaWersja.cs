using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwNetWiadomosciNowaWersja
{
    public int NewId { get; set; }

    public int NewZrodloTyp { get; set; }

    public string NewZrodloNip { get; set; } = null!;

    public string NewZrodloUzytkownik { get; set; } = null!;

    public string NewAdresaci { get; set; } = null!;

    public int NewTyp { get; set; }

    public string NewTytul { get; set; } = null!;

    public string NewTresc { get; set; } = null!;

    public DateTime? NewData { get; set; }

    public bool? Przeczytana { get; set; }

    public bool? OdczytanaWstarejWersji { get; set; }

    public DateTime? NefDataPrzypomnienia { get; set; }

    public bool? NefPobrano { get; set; }
}
