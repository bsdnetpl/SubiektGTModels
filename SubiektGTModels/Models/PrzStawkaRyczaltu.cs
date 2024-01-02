using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrzStawkaRyczaltu
{
    public int StrId { get; set; }

    public string StrNazwa { get; set; } = null!;

    public decimal StrWartosc { get; set; }

    public bool StrSystemowa { get; set; }

    public bool StrAktywna { get; set; }

    public int StrPozycja { get; set; }

    public bool StrSpecjalna10 { get; set; }

    public virtual ICollection<PrzDanePrzychodu> PrzDanePrzychodus { get; set; } = new List<PrzDanePrzychodu>();
}
