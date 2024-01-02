using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdZadanieParametr
{
    public int ZdzpId { get; set; }

    public int? ZdzpParamEwidId { get; set; }

    public int? ZdzpRodzaj { get; set; }

    public bool ZdzpBezCzasu { get; set; }

    public bool ZdzpCalyDzien { get; set; }

    public byte ZdzpPoczatek { get; set; }

    public byte ZdzpCzasTrwania { get; set; }

    public byte ZdzpOpiekun { get; set; }

    public byte ZdzpPriorytet { get; set; }

    public byte? ZdzpPrzypomnienie { get; set; }

    public bool ZdzpPokazujWkalendarzu { get; set; }

    public string ZdzpKolor { get; set; } = null!;

    public bool ZdzpPrywatne { get; set; }

    public int ZdzpStatus { get; set; }

    public string ZdzpUwagi { get; set; } = null!;

    public int? ZdzpRodzajW { get; set; }

    public bool ZdzpBezCzasuW { get; set; }

    public bool ZdzpCalyDzienW { get; set; }

    public byte ZdzpPoczatekW { get; set; }

    public byte ZdzpCzasTrwaniaW { get; set; }

    public byte ZdzpOpiekunW { get; set; }

    public byte ZdzpPriorytetW { get; set; }

    public byte? ZdzpPrzypomnienieW { get; set; }

    public bool ZdzpPokazujWkalendarzuW { get; set; }

    public string ZdzpKolorW { get; set; } = null!;

    public bool ZdzpPrywatneW { get; set; }

    public int ZdzpStatusW { get; set; }

    public string ZdzpUwagiW { get; set; } = null!;

    public int ZdzpFormaW { get; set; }

    public bool ZdzpKotwicz { get; set; }

    public bool ZdzpKotwiczW { get; set; }
}
