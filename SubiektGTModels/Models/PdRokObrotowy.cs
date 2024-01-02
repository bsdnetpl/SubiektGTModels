using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdRokObrotowy
{
    public int RobrId { get; set; }

    public string RobrSymbol { get; set; } = null!;

    public DateTime RobrDataOd { get; set; }

    public DateTime RobrDataDo { get; set; }

    public int RobrWariantRzs { get; set; }

    public int RobrWariantPp { get; set; }

    public bool RobrZamkniety { get; set; }

    public int RobrPlatnoscCit { get; set; }

    public int RobrIdObiektu { get; set; }

    public int? RobrIdZamykajacego { get; set; }

    public DateTime? RobrDataZamkniecia { get; set; }

    public int RobrZpikNumeracja { get; set; }

    public int RobrZpikNumeracjaStart { get; set; }

    public bool RobrStosujCitulgowy { get; set; }

    public bool RobrZaliczkaPonizejTys { get; set; }

    public bool RobrSpKomandCitOdMaja { get; set; }

    public int RobrZrodloSprawozdaniaPorownywanego { get; set; }

    public int RobrSposobRozliczaniaCit { get; set; }

    public virtual ICollection<DkrAutomat> DkrAutomats { get; set; } = new List<DkrAutomat>();

    public virtual ICollection<DkrBilansOtwarcium> DkrBilansOtwarcia { get; set; } = new List<DkrBilansOtwarcium>();

    public virtual ICollection<DkrDokument> DkrDokuments { get; set; } = new List<DkrDokument>();

    public virtual DkrParametrDziennika? DkrParametrDziennika { get; set; }

    public virtual ICollection<DkrPozycja> DkrPozycjas { get; set; } = new List<DkrPozycja>();

    public virtual ICollection<DkrRoznicaKursowa> DkrRoznicaKursowas { get; set; } = new List<DkrRoznicaKursowa>();

    public virtual ICollection<DkrSladRewizyjny> DkrSladRewizyjnies { get; set; } = new List<DkrSladRewizyjny>();

    public virtual NrParametrDkr? NrParametrDkr { get; set; }

    public virtual ICollection<PdUzytkRok> PdUzytkRoks { get; set; } = new List<PdUzytkRok>();

    public virtual ICollection<PkKlasyfikacjaKont> PkKlasyfikacjaKonts { get; set; } = new List<PkKlasyfikacjaKont>();

    public virtual PkParametry? PkParametry { get; set; }

    public virtual ICollection<PkPlanKont> PkPlanKonts { get; set; } = new List<PkPlanKont>();

    public virtual PdUzytkownik? RobrIdZamykajacegoNavigation { get; set; }

    public virtual SfSprawozdanie RobrWariantPpNavigation { get; set; } = null!;

    public virtual SfSprawozdanie RobrWariantRzsNavigation { get; set; } = null!;

    public virtual ICollection<SfDefinicja> SfDefinicjas { get; set; } = new List<SfDefinicja>();

    public virtual ICollection<SfRz> SfRzs { get; set; } = new List<SfRz>();

    public virtual ICollection<SfSprawozdanie> SfsnIdSprawozdania { get; set; } = new List<SfSprawozdanie>();
}
