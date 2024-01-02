using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfTransmisja
{
    public int UtrId { get; set; }

    public int UtrIdKonfiguracja { get; set; }

    public int UtrIdOperacja { get; set; }

    public string UtrOperacjaOpis { get; set; } = null!;

    public int UtrStatus { get; set; }

    public string UtrStatusOpis { get; set; } = null!;

    public DateTime UtrDataCzas { get; set; }

    public int UtrIdUzytkownik { get; set; }

    public string UtrKomputer { get; set; } = null!;

    public virtual ICollection<UfTransmisjaSzczegol> UfTransmisjaSzczegols { get; set; } = new List<UfTransmisjaSzczegol>();

    public virtual ICollection<UfZadanie> UfZadanies { get; set; } = new List<UfZadanie>();

    public virtual UfKonfiguracja UtrIdKonfiguracjaNavigation { get; set; } = null!;

    public virtual UfOperacja UtrIdOperacjaNavigation { get; set; } = null!;

    public virtual PdUzytkownik UtrIdUzytkownikNavigation { get; set; } = null!;
}
