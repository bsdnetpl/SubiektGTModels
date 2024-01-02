using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlUmowaOprace
{
    public int UpId { get; set; }

    public int UpIdPracownika { get; set; }

    public string UpNumer { get; set; } = null!;

    public int UpRodzaj { get; set; }

    public DateTime UpDataOd { get; set; }

    public DateTime? UpDataDo { get; set; }

    public DateTime? UpDataRozwiazania { get; set; }

    public string UpPowodRozwiazania { get; set; } = null!;

    public string UpTytulUbezp { get; set; } = null!;

    public int UpGenerowanyRaport { get; set; }

    public int UpKosztyUzyskania { get; set; }

    public int UpPrzelewNaKonto { get; set; }

    public decimal UpPrzelewKwota { get; set; }

    public bool UpCzyOdliczacUlge { get; set; }

    public bool UpCzyNaliczacPodatek { get; set; }

    public string UpTresc { get; set; } = null!;

    public bool UpRozwiazana { get; set; }

    public int UpEtatLicznik { get; set; }

    public int UpEtatMianownik { get; set; }

    public bool UpCzyNaliczacFgsp { get; set; }

    public bool UpCzyNaliczacFp { get; set; }

    public bool UpCzyNaliczacUlgeDlaKlasySredniej { get; set; }

    public bool UpCzyOdraczacPoborZaliczki { get; set; }

    public int UpWymiarUlgiPodatkowej { get; set; }

    public virtual ICollection<PlUmowaOpraceSkladnik> PlUmowaOpraceSkladniks { get; set; } = new List<PlUmowaOpraceSkladnik>();

    public virtual ICollection<PlWyplatum> PlWyplata { get; set; } = new List<PlWyplatum>();

    public virtual PrPracownik UpIdPracownikaNavigation { get; set; } = null!;

    public virtual SlTytulUbezpieczenium UpTytulUbezpNavigation { get; set; } = null!;
}
