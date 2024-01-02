using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokDokumentDefiniowalny
{
    public int DdId { get; set; }

    public string DdNazwa { get; set; } = null!;

    public string DdSkrot { get; set; } = null!;

    public int DdDokTyp { get; set; }

    public int DdDokPodtyp { get; set; }

    public int? DdIdOperacji { get; set; }

    public int DdIdParTyp { get; set; }

    public int? DdUpidAdd { get; set; }

    public int? DdUpidEdit { get; set; }

    public int? DdUpidDelete { get; set; }

    public int? DdUpidPrint { get; set; }

    public int DdUzywaUprawnien { get; set; }

    public int DdPokazFiltr { get; set; }

    public int DdWzwId { get; set; }

    public bool DdUwzglednionyJpk { get; set; }

    public virtual ParTyp DdIdParTypNavigation { get; set; } = null!;

    public virtual ICollection<ImSchematImportu> ImSchematImportus { get; set; } = new List<ImSchematImportu>();
}
