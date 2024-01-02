using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StSrodekTrwaly
{
    public int StId { get; set; }

    public string StNazwa { get; set; } = null!;

    public int StTyp { get; set; }

    public int? StIdKst { get; set; }

    public int? StTypWniP { get; set; }

    public string StGus { get; set; } = null!;

    public string StNrInw { get; set; } = null!;

    public string StCharakterystyka { get; set; } = null!;

    public string StDaneTechniczne { get; set; } = null!;

    public string StProducent { get; set; } = null!;

    public int? StRokProdukcji { get; set; }

    public string StSprzedawca { get; set; } = null!;

    public string StDokNabycia { get; set; } = null!;

    public string StStanTechniczny { get; set; } = null!;

    public decimal? StWartoscNabycia { get; set; }

    public DateTime? StDataNabycia { get; set; }

    public int? StSposobNabycia { get; set; }

    public int StStatus { get; set; }

    public string StNrAnalityka { get; set; } = null!;

    public int? StIdKategoriiDok { get; set; }

    public int? StIdKst2016 { get; set; }

    public virtual StKst2016? StIdKst2016Navigation { get; set; }

    public virtual StKst? StIdKstNavigation { get; set; }

    public virtual ICollection<StOperacja> StOperacjas { get; set; } = new List<StOperacja>();

    public virtual ICollection<StPlanAmrok> StPlanAmroks { get; set; } = new List<StPlanAmrok>();

    public virtual ICollection<StSrodekTrwalyDane> StSrodekTrwalyDanes { get; set; } = new List<StSrodekTrwalyDane>();

    public virtual ICollection<StSrodekTrwalyPlanAm> StSrodekTrwalyPlanAms { get; set; } = new List<StSrodekTrwalyPlanAm>();
}
