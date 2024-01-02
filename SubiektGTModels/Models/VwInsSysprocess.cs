using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwInsSysprocess
{
    public short Spid { get; set; }

    public short Kpid { get; set; }

    public short Blocked { get; set; }

    public byte[] Waittype { get; set; } = null!;

    public long Waittime { get; set; }

    public string Lastwaittype { get; set; } = null!;

    public string Waitresource { get; set; } = null!;

    public short Dbid { get; set; }

    public short? Uid { get; set; }

    public int Cpu { get; set; }

    public long PhysicalIo { get; set; }

    public int Memusage { get; set; }

    public DateTime LoginTime { get; set; }

    public DateTime LastBatch { get; set; }

    public short Ecid { get; set; }

    public short OpenTran { get; set; }

    public string Status { get; set; } = null!;

    public byte[] Sid { get; set; } = null!;

    public string Hostname { get; set; } = null!;

    public string ProgramName { get; set; } = null!;

    public string Hostprocess { get; set; } = null!;

    public string Cmd { get; set; } = null!;

    public string? NtDomain { get; set; }

    public string? NtUsername { get; set; }

    public string NetAddress { get; set; } = null!;

    public string NetLibrary { get; set; } = null!;

    public string Loginame { get; set; } = null!;

    public byte[] ContextInfo { get; set; } = null!;

    public byte[] SqlHandle { get; set; } = null!;

    public int StmtStart { get; set; }

    public int StmtEnd { get; set; }
}
