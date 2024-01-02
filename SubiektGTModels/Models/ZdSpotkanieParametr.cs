using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdSpotkanieParametr
{
    public int ZdspId { get; set; }

    public int? ZdspParamEwidId { get; set; }

    public int? ZdspRodzaj { get; set; }

    public bool ZdspBezCzasu { get; set; }

    public bool ZdspCalyDzien { get; set; }

    public byte ZdspPoczatek { get; set; }

    public byte ZdspCzasTrwania { get; set; }

    public byte ZdspOpiekun { get; set; }

    public byte ZdspPriorytet { get; set; }

    public byte? ZdspPrzypomnienie { get; set; }

    public bool ZdspPokazujWkalendarzu { get; set; }

    public string ZdspKolor { get; set; } = null!;

    public bool ZdspPrywatne { get; set; }

    public int ZdspStatus { get; set; }

    public string ZdspUwagi { get; set; } = null!;

    public int? ZdspRodzajW { get; set; }

    public bool ZdspBezCzasuW { get; set; }

    public bool ZdspCalyDzienW { get; set; }

    public byte ZdspPoczatekW { get; set; }

    public byte ZdspCzasTrwaniaW { get; set; }

    public byte ZdspOpiekunW { get; set; }

    public byte ZdspPriorytetW { get; set; }

    public byte? ZdspPrzypomnienieW { get; set; }

    public bool ZdspPokazujWkalendarzuW { get; set; }

    public string ZdspKolorW { get; set; } = null!;

    public bool ZdspPrywatneW { get; set; }

    public int ZdspStatusW { get; set; }

    public string ZdspUwagiW { get; set; } = null!;

    public int ZdspFormaW { get; set; }

    public bool ZdspKotwicz { get; set; }

    public bool ZdspKotwiczW { get; set; }
}
