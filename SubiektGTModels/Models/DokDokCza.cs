using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokDokCza
{
    public int DgId { get; set; }

    public int DgIdDokumentu { get; set; }

    public DateTime DgDataUtworzenia { get; set; }

    public int DgRodzaj { get; set; }
}
