using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwSynchronizacjaImport
{
    public int UsyId { get; set; }

    public int UsyIdKonfiguracja { get; set; }

    public int UsyIdTowar { get; set; }

    public string UsyTowarUf { get; set; } = null!;

    public int? UsyIdZadanie { get; set; }

    public int? UsyRodzaj { get; set; }

    public string UsySymbol { get; set; } = null!;

    public string UsyUrzNazwa { get; set; } = null!;

    public decimal? UsyStawkaVat { get; set; }

    public int? UsyIdVatSp { get; set; }

    public int? UsyIdVatUf { get; set; }

    public string UsyJednMiary { get; set; } = null!;

    public int? UsyIdJednostkaUf { get; set; }

    public int? UsyIdOpakowanie { get; set; }

    public string UsyUrzNazwa2 { get; set; } = null!;

    public int? UsyPlu { get; set; }

    public string UsyPodstKodKresk { get; set; } = null!;

    public bool? UsyCenaOtwarta { get; set; }

    public bool? UsyWagaEtykiet { get; set; }

    public int? UsyIdGrupa { get; set; }

    public int? UsyIdDzialGrupaUf { get; set; }

    public int? UsyIdVatGrupaUf { get; set; }

    public string UsyOpis { get; set; } = null!;

    public string UsySww { get; set; } = null!;

    public int? UsyRabatRodzaj { get; set; }

    public decimal? UsyRabatProcent { get; set; }

    public int? UsyDniWaznosc { get; set; }

    public string UsyUwagi { get; set; } = null!;

    public decimal? UsyCenaBrutto1 { get; set; }

    public int? UsyIdCenaUf1 { get; set; }

    public decimal? UsyCenaBrutto2 { get; set; }

    public int? UsyIdCenaUf2 { get; set; }

    public decimal? UsyCenaBrutto3 { get; set; }

    public int? UsyIdCenaUf3 { get; set; }

    public decimal? UsyCenaBrutto4 { get; set; }

    public int? UsyIdCenaUf4 { get; set; }

    public decimal? UsyCenaBrutto5 { get; set; }

    public int? UsyIdCenaUf5 { get; set; }

    public decimal? UsyCenaBrutto6 { get; set; }

    public int? UsyIdCenaUf6 { get; set; }

    public decimal? UsyCenaBrutto7 { get; set; }

    public int? UsyIdCenaUf7 { get; set; }

    public decimal? UsyCenaBrutto8 { get; set; }

    public int? UsyIdCenaUf8 { get; set; }

    public decimal? UsyCenaBrutto9 { get; set; }

    public int? UsyIdCenaUf9 { get; set; }

    public decimal? UsyCenaBrutto10 { get; set; }

    public int? UsyIdCenaUf10 { get; set; }

    public string UsyPole1 { get; set; } = null!;

    public int? UsyIdInneUf1 { get; set; }

    public string UsyPole2 { get; set; } = null!;

    public int? UsyIdInneUf2 { get; set; }

    public string UsyPole3 { get; set; } = null!;

    public int? UsyIdInneUf3 { get; set; }

    public string UsyPole4 { get; set; } = null!;

    public int? UsyIdInneUf4 { get; set; }

    public string UsyPole5 { get; set; } = null!;

    public int? UsyIdInneUf5 { get; set; }

    public string UsyPole6 { get; set; } = null!;

    public int? UsyIdInneUf6 { get; set; }

    public string UsyPole7 { get; set; } = null!;

    public int? UsyIdInneUf7 { get; set; }

    public string UsyPole8 { get; set; } = null!;

    public int? UsyIdInneUf8 { get; set; }
}
