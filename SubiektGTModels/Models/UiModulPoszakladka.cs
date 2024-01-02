using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiModulPoszakladka
{
    public int UiposzId { get; set; }

    public int UiposzModulPosid { get; set; }

    public string UiposzNazwa { get; set; } = null!;

    public string UiposzTytul { get; set; } = null!;

    public string UiposzSql { get; set; } = null!;

    public int UiposzWidok { get; set; }

    public int UiposzKafelekSzablon { get; set; }

    public int UiposzKafelekRozmiar { get; set; }

    public bool UiposzMultiselekcja { get; set; }

    public virtual UiModulPo UiposzModulPos { get; set; } = null!;
}
