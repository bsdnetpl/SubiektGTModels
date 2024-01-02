using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfKonfiguracja
{
    public int UkoId { get; set; }

    public int UkoIdUrzadzenie { get; set; }

    public string UkoNazwa { get; set; } = null!;

    public int? UkoIdMagazyn { get; set; }

    public bool UkoSiec { get; set; }

    public string UkoKomputer { get; set; } = null!;

    public string UkoMedium { get; set; } = null!;

    public byte[]? UkoBinarna { get; set; }

    public string UkoSkrotKlawiszowy { get; set; } = null!;

    public bool UkoOnLine { get; set; }

    public bool UkoUsunieta { get; set; }

    public string? UkoRemoteUser { get; set; }

    public string? UkoRemotePassword { get; set; }

    public string? UkoLocalUser { get; set; }

    public string? UkoLocalPassword { get; set; }

    public int? UkoOddzialId { get; set; }

    public bool UkoNiefiskalne { get; set; }

    public virtual ICollection<UfCena> UfCenas { get; set; } = new List<UfCena>();

    public virtual ICollection<UfDzialGrupa> UfDzialGrupas { get; set; } = new List<UfDzialGrupa>();

    public virtual ICollection<UfInne> UfInnes { get; set; } = new List<UfInne>();

    public virtual ICollection<UfJednostkaMiary> UfJednostkaMiaries { get; set; } = new List<UfJednostkaMiary>();

    public virtual ICollection<UfPlu> UfPlus { get; set; } = new List<UfPlu>();

    public virtual ICollection<UfTransmisja> UfTransmisjas { get; set; } = new List<UfTransmisja>();

    public virtual ICollection<UfVat> UfVats { get; set; } = new List<UfVat>();

    public virtual ICollection<UfZadanie> UfZadanies { get; set; } = new List<UfZadanie>();

    public virtual SlMagazyn? UkoIdMagazynNavigation { get; set; }

    public virtual UfUrzadzenie UkoIdUrzadzenieNavigation { get; set; } = null!;
}
