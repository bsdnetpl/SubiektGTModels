using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUzytkParam
{
    public int UzpIdUzytkownika { get; set; }

    public int? UzpPrzypSubiekt { get; set; }

    public DateTime? UzpDataSubiekt { get; set; }

    public int? UzpPrzypRachmistrz { get; set; }

    public DateTime? UzpDataRachmistrz { get; set; }

    public int? UzpPrzypRewizor { get; set; }

    public DateTime? UzpDataRewizor { get; set; }

    public int? UzpPrzypGratyfikant { get; set; }

    public DateTime? UzpDataGratyfikant { get; set; }

    public int? UzpPrzypGestor { get; set; }

    public DateTime? UzpDataGestor { get; set; }

    public DateTime? UzpPrzypAboSubiekt { get; set; }

    public DateTime? UzpPrzypAboRachmistrz { get; set; }

    public DateTime? UzpPrzypAboRewizor { get; set; }

    public DateTime? UzpPrzypAboGratyfikant { get; set; }

    public DateTime? UzpPrzypAboGestor { get; set; }

    public string UzpPrzypAboWerSubiekt { get; set; } = null!;

    public string UzpPrzypAboWerRachmistrz { get; set; } = null!;

    public string UzpPrzypAboWerRewizor { get; set; } = null!;

    public string UzpPrzypAboWerGratyfikant { get; set; } = null!;

    public string UzpPrzypAboWerGestor { get; set; } = null!;

    public DateTime? UzpInfoAboSubiekt { get; set; }

    public DateTime? UzpInfoAboRachmistrz { get; set; }

    public DateTime? UzpInfoAboRewizor { get; set; }

    public DateTime? UzpInfoAboGratyfikant { get; set; }

    public DateTime? UzpInfoAboGestor { get; set; }

    public virtual PdUzytkownik UzpIdUzytkownikaNavigation { get; set; } = null!;
}
