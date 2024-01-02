using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrRodzina
{
    public int ProId { get; set; }

    public int ProIdPracownika { get; set; }

    public string ProImie { get; set; } = null!;

    public string ProImie2 { get; set; } = null!;

    public string ProNazwisko { get; set; } = null!;

    public DateTime? ProDataUrodzenia { get; set; }

    public string? ProPokrewienstwo { get; set; }

    public string ProNip { get; set; } = null!;

    public string ProPesel { get; set; } = null!;

    public string? ProTypIdentyfikatora { get; set; }

    public string ProDtnr { get; set; } = null!;

    public bool ProNaUtrzymaniuPracownika { get; set; }

    public bool ProGospodarstwoZpracownikiem { get; set; }

    public bool ProZasilekRodzinny { get; set; }

    public bool ProZasilekPielegnacyjny { get; set; }

    public string? ProStopienNiepelnosprawnosci { get; set; }

    public bool ProUlgaNaWychowywanieDzieci { get; set; }

    public bool? ProBlizniak { get; set; }

    public DateTime? ProDataZakOjc { get; set; }

    public DateTime? ProDataZakRodz { get; set; }

    public DateTime? ProDataZakWych { get; set; }

    public int? ProPodstPrawnaRodz { get; set; }

    public int? ProPodstPrawnaWych { get; set; }

    public int ProTygWykorzystaneOjcowski { get; set; }

    public int ProTygWykorzystaneRodzicielski { get; set; }

    public int ProDniWykorzystaneRodzicielski { get; set; }

    public int ProMscWykorzystaneWychowawczy { get; set; }

    public int ProTygWykorzystaneWychowawczy { get; set; }

    public int ProDniWykorzystaneWychowawczy { get; set; }

    public int ProCzesciWykorzystaneOjcowski { get; set; }

    public int ProCzesciWykorzystaneRodzicielski { get; set; }

    public int ProCzesciWykorzystaneWychowawczy { get; set; }

    public virtual ICollection<EcpAbsencjaPrzedKorektum> EcpAbsencjaPrzedKorekta { get; set; } = new List<EcpAbsencjaPrzedKorektum>();

    public virtual ICollection<EcpAbsencja> EcpAbsencjas { get; set; } = new List<EcpAbsencja>();

    public virtual PrPracownik ProIdPracownikaNavigation { get; set; } = null!;
}
