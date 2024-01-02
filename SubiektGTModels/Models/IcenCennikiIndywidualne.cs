using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IcenCennikiIndywidualne
{
    public int IcenId { get; set; }

    public bool IcenNieaktywny { get; set; }

    public string? IcenNazwa { get; set; }

    public string? IcenOpis { get; set; }

    public string? IcenUwagi { get; set; }

    public bool IcenCenaPoRabacie { get; set; }

    public string IcenWaluta { get; set; } = null!;

    public int IcenKursRodzaj { get; set; }

    public bool IcenKrytKhOperatorAnd { get; set; }

    public string? IcenKrytKhSqlQuery { get; set; }

    public DateTime? IcenOd { get; set; }

    public DateTime? IcenDo { get; set; }

    public bool IcenOgraniczonaCzasowo { get; set; }

    public int IcenInterwal { get; set; }

    public bool IcenCalyDzien { get; set; }

    public bool IcenRobocze { get; set; }

    public DateTime? IcenPoczatekZcyklu { get; set; }

    public int IcenCoIle { get; set; }

    public int IcenDniTygodnia { get; set; }

    public int IcenDzienMiesiaca { get; set; }

    public bool? IcenDefinicjaZlozona { get; set; }

    public int IcenDzienPorzadek { get; set; }

    public int IcenDzienRodzaj { get; set; }

    public int IcenMiesiac { get; set; }

    public int IcenRodzajPowtorzen { get; set; }

    public int IcenIlePowtorzen { get; set; }

    public DateTime? IcenKoniecPowtorzen { get; set; }

    public bool IcenIlePowtorzenWdniach { get; set; }

    public virtual ICollection<IcenCennikCechaKh> IcenCennikCechaKhs { get; set; } = new List<IcenCennikCechaKh>();

    public virtual ICollection<IcenCennikGrupaKh> IcenCennikGrupaKhs { get; set; } = new List<IcenCennikGrupaKh>();

    public virtual ICollection<IcenCennikKontrahent> IcenCennikKontrahents { get; set; } = new List<IcenCennikKontrahent>();

    public virtual ICollection<IcenCennikMagazyn> IcenCennikMagazyns { get; set; } = new List<IcenCennikMagazyn>();

    public virtual ICollection<IcenCennikTowar> IcenCennikTowars { get; set; } = new List<IcenCennikTowar>();
}
