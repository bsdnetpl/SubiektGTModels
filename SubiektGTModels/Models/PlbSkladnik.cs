using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbSkladnik
{
    public int SpId { get; set; }

    public string SpNazwa { get; set; } = null!;

    public string SpNazwaNaWydruku { get; set; } = null!;

    public string SpOpis { get; set; } = null!;

    public bool SpAktywny { get; set; }

    public int SpTyp { get; set; }

    public int SpRodzaj { get; set; }

    public bool SpOpodatkowany { get; set; }

    public bool SpIgnorujDzienDatUmowy { get; set; }

    public int SpPlatnyPrzez { get; set; }

    public int SpCykl { get; set; }

    public bool SpDoPodstEmRe { get; set; }

    public bool SpDoPodstChWy { get; set; }

    public bool SpDoPodstZdr { get; set; }

    public bool SpDoKwotyChor { get; set; }

    public bool SpDoKwotyUrl { get; set; }

    public bool SpUwzglNadgodziny { get; set; }

    public bool SpUwzglNocne { get; set; }

    public bool SpDoPodstJub { get; set; }

    public bool SpPrawaAutorskie { get; set; }

    public int SpZmiennosc { get; set; }

    public bool SpWartoscZero { get; set; }

    public int? SpIdInstytucji { get; set; }

    public bool SpAutoPotracenie { get; set; }

    public bool SpNieNaliczacDodatekNadgodziny { get; set; }

    public bool SpUwzgledniajAtrybutyDniGodzin { get; set; }

    public int SpKwtyp { get; set; }

    public int? SpKwmpk { get; set; }

    public int? SpKwzlecenie { get; set; }

    public int SpKwwspolczynnik { get; set; }

    public bool SpNieUwzglZaswOwynagrodzeniu { get; set; }

    public bool SpZwolnienieZpodatku { get; set; }

    public bool SpNieOgrSklZdr { get; set; }

    public bool SpPorownajZeStawkaZaszeregowania { get; set; }

    public bool SpNieUwzglDoMinimalnej { get; set; }

    public bool SpNieUwzglWsprGus { get; set; }

    public bool SpZwolnienieZpodatkuDlaMlodych { get; set; }

    public bool SpUwzglWpodstPrzestoj { get; set; }

    public bool SpWylaczonyZpotKom { get; set; }

    public bool SpUlgaDlaKlasySredniej { get; set; }

    public virtual ICollection<ImSchematImportuPozDekretu> ImSchematImportuPozDekretus { get; set; } = new List<ImSchematImportuPozDekretu>();

    public virtual ICollection<KpKomornikPozyczkaDefinicja> KpKomornikPozyczkaDefinicjas { get; set; } = new List<KpKomornikPozyczkaDefinicja>();

    public virtual ICollection<PlbSkladnikAbsencja> PlbSkladnikAbsencjas { get; set; } = new List<PlbSkladnikAbsencja>();

    public virtual ICollection<PlbSkladnikDefinicja> PlbSkladnikDefinicjas { get; set; } = new List<PlbSkladnikDefinicja>();

    public virtual ICollection<PlbSzablonZpskladnik> PlbSzablonZpskladniks { get; set; } = new List<PlbSzablonZpskladnik>();

    public virtual ICollection<PlbUmowaSkladnik> PlbUmowaSkladniks { get; set; } = new List<PlbUmowaSkladnik>();

    public virtual ICollection<PlbWyplataSkladnik> PlbWyplataSkladniks { get; set; } = new List<PlbWyplataSkladnik>();

    public virtual IsInstytucja? SpIdInstytucjiNavigation { get; set; }

    public virtual StMpk? SpKwmpkNavigation { get; set; }

    public virtual ZlpZlecenie? SpKwzlecenieNavigation { get; set; }
}
