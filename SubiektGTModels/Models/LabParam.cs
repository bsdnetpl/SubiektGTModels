using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class LabParam
{
    public int PlabId { get; set; }

    public bool PlabRegulamin { get; set; }

    public bool PlabPortalBiuraRaport { get; set; }

    public bool PlabPortalBiuraDokument { get; set; }

    public bool PlabWydrukiNiefiskalne { get; set; }

    public bool PlabSesjeKasowe { get; set; }

    public bool PlabPortalBiuraDokOcr { get; set; }

    public bool PlabDokumentyPlus { get; set; }

    public bool PlabInsAidokPlus { get; set; }

    public bool PlabPortalBiuraPrzeslijPliki { get; set; }

    public bool PlabKseF { get; set; }

    public bool PlabRoczneNaliczanieSklZdr { get; set; }

    public bool PlabSchematyImportuDfpb { get; set; }

    public bool PlabSchematyImportuKseF { get; set; }
}
