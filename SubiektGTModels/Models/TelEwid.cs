using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TelEwid
{
    public int TelId { get; set; }

    public int TelIdAdresu { get; set; }

    public bool TelFaks { get; set; }

    public int TelRodzaj { get; set; }

    public string TelNazwa { get; set; } = null!;

    public string TelNumer { get; set; } = null!;

    public bool TelPodstawowy { get; set; }

    public bool TelSms { get; set; }

    public virtual ICollection<SmsMessage> SmsMessages { get; set; } = new List<SmsMessage>();

    public virtual AdrEwid TelIdAdresuNavigation { get; set; } = null!;
}
