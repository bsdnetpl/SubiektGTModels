using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class LogOdrzLicencje
{
    public DateTime LsDate { get; set; }

    public int LsUserId { get; set; }

    public string LsUserHost { get; set; } = null!;

    public short LsSpid { get; set; }

    public short LsKpid { get; set; }

    public short LsBlocked { get; set; }

    public byte[] LsWaittype { get; set; } = null!;

    public long LsWaittime { get; set; }

    public string LsLastwaittype { get; set; } = null!;

    public string LsWaitresource { get; set; } = null!;

    public short LsDbid { get; set; }

    public short? LsUid { get; set; }

    public int LsCpu { get; set; }

    public long LsPhysicalIo { get; set; }

    public int LsMemusage { get; set; }

    public DateTime LsLoginTime { get; set; }

    public DateTime LsLastBatch { get; set; }

    public short LsEcid { get; set; }

    public short LsOpenTran { get; set; }

    public string LsStatus { get; set; } = null!;

    public byte[] LsSid { get; set; } = null!;

    public string LsHostname { get; set; } = null!;

    public string LsProgramName { get; set; } = null!;

    public string LsHostprocess { get; set; } = null!;

    public string LsCmd { get; set; } = null!;

    public string? LsNtDomain { get; set; }

    public string? LsNtUsername { get; set; }

    public string LsNetAddress { get; set; } = null!;

    public string LsNetLibrary { get; set; } = null!;

    public string LsLoginame { get; set; } = null!;

    public byte[] LsContextInfo { get; set; } = null!;

    public byte[] LsSqlHandle { get; set; } = null!;

    public int LsStmtStart { get; set; }

    public int LsStmtEnd { get; set; }
}
