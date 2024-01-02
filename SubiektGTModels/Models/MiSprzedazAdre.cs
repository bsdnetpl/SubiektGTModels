using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MiSprzedazAdre
{
    public int MiaId { get; set; }

    public string MiaNazwa { get; set; } = null!;

    public string MiaUlica { get; set; } = null!;

    public string MiaKodPocztowy { get; set; } = null!;

    public string MiaMiejscowosc { get; set; } = null!;

    public string MiaPanstwo { get; set; } = null!;

    public virtual ICollection<MiSprzedaz> MiSprzedazMisDokPapierowyIdAdresuNavigations { get; set; } = new List<MiSprzedaz>();

    public virtual ICollection<MiSprzedaz> MiSprzedazMisKhIdAdresuNavigations { get; set; } = new List<MiSprzedaz>();
}
