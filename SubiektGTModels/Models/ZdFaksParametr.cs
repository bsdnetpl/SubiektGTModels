using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdFaksParametr
{
    public int ZdfpId { get; set; }

    public int? ZdfpParamEwidId { get; set; }

    public int? ZdfpRodzaj { get; set; }

    public byte ZdfpKierunek { get; set; }

    public bool ZdfpBezCzasu { get; set; }

    public byte ZdfpData { get; set; }

    public byte ZdfpPersonel { get; set; }

    public byte ZdfpPriorytet { get; set; }

    public byte? ZdfpPrzypomnienie { get; set; }

    public bool ZdfpPokazujWkalendarzu { get; set; }

    public string ZdfpKolor { get; set; } = null!;

    public bool ZdfpPrywatne { get; set; }

    public int ZdfpStatus { get; set; }

    public string ZdfpUwagi { get; set; } = null!;

    public int? ZdfpRodzajW { get; set; }

    public byte ZdfpKierunekW { get; set; }

    public bool ZdfpBezCzasuW { get; set; }

    public byte ZdfpDataW { get; set; }

    public byte ZdfpPersonelW { get; set; }

    public byte ZdfpPriorytetW { get; set; }

    public byte? ZdfpPrzypomnienieW { get; set; }

    public bool ZdfpPokazujWkalendarzuW { get; set; }

    public string ZdfpKolorW { get; set; } = null!;

    public bool ZdfpPrywatneW { get; set; }

    public int ZdfpStatusW { get; set; }

    public string ZdfpUwagiW { get; set; } = null!;

    public int ZdfpFormaW { get; set; }

    public bool ZdfpKotwicz { get; set; }

    public bool ZdfpKotwiczW { get; set; }
}
