using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrZatrudnienie
{
    public int PzaId { get; set; }

    public int PzaIdPracownika { get; set; }

    public string PzaMiejsce { get; set; } = null!;

    public int? PzaIdZawodu { get; set; }

    public string PzaStanowisko { get; set; } = null!;

    public DateTime PzaDataOd { get; set; }

    public DateTime PzaDataDo { get; set; }

    public int? PzaIdPowoduRozwUmowy { get; set; }

    public int PzaDniUrlopuWyp { get; set; }

    public int PzaDniChoroby { get; set; }

    public int PzaDniUrlopuWypNaZadanie { get; set; }

    public int PzaDniOpiekiNadDzieckiem { get; set; }

    public bool PzaWliczajDoStazu { get; set; }

    public int PzaGodzinOpiekiNadDzieckiem { get; set; }

    public bool PzaWliczajDoLatStazuWfirmie { get; set; }

    public int PzaDniUrlopuSilaWyzsza { get; set; }

    public int PzaGodzinyUrlopuSilaWyzsza { get; set; }

    public int PzaDniUrlopuOpiekunczego { get; set; }

    public int PzaDniPracyZdalnejOkazjonalnej { get; set; }

    public virtual SlGratPrzyczynaRozwUmowy? PzaIdPowoduRozwUmowyNavigation { get; set; }

    public virtual PrPracownik PzaIdPracownikaNavigation { get; set; } = null!;

    public virtual SlZawod? PzaIdZawoduNavigation { get; set; }
}
