using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWzorzecSkladnikaPlacowego
{
    public int WspId { get; set; }

    public string WspNazwa { get; set; } = null!;

    public bool WspPodstOpodatkowania { get; set; }

    public bool WspPodstSklUbEmerRent { get; set; }

    public bool WspPodstSklUbChorWyp { get; set; }

    public bool WspPodstSklUbZdr { get; set; }

    public bool WspNaliczany { get; set; }

    public bool WspPlatnyPracodawca { get; set; }

    public int? WspPoleWyplaty { get; set; }

    public bool WspSystemowy { get; set; }

    public bool WspZwolnienieZpodatku { get; set; }

    public bool WspUlgaDlaKlasySredniej { get; set; }

    public virtual ICollection<PlUmowaOpraceSkladnik> PlUmowaOpraceSkladniks { get; set; } = new List<PlUmowaOpraceSkladnik>();

    public virtual ICollection<PlWyplataSkladnik> PlWyplataSkladniks { get; set; } = new List<PlWyplataSkladnik>();
}
