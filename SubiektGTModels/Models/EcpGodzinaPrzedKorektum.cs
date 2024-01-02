using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpGodzinaPrzedKorektum
{
    public int EcpgpkId { get; set; }

    public int EcpgpkIdZapis { get; set; }

    public int EcpgpkPoraDnia { get; set; }

    public int EcpgpkOd { get; set; }

    public int EcpgpkDo { get; set; }
}
