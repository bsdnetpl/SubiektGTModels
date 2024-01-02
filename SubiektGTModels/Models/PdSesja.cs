using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdSesja
{
    public int SsSpid { get; set; }

    public int SsUid { get; set; }

    public string SsHid { get; set; } = null!;

    public int SsApid { get; set; }

    public DateTime SsData { get; set; }

    public bool SsIgnore { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }

    public int? SsMagId { get; set; }

    public int? SsRokObrId { get; set; }
}
