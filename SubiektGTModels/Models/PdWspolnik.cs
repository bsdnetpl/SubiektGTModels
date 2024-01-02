using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdWspolnik
{
    public int PwId { get; set; }

    public string PwImie { get; set; } = null!;

    public string PwImie2 { get; set; } = null!;

    public string PwNazwisko { get; set; } = null!;

    public DateTime? PwDataUrodzenia { get; set; }

    public string PwMiejsceUrodzenia { get; set; } = null!;

    public string PwObywatelstwo { get; set; } = null!;

    public string PwPesel { get; set; } = null!;

    public string PwNip { get; set; } = null!;

    public int? PwIdUs { get; set; }

    public decimal PwUdzial { get; set; }

    public string PwEmail { get; set; } = null!;

    public string PwTypIdentyfikatora { get; set; } = null!;

    public string PwNumerIdentyfikatora { get; set; } = null!;

    public string? PwTytulUbezpieczenia { get; set; }

    public string? PwPrawoDoEmer { get; set; }

    public string? PwStopienNiepelnosprawnosci { get; set; }

    public DateTime? PwStopienNiepelnosprawnosciOd { get; set; }

    public DateTime? PwStopienNiepelnosprawnosciDo { get; set; }

    public string? PwStopienNiezdolnosciDoPracy { get; set; }

    public DateTime? PwStopienNiezdolnosciDoPracyOd { get; set; }

    public DateTime? PwStopienNiezdolnosciDoPracyDo { get; set; }

    public int PwGenDeklaracja { get; set; }

    public int PwZasRodzLiczbaOsob { get; set; }

    public decimal PwZasRodzKwota { get; set; }

    public int PwZasPielegLiczbaOsob { get; set; }

    public decimal PwZasPielegKwota { get; set; }

    public int PwZasWychLiczbaOsob { get; set; }

    public decimal PwZasWychKwota { get; set; }

    public bool PwAktywny { get; set; }

    public int PwSklMcNaliczania { get; set; }

    public bool PwSklUbezpEmNaliczanie { get; set; }

    public bool PwSklUbezpRentNaliczanie { get; set; }

    public bool PwSklUbezpChorNaliczanie { get; set; }

    public bool PwSklUbezpWypNaliczanie { get; set; }

    public bool PwSklUbezpZdrNaliczanie { get; set; }

    public bool PwSklFpNaliczanie { get; set; }

    public bool PwSklUbezpEmKoszty { get; set; }

    public bool PwSklUbezpRentKoszty { get; set; }

    public bool PwSklUbezpChorKoszty { get; set; }

    public bool PwSklUbezpWypKoszty { get; set; }

    public bool PwSklUbezpZdrKoszty { get; set; }

    public bool PwSklFpKoszty { get; set; }

    public int PwSklUbezpEmPit5 { get; set; }

    public int PwSklUbezpRentPit5 { get; set; }

    public int PwSklUbezpChorPit5 { get; set; }

    public int PwSklUbezpWypPit5 { get; set; }

    public int PwSklUbezpZdrPit5 { get; set; }

    public bool PwPodstawaSpolIndywidualna { get; set; }

    public bool PwPodstawaZdrIndywidualna { get; set; }

    public bool PwPodstawaChWyIndywidualna { get; set; }

    public string? PwNrAnalityka { get; set; }

    public int? PwIdRachunkuWirtualnego { get; set; }

    public bool PwCzyZalPit28 { get; set; }

    public int PwIdentyfikacjaPodatkowa { get; set; }

    public bool PwOdliczajUlgePodatkowa { get; set; }

    public bool PwZaliczkaPonizejTys { get; set; }

    public bool PwOdliczajUlgePodatkowaWdeklRocznych { get; set; }

    public bool PwZmianaSklUbezpPit5 { get; set; }

    public int PwRodzaj { get; set; }

    public int? PwIdWspolnika { get; set; }

    public bool? PwOstrzegajPrzekroczenieWiekuFp { get; set; }

    public bool PwCzyUstawionoDatePoczatkuWeryfikacjiNaliczenSklZus { get; set; }

    public DateTime? PwDataPoczatkuWeryfikacjiNaliczenSklZus { get; set; }

    public bool PwPrzejscieZliniowegoNaSkaleW2022 { get; set; }

    public virtual ICollection<PdWspolnik> InversePwIdWspolnikaNavigation { get; set; } = new List<PdWspolnik>();

    public virtual ICollection<PdPodmiot> PdPodmiots { get; set; } = new List<PdPodmiot>();

    public virtual ICollection<PdWspolnikPodatek> PdWspolnikPodateks { get; set; } = new List<PdWspolnikPodatek>();

    public virtual ICollection<PdWspolnikPodstawa> PdWspolnikPodstawas { get; set; } = new List<PdWspolnikPodstawa>();

    public virtual ICollection<PdWspolnikSkladka> PdWspolnikSkladkaPwsIdWspOsWspolpracujacejNavigations { get; set; } = new List<PdWspolnikSkladka>();

    public virtual ICollection<PdWspolnikSkladka> PdWspolnikSkladkaPwsIdWspolnikaNavigations { get; set; } = new List<PdWspolnikSkladka>();

    public virtual ICollection<PdWspolnikSposobSkladka> PdWspolnikSposobSkladkas { get; set; } = new List<PdWspolnikSposobSkladka>();

    public virtual ICollection<PdWspolnikSwiadczenie> PdWspolnikSwiadczenies { get; set; } = new List<PdWspolnikSwiadczenie>();

    public virtual ICollection<PdWspolnikUlgiPit0> PdWspolnikUlgiPit0s { get; set; } = new List<PdWspolnikUlgiPit0>();

    public virtual ICollection<PrzObnizkaPodatku> PrzObnizkaPodatkus { get; set; } = new List<PrzObnizkaPodatku>();

    public virtual ICollection<PrzOdliczenieDoliczenie> PrzOdliczenieDoliczenies { get; set; } = new List<PrzOdliczenieDoliczenie>();

    public virtual RbRachBankowyWirtualny? PwIdRachunkuWirtualnegoNavigation { get; set; }

    public virtual IsInstytucja? PwIdUsNavigation { get; set; }

    public virtual PdWspolnik? PwIdWspolnikaNavigation { get; set; }

    public virtual SlPrawoDoEmerytury? PwPrawoDoEmerNavigation { get; set; }

    public virtual SlStopienNiepelnosprawnosci? PwStopienNiepelnosprawnosciNavigation { get; set; }

    public virtual SlStopienNiezdolnosciDoPracy? PwStopienNiezdolnosciDoPracyNavigation { get; set; }

    public virtual SlTypIdentyfikatora PwTypIdentyfikatoraNavigation { get; set; } = null!;

    public virtual SlTytulUbezpieczenium? PwTytulUbezpieczeniaNavigation { get; set; }

    public virtual ICollection<RbRachBankowyWirtualnyWspolnika> RbRachBankowyWirtualnyWspolnikas { get; set; } = new List<RbRachBankowyWirtualnyWspolnika>();
}
