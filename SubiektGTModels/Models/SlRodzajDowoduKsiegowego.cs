using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlRodzajDowoduKsiegowego
{
    public int RdkId { get; set; }

    public string RdkNazwa { get; set; } = null!;

    public int? RdkTypWartosci { get; set; }

    public virtual ICollection<DkrDokument> DkrDokuments { get; set; } = new List<DkrDokument>();

    public virtual ICollection<ImSchematImportu> ImSchematImportus { get; set; } = new List<ImSchematImportu>();
}
