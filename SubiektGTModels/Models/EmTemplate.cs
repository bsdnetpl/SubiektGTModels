using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmTemplate
{
    public int EtId { get; set; }

    public string EtName { get; set; } = null!;

    public string EtSubject { get; set; } = null!;

    public string EtText { get; set; } = null!;

    public bool EtHtml { get; set; }

    public string? EtMht { get; set; }

    public bool? EtFragment { get; set; }

    public string EtReplyTo { get; set; } = null!;

    public string EtCcTo { get; set; } = null!;

    public string EtBccTo { get; set; } = null!;

    public int? EtGroupId { get; set; }

    public int EtPriority { get; set; }

    public bool EtDispositionNotification { get; set; }

    public bool EtPrivate { get; set; }

    public bool EtDeleteAttachments { get; set; }

    public virtual SlCrmGrupaWiadomosci? EtGroup { get; set; }
}
