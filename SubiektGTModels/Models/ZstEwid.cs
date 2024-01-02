using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZstEwid
{
    public int ZstId { get; set; }

    public string ZstNazwa { get; set; } = null!;

    public string ZstOpis { get; set; } = null!;

    public int ZstTyp { get; set; }

    public int ZstProgFlagi { get; set; }

    public bool ZstUser { get; set; }

    public string ZstTresc { get; set; } = null!;

    public string? ZstDll { get; set; }

    public string ZstProgId { get; set; } = null!;

    public int? ZstIdKategorii { get; set; }

    public DateTime? ZstDataUzycia { get; set; }

    public int? ZstIkona { get; set; }

    public byte[]? ZstTrescDefiniowalne { get; set; }

    public int ZstStatusNowosci { get; set; }

    public virtual ICollection<RozZestKontekstoweZakladka> RozZestKontekstoweZakladkas { get; set; } = new List<RozZestKontekstoweZakladka>();

    public virtual SlKategoriaZestawien? ZstIdKategoriiNavigation { get; set; }

    public virtual ICollection<ZstWlasneXml> ZstWlasneXmls { get; set; } = new List<ZstWlasneXml>();

    public virtual ICollection<PdUzytkownik> PfIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
