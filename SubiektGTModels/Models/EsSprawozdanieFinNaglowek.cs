using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EsSprawozdanieFinNaglowek
{
    public int SfnId { get; set; }

    public int SfnTyp { get; set; }

    public int SfnWariant { get; set; }

    public int SfnWersjaTechniczna { get; set; }

    public string? SfnWersjaSchemy { get; set; }

    public string SfnNazwa { get; set; } = null!;

    public int SfnIdRoku { get; set; }

    public DateTime SfnOkresOd { get; set; }

    public DateTime SfnOkresDo { get; set; }

    public DateTime? SfnDataZatwierdzenia { get; set; }

    public bool SfnZatwierdzony { get; set; }

    public bool SfnWyeksportowany { get; set; }

    public int SfnWybraneRodzaje { get; set; }

    public int SfnMiejsceSkladania { get; set; }

    public bool SfnImportowany { get; set; }

    public virtual ICollection<EsSprawozdanieFinElement> EsSprawozdanieFinElements { get; set; } = new List<EsSprawozdanieFinElement>();

    public virtual ICollection<EsWysylkaElektroniczna> EsWysylkaElektronicznas { get; set; } = new List<EsWysylkaElektroniczna>();
}
