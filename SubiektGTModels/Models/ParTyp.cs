using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ParTyp
{
    public int PtId { get; set; }

    public string PtOpis { get; set; } = null!;

    public bool PtIndywidualizowalny { get; set; }

    public string PtNazwa { get; set; } = null!;

    public int PtProgramy { get; set; }

    public string PtProgId { get; set; } = null!;

    public int? PtProgIdCtx { get; set; }

    public int PtAppObjId { get; set; }

    public bool PtUkryte { get; set; }

    public int PtStatusNowosci { get; set; }

    public virtual ICollection<DokDokumentDefiniowalny> DokDokumentDefiniowalnies { get; set; } = new List<DokDokumentDefiniowalny>();

    public virtual ICollection<ParEwid> ParEwids { get; set; } = new List<ParEwid>();

    public virtual ICollection<PdUzytkownik> PtpIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
