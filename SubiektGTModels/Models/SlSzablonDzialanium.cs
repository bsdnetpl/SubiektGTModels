using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlSzablonDzialanium
{
    public int SzdzId { get; set; }

    public int SzdzDzialanieRodzaj { get; set; }

    public string SzdzNazwaSzablonu { get; set; } = null!;

    public string SzdzNazwa { get; set; } = null!;

    public int? SzdzStatus { get; set; }

    public int? SzdzPodtyp { get; set; }

    public int SzdzPersonel { get; set; }

    public bool SzdzCalyDzien { get; set; }

    public int SzdzPoczatek { get; set; }

    public int SzdzCzasTrwania { get; set; }

    public string SzdzLokalizacja { get; set; } = null!;

    public int SzdzPriorytet { get; set; }

    public string SzdzKolor { get; set; } = null!;

    public bool SzdzPokazujWkalendarzu { get; set; }

    public int? SzdzRezultat { get; set; }

    public int? SzdzKierunek { get; set; }

    public int SzdzKiedyPrzypomnienie { get; set; }

    public bool SzdzBezCzasu { get; set; }

    public string SzdzUwagi { get; set; } = null!;

    public bool SzdzPrywatne { get; set; }

    public int SzdzKlasa { get; set; }

    public int SzdzFormaDzialaniaWindykacyjnego { get; set; }

    public string SzdzOpis { get; set; } = null!;

    public bool SzdzPredefiniowany { get; set; }

    public virtual SlCrmpodTypZadanium? SzdzPodtypNavigation { get; set; }

    public virtual ICollection<TwParametr> TwParametrTwpSzablonDzialanieDodajNavigations { get; set; } = new List<TwParametr>();

    public virtual ICollection<TwParametr> TwParametrTwpSzablonDzialanieEdycjaNavigations { get; set; } = new List<TwParametr>();

    public virtual ICollection<WindParametr> WindParametrWpaSzablonDzialanieNavigations { get; set; } = new List<WindParametr>();

    public virtual ICollection<WindParametr> WindParametrWpaSzablonNotaNavigations { get; set; } = new List<WindParametr>();
}
