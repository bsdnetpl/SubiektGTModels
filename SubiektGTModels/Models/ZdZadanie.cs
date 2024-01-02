using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdZadanie
{
    public int ZdId { get; set; }

    public int? ZdIdZrodla { get; set; }

    public int ZdRodzaj { get; set; }

    public int? ZdPodtyp { get; set; }

    public int? ZdPersonel { get; set; }

    public bool ZdCalyDzien { get; set; }

    public DateTime ZdPoczatek { get; set; }

    public DateTime? ZdKoniec { get; set; }

    public DateTime? ZdPoczatekZcyklu { get; set; }

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

    public int? ZdStatus { get; set; }

    public int? ZdRezultat { get; set; }

    public bool? ZdPokazujWkalendarzu { get; set; }

    public int? ZdKierunek { get; set; }

    public int? ZdKiedyPrzypomnienie { get; set; }

    public string? ZdOpisPowtorzen { get; set; }

    public bool ZdBezCzasu { get; set; }

    public DateTime? ZdNastepnePrzypomnienie { get; set; }

    public bool ZdPrzypomniane { get; set; }

    public string ZdUwagi { get; set; } = null!;

    public string ZdUczestnicy { get; set; } = null!;

    public bool ZdPrywatne { get; set; }

    public int? ZdTransakcja { get; set; }

    public int ZdFormaDzialaniaWindykacyjnego { get; set; }

    public int ZdKlasa { get; set; }

    public int? ZdNotaOdsetkowa { get; set; }

    public int? ZdWezwanieDoZaplaty { get; set; }

    public string? ZdDluznik { get; set; }

    public string? ZdLokalizacjaMapy { get; set; }

    public DateTime? ZdWystapienieDoPrzypomnienia { get; set; }

    public int? ZdDokumentId { get; set; }

    public string? ZdDokumentUwagi { get; set; }

    public bool ZdDokumentPrzepisuj { get; set; }

    public int? ZdWystawionyDokId { get; set; }

    public int? ZdZlecenieId { get; set; }

    public int ZdLiczbaUczestnikowBezPersonelu { get; set; }

    public int ZdLiczbaUczestnikowWszystkich { get; set; }

    public bool ZdKotwicz { get; set; }

    public bool ZdNotatkaZakonczona { get; set; }

    public virtual ICollection<ZdAlarmyRezerwacja> ZdAlarmyRezerwacjas { get; set; } = new List<ZdAlarmyRezerwacja>();

    public virtual DokDokument? ZdDokument { get; set; }

    public virtual NzFinanse? ZdNotaOdsetkowaNavigation { get; set; }

    public virtual ICollection<ZdOpi> ZdOpis { get; set; } = new List<ZdOpi>();

    public virtual AdrEwid? ZdPersonelNavigation { get; set; }

    public virtual ICollection<ZdRozrachunek> ZdRozrachuneks { get; set; } = new List<ZdRozrachunek>();

    public virtual ICollection<ZdUczestnik> ZdUczestniks { get; set; } = new List<ZdUczestnik>();

    public virtual ZwZdarzenieWindykacyjne? ZdWezwanieDoZaplatyNavigation { get; set; }
}
