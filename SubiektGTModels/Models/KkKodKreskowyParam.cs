using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KkKodKreskowyParam
{
    public int KkpkId { get; set; }

    public bool KkpkKodyZmienne { get; set; }

    public string? KkpkPrefix { get; set; }

    public string? KkpkSuffix { get; set; }

    public bool KkpkUsunPoczatkoweZera { get; set; }

    public bool KkpkDodatkowaCyfraKontrolna { get; set; }

    public int KkpkParamEwidId { get; set; }

    public virtual ParEwid KkpkParamEwid { get; set; } = null!;
}
