using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaParametr
{
    public int UppId { get; set; }

    public int UppFormatNumeru { get; set; }

    public int UppRaportZus { get; set; }

    public int UppKosztyUzyskania { get; set; }

    public int UppPrzelewNaKonto { get; set; }

    public decimal UppPrzelewProcent { get; set; }

    public decimal UppPrzelewKwota { get; set; }

    public int? UppTresc { get; set; }

    public int UppWymiarLicznik { get; set; }

    public int UppWymiarMianownik { get; set; }

    public int UppIdKalendarza { get; set; }

    public int? UppParamEwidId { get; set; }

    public int UppCzyNaliczacUlgeDlaKlasySredniej { get; set; }

    public bool UppCzyOdraczacPoborZaliczki { get; set; }

    public virtual SlFormatNumeracji UppFormatNumeruNavigation { get; set; } = null!;

    public virtual SlKalendarz UppIdKalendarzaNavigation { get; set; } = null!;

    public virtual ParEwid? UppParamEwid { get; set; }
}
