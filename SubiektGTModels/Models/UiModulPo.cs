using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiModulPo
{
    public int UiposId { get; set; }

    public int UiposModulId { get; set; }

    public int UiposTyp { get; set; }

    public int UiposPodtyp { get; set; }

    public int? UiposDefiniowalnyId { get; set; }

    public bool UiposDomyslnyWidok { get; set; }

    public int UiposDomyslnaAkcjaTw { get; set; }

    public bool? UiposKlawiaturaSystemowa { get; set; }

    public int UiposBrakTowaruAkcja { get; set; }

    public bool UiposPrzyciskiPlatnosci { get; set; }

    public int UiposKlasyfikatorId { get; set; }

    public int? UiposWezelStartowyId { get; set; }

    public bool? UiposResetujKlasyfikator { get; set; }

    public int UiposRozmiarKafelkow { get; set; }

    public bool UiposPokazujMiniaturke { get; set; }

    public bool? UiposObszarRoboczy { get; set; }

    public bool UiposOznaczajBrakujacePozycje { get; set; }

    public virtual ICollection<UiModulPoszakladka> UiModulPoszakladkas { get; set; } = new List<UiModulPoszakladka>();

    public virtual UiModul UiposModul { get; set; } = null!;
}
