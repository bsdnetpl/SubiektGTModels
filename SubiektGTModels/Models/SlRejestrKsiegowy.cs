using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlRejestrKsiegowy
{
    public int RksId { get; set; }

    public string RksSymbol { get; set; } = null!;

    public string RksNazwa { get; set; } = null!;

    public string RksOpis { get; set; } = null!;

    public int RksKontrolaBilansowania { get; set; }

    public string RksDefWalutaDekretow { get; set; } = null!;

    public int RksDefRodzajKursuWal { get; set; }

    public int RksPowiazanieVat { get; set; }

    public int? RksIdTypuEwidVat { get; set; }

    public int? RksRodzajZakupu { get; set; }

    public int? RksSposobOdliczania { get; set; }

    public int RksKontrolaDanychVat { get; set; }

    public int RksKontrolaZgodnosciEwidencjiVat { get; set; }

    public int? RksIdKategorii { get; set; }

    public bool RksKopiujTresc { get; set; }

    public int? RksRodzajDowodu { get; set; }

    public string RksOpisDekretu { get; set; } = null!;

    public bool RksKopiujOpis { get; set; }

    public int RksDataKursu { get; set; }

    public bool RksOstatniKurs { get; set; }

    public bool RksUstawVatnaRozrachunku { get; set; }

    public bool RksUstawMechanizmPpnaRozrachunku { get; set; }

    public int? RksIdTypuEwidVatoss { get; set; }

    public int RksKontrolaDanychVatoss { get; set; }

    public int RksKontrolaZgodnosciEwidencjiVatoss { get; set; }

    public virtual ICollection<DkrAutomat> DkrAutomats { get; set; } = new List<DkrAutomat>();

    public virtual ICollection<DkrDokument> DkrDokuments { get; set; } = new List<DkrDokument>();

    public virtual ICollection<DkrSladRewizyjny> DkrSladRewizyjnies { get; set; } = new List<DkrSladRewizyjny>();

    public virtual ICollection<DkrWzorzec> DkrWzorzecs { get; set; } = new List<DkrWzorzec>();

    public virtual ICollection<ImSchematImportu> ImSchematImportus { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<NrNrStartDkr> NrNrStartDkrs { get; set; } = new List<NrNrStartDkr>();

    public virtual ICollection<NrNrStartRk> NrNrStartRks { get; set; } = new List<NrNrStartRk>();

    public virtual SlWalutum RksDefWalutaDekretowNavigation { get; set; } = null!;

    public virtual SlKategorium? RksIdKategoriiNavigation { get; set; }

    public virtual SlTypEwidVat? RksIdTypuEwidVatNavigation { get; set; }

    public virtual SlEwidVatOss? RksIdTypuEwidVatossNavigation { get; set; }
}
