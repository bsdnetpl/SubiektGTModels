using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdListParametr
{
    public int ZdlpId { get; set; }

    public int? ZdlpParamEwidId { get; set; }

    public int? ZdlpRodzaj { get; set; }

    public byte ZdlpKierunek { get; set; }

    public bool ZdlpBezCzasu { get; set; }

    public byte ZdlpData { get; set; }

    public byte ZdlpPersonel { get; set; }

    public byte ZdlpPriorytet { get; set; }

    public byte? ZdlpPrzypomnienie { get; set; }

    public bool ZdlpPokazujWkalendarzu { get; set; }

    public string ZdlpKolor { get; set; } = null!;

    public bool ZdlpPrywatne { get; set; }

    public int ZdlpStatus { get; set; }

    public string ZdlpUwagi { get; set; } = null!;

    public int? ZdlpRodzajW { get; set; }

    public byte ZdlpKierunekW { get; set; }

    public bool ZdlpBezCzasuW { get; set; }

    public byte ZdlpDataW { get; set; }

    public byte ZdlpPersonelW { get; set; }

    public byte ZdlpPriorytetW { get; set; }

    public byte? ZdlpPrzypomnienieW { get; set; }

    public bool ZdlpPokazujWkalendarzuW { get; set; }

    public string ZdlpKolorW { get; set; } = null!;

    public bool ZdlpPrywatneW { get; set; }

    public int ZdlpStatusW { get; set; }

    public string ZdlpUwagiW { get; set; } = null!;

    public int ZdlpFormaW { get; set; }

    public bool ZdlpKotwicz { get; set; }

    public bool ZdlpKotwiczW { get; set; }
}
