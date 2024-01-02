using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlEwidVatOss
{
    public int EvoId { get; set; }

    public string EvoNazwa { get; set; } = null!;

    public string EvoOpis { get; set; } = null!;

    public int EvoTransakcjaVat { get; set; }

    public int? EvoIdPanstwaKonsumpcji { get; set; }

    public int? EvoIdPanstwaWysylki { get; set; }

    public string EvoWaluta { get; set; } = null!;

    public int? EvoIdKategorii { get; set; }

    public int EvoMiesiacNaliczenia { get; set; }

    public int? EvoIdTerminuPlatnosci { get; set; }

    public bool EvoNieWliczanyDoPb { get; set; }

    public bool EvoAutoPrzeliczajVat { get; set; }

    public bool EvoEwidencjaDomyslna { get; set; }

    public virtual SlKategorium? EvoIdKategoriiNavigation { get; set; }

    public virtual SlPanstwo? EvoIdPanstwaKonsumpcjiNavigation { get; set; }

    public virtual SlPanstwo? EvoIdPanstwaWysylkiNavigation { get; set; }

    public virtual SlFormaPlatnosci? EvoIdTerminuPlatnosciNavigation { get; set; }

    public virtual ICollection<ImSchematImportu> ImSchematImportus { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<OssEwid> OssEwids { get; set; } = new List<OssEwid>();

    public virtual ICollection<SlRejestrKsiegowy> SlRejestrKsiegowies { get; set; } = new List<SlRejestrKsiegowy>();
}
