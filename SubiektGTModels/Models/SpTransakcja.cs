using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SpTransakcja
{
    public int SptId { get; set; }

    public int SptIdPliku { get; set; }

    public DateTime? SptData { get; set; }

    public int SptStatus { get; set; }

    public decimal SptKwota { get; set; }

    public decimal SptProwizja { get; set; }

    public int? SptIdNaleznosci { get; set; }

    public string SptTransId { get; set; } = null!;

    public string? SptOpis { get; set; }

    public virtual NzFinanse? SptIdNaleznosciNavigation { get; set; }

    public virtual SpPlik SptIdPlikuNavigation { get; set; } = null!;
}
