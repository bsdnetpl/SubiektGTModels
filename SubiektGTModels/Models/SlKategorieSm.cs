using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKategorieSm
{
    public int SlksId { get; set; }

    public string SlksCategoryName { get; set; } = null!;

    public bool SlksActive { get; set; }

    public virtual ICollection<SmsMessage> SmsMessages { get; set; } = new List<SmsMessage>();
}
