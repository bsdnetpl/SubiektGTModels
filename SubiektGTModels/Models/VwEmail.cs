using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwEmail
{
    public int EmId { get; set; }

    public string EmSubject { get; set; } = null!;

    public string EmFromAddress { get; set; } = null!;

    public string EmFromName { get; set; } = null!;

    public string EmTo { get; set; } = null!;

    public DateTime? EmReceived { get; set; }

    public DateTime? EmSent { get; set; }

    public string EmAccount { get; set; } = null!;

    public int? EmAttachmentCount { get; set; }

    public int EmAttachements { get; set; }

    public int EmStatus { get; set; }

    public string EmFrom { get; set; } = null!;

    public int? EmTransId { get; set; }

    public int? EmPackageId { get; set; }

    public bool EmRead { get; set; }

    public int? EmAuctionId { get; set; }

    public int? EmCustomerId { get; set; }

    public bool EmHandled { get; set; }

    public int? EmAccountId { get; set; }

    public int? EmGroupId { get; set; }

    public string? GwaNazwa { get; set; }

    public int EmFlag { get; set; }

    public int EmPrivate { get; set; }

    public int? EmPrivateFor { get; set; }

    public string? AdrNazwa { get; set; }

    public string? KhSymbol { get; set; }

    public int? EmSourceSize { get; set; }

    public int? EmTransakcja { get; set; }

    public int? EmDzialanie { get; set; }

    public string? TrNazwa { get; set; }

    public string? ZdTemat { get; set; }

    public string? TrSymbol { get; set; }

    public int EmDeleteStat { get; set; }

    public string EmDeletedFrom { get; set; } = null!;

    public bool EmIsSpam { get; set; }

    public int? KhId { get; set; }

    public int? KhTyp { get; set; }

    public string? EmReplyTo { get; set; }

    public string EmCcTo { get; set; } = null!;

    public string EmBccTo { get; set; } = null!;

    public int? EmDispositionNotification { get; set; }

    public int EmPriority { get; set; }
}
