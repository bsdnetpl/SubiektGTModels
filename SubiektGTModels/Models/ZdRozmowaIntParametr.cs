using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdRozmowaIntParametr
{
    public int ZdrpId { get; set; }

    public int? ZdrpParamEwidId { get; set; }

    public int? ZdrpRodzaj { get; set; }

    public byte ZdrpKierunek { get; set; }

    public bool ZdrpBezCzasu { get; set; }

    public byte ZdrpPoczatek { get; set; }

    public byte ZdrpCzasTrwania { get; set; }

    public byte ZdrpOpiekun { get; set; }

    public byte ZdrpPriorytet { get; set; }

    public byte? ZdrpPrzypomnienie { get; set; }

    public bool ZdrpPokazujWkalendarzu { get; set; }

    public string ZdrpKolor { get; set; } = null!;

    public bool ZdrpPrywatne { get; set; }

    public int ZdrpStatus { get; set; }

    public string ZdrpUwagi { get; set; } = null!;

    public int? ZdrpRodzajW { get; set; }

    public byte ZdrpKierunekW { get; set; }

    public bool ZdrpBezCzasuW { get; set; }

    public byte ZdrpPoczatekW { get; set; }

    public byte ZdrpCzasTrwaniaW { get; set; }

    public byte ZdrpOpiekunW { get; set; }

    public byte ZdrpPriorytetW { get; set; }

    public byte? ZdrpPrzypomnienieW { get; set; }

    public bool ZdrpPokazujWkalendarzuW { get; set; }

    public string ZdrpKolorW { get; set; } = null!;

    public bool ZdrpPrywatneW { get; set; }

    public int ZdrpStatusW { get; set; }

    public string ZdrpUwagiW { get; set; } = null!;

    public int ZdrpFormaW { get; set; }

    public bool ZdrpKotwicz { get; set; }

    public bool ZdrpKotwiczW { get; set; }
}
