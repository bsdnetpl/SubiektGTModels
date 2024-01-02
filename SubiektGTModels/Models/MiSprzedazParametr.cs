using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MiSprzedazParametr
{
    public int MispId { get; set; }

    public bool MispAutoPobieranie { get; set; }

    public int MispAutoPobieranieCzest { get; set; }

    public bool MispTworzKh { get; set; }

    public int MispTrybDopasowaniaKh { get; set; }

    public bool MispNieznaneJakoUj { get; set; }

    public int? MispIdMagazynZrodlowy { get; set; }

    public int MispTrybPlatnosci { get; set; }

    public int? MispIdKarta { get; set; }

    public int? MispIdTerminKredytu { get; set; }

    public int? MispIdKredyt { get; set; }

    public int? MispIdKatDokSprzedazy { get; set; }

    public bool? MispTworzDokPrzyjecia { get; set; }

    public int? MispIdKatDokPrzyjecia { get; set; }

    public int? MispIdDostawcyPrzyjecia { get; set; }

    public virtual ICollection<MiKhPomijany> MiKhPomijanies { get; set; } = new List<MiKhPomijany>();

    public virtual ICollection<MiMapaAsortyment> MiMapaAsortyments { get; set; } = new List<MiMapaAsortyment>();

    public virtual KhKontrahent? MispIdDostawcyPrzyjeciaNavigation { get; set; }

    public virtual SlKategorium? MispIdKatDokPrzyjeciaNavigation { get; set; }

    public virtual SlKategorium? MispIdKatDokSprzedazyNavigation { get; set; }

    public virtual SlMagazyn? MispIdMagazynZrodlowyNavigation { get; set; }
}
