using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhPracownik
{
    public int PkId { get; set; }

    public int PkIdKh { get; set; }

    public string PkImie { get; set; } = null!;

    public string PkNazwisko { get; set; } = null!;

    public string PkEmail { get; set; } = null!;

    public string PkTelefon { get; set; } = null!;

    public string PkTelKomorka { get; set; } = null!;

    public bool PkPodstaw { get; set; }

    public string PkStanowisko { get; set; } = null!;

    public bool PkZablokowany { get; set; }

    public int? PkIdGrupa { get; set; }

    public bool PkZgodaDo { get; set; }

    public bool PkZgodaMark { get; set; }

    public bool PkZgodaEmail { get; set; }

    public byte[]? PkGrafika { get; set; }

    public string PkUwagi { get; set; } = null!;

    public string PkGaduGadu { get; set; } = null!;

    public string PkSkype { get; set; } = null!;

    public bool PkAdresKoresp { get; set; }

    public bool PkAdresDostawy { get; set; }

    public string PkPowitanie { get; set; } = null!;

    public int? PkIdRodzajKontaktu { get; set; }

    public int? PkIdPozyskany { get; set; }

    public int? PkIdBranza { get; set; }

    public int? PkIdRegion { get; set; }

    public int? PkIdDzial { get; set; }

    public int? PkIdOpiekun { get; set; }

    public int? PkIdDodal { get; set; }

    public int? PkIdZmienil { get; set; }

    public DateTime? PkDataDodania { get; set; }

    public DateTime? PkDataZmiany { get; set; }

    public DateTime? PkDataOkolicznosciowa { get; set; }

    public string? PkDomena { get; set; }

    public string? PkLokalizacja { get; set; }

    public virtual ICollection<KhCechaPrac> KhCechaPracs { get; set; } = new List<KhCechaPrac>();

    public virtual SlCrmBranza? PkIdBranzaNavigation { get; set; }

    public virtual SlCrmDzial? PkIdDzialNavigation { get; set; }

    public virtual SlGrupaKh? PkIdGrupaNavigation { get; set; }

    public virtual KhKontrahent PkIdKhNavigation { get; set; } = null!;

    public virtual PdUzytkownik? PkIdOpiekunNavigation { get; set; }

    public virtual SlCrmZrodloPozyskanium? PkIdPozyskanyNavigation { get; set; }

    public virtual SlCrmRegion? PkIdRegionNavigation { get; set; }

    public virtual SlRodzajKontaktu? PkIdRodzajKontaktuNavigation { get; set; }
}
