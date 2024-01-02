using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmAccount
{
    public int EaId { get; set; }

    public string EaAccountName { get; set; } = null!;

    public string? EaUserName { get; set; }

    public string? EaUserAddress { get; set; }

    public string EaLogin { get; set; } = null!;

    public string EaPassword { get; set; } = null!;

    public string? EaPop3 { get; set; }

    public int EaPop3port { get; set; }

    public bool EaPop3ssl { get; set; }

    public string? EaSmtp { get; set; }

    public int EaSmtpport { get; set; }

    public int EaSmtpauth { get; set; }

    public int EaSmtpssl { get; set; }

    public bool EaDisabled { get; set; }

    public bool EaLeaveOnServer { get; set; }

    public bool EaDefault { get; set; }

    public int EaOwnerId { get; set; }

    public bool EaOutlook { get; set; }

    public int? EaAttachmentsCode { get; set; }

    public int? EaAttachmentsLimit { get; set; }

    public string EaReplyTo { get; set; } = null!;

    public int EaDispositionNotification { get; set; }

    public int? EaSendPackageSize { get; set; }

    public int EaPriority { get; set; }

    public int? EaLimitSeconds { get; set; }

    public int? EaLimitMinutes { get; set; }

    public int? EaLimitHours { get; set; }

    public int? EaLimitValue { get; set; }

    public int? EaLimitDailyHour { get; set; }

    public int? EaLimitDailyValue { get; set; }

    public bool EaDeleteAttAfterSending { get; set; }

    public string EaPassword2 { get; set; } = null!;

    public int? EaOauth2Provider { get; set; }

    public string? EaOauth2Token { get; set; }

    public string? EaOauth2RefreshToken { get; set; }

    public DateTime? EaOauth2TokenExpiryDate { get; set; }

    public virtual ICollection<EddParametr> EddParametrs { get; set; } = new List<EddParametr>();
}
