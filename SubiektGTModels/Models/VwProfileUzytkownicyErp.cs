using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileUzytkownicyErp
{
    public int UzId { get; set; }

    public string? Grupa { get; set; }

    public string UzImie { get; set; } = null!;

    public string UzNazwisko { get; set; } = null!;

    public string UzIdentyfikator { get; set; } = null!;

    public bool UzStatus { get; set; }

    public string? Pracownik { get; set; }

    public bool UzPracaZdalna { get; set; }

    public string? UgNazwa { get; set; }

    public int UzProgram { get; set; }

    public int? UzIdGrupy { get; set; }

    public string? MagNazwa { get; set; }

    public string? KsNazwa { get; set; }

    public string? UiNazwa { get; set; }
}
