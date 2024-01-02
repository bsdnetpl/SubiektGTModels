using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SmsTemplate
{
    public int SmsttId { get; set; }

    public string SmsttName { get; set; } = null!;

    public int SmsttType { get; set; }

    public string SmsttContent { get; set; } = null!;

    public bool SmsttFlash { get; set; }

    public bool SmsttDiacritics { get; set; }

    public string? SmsttRemarks { get; set; }

    public int? SmsttCategoryId { get; set; }
}
