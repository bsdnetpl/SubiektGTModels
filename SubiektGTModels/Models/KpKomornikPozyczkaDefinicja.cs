using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KpKomornikPozyczkaDefinicja
{
    public int KpId { get; set; }

    public int KpIdPracownika { get; set; }

    public int KpIdSkladnika { get; set; }

    public string KpNazwa { get; set; } = null!;

    public string KpSygnaturaSprawy { get; set; } = null!;

    public int KpRodzaj { get; set; }

    public int KpSposobPotracania { get; set; }

    public decimal KpProcentWynagrodzeniaPotracany { get; set; }

    public decimal KpSumaPotracenia { get; set; }

    public DateTime KpDataOd { get; set; }

    public DateTime? KpDataDo { get; set; }

    public decimal KpKwotaPotraceniaMiesiecznego { get; set; }

    public decimal KpProcentOchronyWynagrodzenia { get; set; }

    public int KpCzestotliwoscPotracania { get; set; }

    public int KpPriorytetPotracenia { get; set; }

    public DateTime? KpZawieszenieDataOd { get; set; }

    public DateTime? KpZawieszenieDataDo { get; set; }

    public bool KpCzyNaSwiadectwiePracy { get; set; }

    public string KpKomornik { get; set; } = null!;

    public string KpPrzyczynaAnulowania { get; set; } = null!;

    public virtual PrPracownik KpIdPracownikaNavigation { get; set; } = null!;

    public virtual PlbSkladnik KpIdSkladnikaNavigation { get; set; } = null!;

    public virtual ICollection<KpPozycjaDefinicji> KpPozycjaDefinicjis { get; set; } = new List<KpPozycjaDefinicji>();
}
