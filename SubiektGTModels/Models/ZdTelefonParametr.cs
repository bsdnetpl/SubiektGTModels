using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdTelefonParametr
{
    public int ZdtpId { get; set; }

    public int? ZdtpParamEwidId { get; set; }

    public int? ZdtpRodzaj { get; set; }

    public byte ZdtpKierunek { get; set; }

    public bool ZdtpBezCzasu { get; set; }

    public byte ZdtpPoczatek { get; set; }

    public byte ZdtpCzasTrwania { get; set; }

    public byte ZdtpOpiekun { get; set; }

    public byte ZdtpPriorytet { get; set; }

    public byte? ZdtpPrzypomnienie { get; set; }

    public bool ZdtpPokazujWkalendarzu { get; set; }

    public string ZdtpKolor { get; set; } = null!;

    public bool ZdtpPrywatne { get; set; }

    public int ZdtpStatus { get; set; }

    public string ZdtpUwagi { get; set; } = null!;

    public int? ZdtpRodzajW { get; set; }

    public byte ZdtpKierunekW { get; set; }

    public bool ZdtpBezCzasuW { get; set; }

    public byte ZdtpPoczatekW { get; set; }

    public byte ZdtpCzasTrwaniaW { get; set; }

    public byte ZdtpOpiekunW { get; set; }

    public byte ZdtpPriorytetW { get; set; }

    public byte? ZdtpPrzypomnienieW { get; set; }

    public bool ZdtpPokazujWkalendarzuW { get; set; }

    public string ZdtpKolorW { get; set; } = null!;

    public bool ZdtpPrywatneW { get; set; }

    public int ZdtpStatusW { get; set; }

    public string ZdtpUwagiW { get; set; } = null!;

    public int ZdtpFormaW { get; set; }

    public bool ZdtpKotwicz { get; set; }

    public bool ZdtpKotwiczW { get; set; }
}
