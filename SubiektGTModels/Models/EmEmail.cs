using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmEmail
{
    public int EmId { get; set; }

    public DateTime EmDate { get; set; }

    public string EmUidl { get; set; } = null!;

    public string EmMessageId { get; set; } = null!;

    public string EmSubject { get; set; } = null!;

    public string EmFrom { get; set; } = null!;

    public string EmFromAddress { get; set; } = null!;

    public string EmFromName { get; set; } = null!;

    public string EmTo { get; set; } = null!;

    public DateTime? EmReceived { get; set; }

    public DateTime? EmSent { get; set; }

    public string EmAccount { get; set; } = null!;

    public int? EmAttachmentCount { get; set; }

    public string? EmSource { get; set; }

    public bool? EmHtmlbody { get; set; }

    public int EmStatus { get; set; }

    public int? EmAccountId { get; set; }

    public int? EmTransId { get; set; }

    public int? EmPackageId { get; set; }

    public int? EmAuctionId { get; set; }

    public int? EmCustomerId { get; set; }

    public int? EmPrevTransId { get; set; }

    public bool EmHandled { get; set; }

    public bool EmRead { get; set; }

    public int? EmGroupId { get; set; }

    public int EmFlag { get; set; }

    public int? EmPrivateFor { get; set; }

    public int? EmTransakcja { get; set; }

    public int? EmDzialanie { get; set; }

    public int EmDeleteStat { get; set; }

    public bool EmIsSpam { get; set; }

    public string? EmReplyTo { get; set; }

    public string EmCcTo { get; set; } = null!;

    public string EmBccTo { get; set; } = null!;

    public int? EmDispositionNotification { get; set; }

    public int EmPriority { get; set; }

    public bool? EmWasAttDeleted { get; set; }

    public int EmChangedEncoding { get; set; }

    public bool EmDeleteAttAfterSending { get; set; }

    public int EmReferenceType { get; set; }

    public string EmReferencedMessageId { get; set; } = null!;

    public bool EmProcessedForEddUpdates { get; set; }

    public virtual SlCrmGrupaWiadomosci? EmGroup { get; set; }
}
