using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwpSlSlownik
{
    public int SlId { get; set; }

    public string SlNazwa { get; set; } = null!;

    public string SlOpis { get; set; } = null!;

    public int SlProgramy { get; set; }

    public int SlStatusNowosci { get; set; }

    public bool SlUkryte { get; set; }
}
