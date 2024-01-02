using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RfRaportyFiskalne
{
    public int RfdId { get; set; }

    public int RfdTyp { get; set; }

    public int RfdPodtyp { get; set; }

    public int RfdMagId { get; set; }

    public int RfdNr { get; set; }

    public string? RfdNrRoz { get; set; }

    public string RfdNrPelny { get; set; } = null!;

    public string RfdMscWyst { get; set; } = null!;

    public DateTime RfdDataWyst { get; set; }

    public DateTime RfdDataOd { get; set; }

    public DateTime RfdDataDo { get; set; }

    public decimal RfdWartNetto { get; set; }

    public decimal RfdWartVat { get; set; }

    public decimal RfdWartBrutto { get; set; }

    public string RfdWystawil { get; set; } = null!;

    public int RfdPersonelId { get; set; }

    public int RfdStatus { get; set; }

    public int RfdStatusKsieg { get; set; }

    public int? RfdKatId { get; set; }

    public string RfdUwagi { get; set; } = null!;

    public string RfdTytul { get; set; } = null!;

    public string RfdPodtytul { get; set; } = null!;

    public string? RfdNazwaUrzadzenia { get; set; }

    public bool RfdAutoPrzeliczaj { get; set; }

    public int? RfdRodzajTransakcjiVat { get; set; }

    public virtual ICollection<RfPozycja> RfPozycjas { get; set; } = new List<RfPozycja>();

    public virtual ICollection<RfVat> RfVats { get; set; } = new List<RfVat>();

    public virtual SlKategorium? RfdKat { get; set; }
}
