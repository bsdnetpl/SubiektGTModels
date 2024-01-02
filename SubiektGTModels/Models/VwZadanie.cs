using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZadanie
{
    public int ZdId { get; set; }

    public int ZdRodzaj { get; set; }

    public bool ZdCalyDzien { get; set; }

    public DateTime? VwPoczatek { get; set; }

    public DateTime ZdPoczatek { get; set; }

    public DateTime? ZdKoniec { get; set; }

    public string? ZdLokalizacja { get; set; }

    public string ZdTemat { get; set; } = null!;

    public int ZdPriorytet { get; set; }

    public string ZdKolor { get; set; } = null!;

    public int ZdInterwal { get; set; }

    public int ZdCoIle { get; set; }

    public bool ZdRobocze { get; set; }

    public int ZdDniTygodnia { get; set; }

    public int ZdDzienMiesiaca { get; set; }

    public bool? ZdDefinicjaZlozona { get; set; }

    public int ZdDzienPorzadek { get; set; }

    public int ZdDzienRodzaj { get; set; }

    public int ZdMiesiac { get; set; }

    public int ZdRodzajPowtorzen { get; set; }

    public int ZdIlePowtorzen { get; set; }

    public DateTime? ZdKoniecPowtorzen { get; set; }

    public int ZdCykliczne { get; set; }

    public int? ZdRezultat { get; set; }

    public bool? ZdPokazujWkalendarzu { get; set; }

    public int? ZdvwStatus { get; set; }

    public int? ZdKierunek { get; set; }

    public int? ZdPersonel { get; set; }

    public string? AdrNazwa { get; set; }

    public string? PtzNazwa { get; set; }

    public int? ZdPodtyp { get; set; }

    public bool ZdBezCzasu { get; set; }

    public bool ZdPrzypomniane { get; set; }

    public DateTime? ZdNastepnePrzypomnienie { get; set; }

    public string? ZdUczestnicy { get; set; }

    public bool ZdPrywatne { get; set; }

    public int? ZdPozostalo { get; set; }

    public int? ZdTransakcja { get; set; }

    public string? TrNazwa { get; set; }

    public string? TrSymbol { get; set; }

    public string ZdUwagi { get; set; } = null!;

    public int ZdKlasa { get; set; }

    public int ZdFormaDzialaniaWindykacyjnego { get; set; }

    public DateTime? ZdWystapienieDoPrzypomnienia { get; set; }

    public int JestDokumentWzorcowy { get; set; }

    public int JestDokumentWystawiony { get; set; }

    public int ZdLiczbaUczestnikowWszystkich { get; set; }

    public int ZdLiczbaUczestnikowBezPersonelu { get; set; }

    public int ZdvwNotatkaZakonczona { get; set; }
}
