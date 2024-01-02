using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class InsxParametr
{
    public int IxpId { get; set; }

    public int IxpLiczbaPozTw { get; set; }

    public bool IxpTwBezZerowych { get; set; }

    public bool IxpTwRezerwacje { get; set; }

    public bool IxpTwWarunekAnd { get; set; }

    public bool IxpTwSortuj { get; set; }

    public int? IxpParamEwidId { get; set; }

    public int IxpLiczbaPozKh { get; set; }

    public bool IxpKhWarunekAnd { get; set; }

    public int IxpKhRodzaj { get; set; }

    public bool IxpKhSortuj { get; set; }

    public int IxpTwMinZnakow { get; set; }

    public int IxpKhMinZnakow { get; set; }

    public int IxpLiczbaPozEa { get; set; }

    public bool IxpEaWarunekAnd { get; set; }

    public bool IxpWyszukiwanieAdresow { get; set; }

    public byte[]? IxpDataPdm { get; set; }

    public bool IxpBiblDokWarunekAnd { get; set; }

    public bool IxpEaPominNieaktywnych { get; set; }

    public virtual ParEwid? IxpParamEwid { get; set; }
}
