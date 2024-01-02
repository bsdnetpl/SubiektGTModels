using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTypEwidVat
{
    public int TeId { get; set; }

    public string TeNazwa { get; set; } = null!;

    public string TeOpis { get; set; } = null!;

    public int TeRodzaj { get; set; }

    public bool TeCzySystemowa { get; set; }

    public bool TeCzyKorekty { get; set; }

    public int TePozycja { get; set; }

    public int? TeIdKategorii { get; set; }

    public int TeRodzajZakupu { get; set; }

    public int TeSposobOdliczania { get; set; }

    public int TeTransakcjaVat { get; set; }

    public int TeMiesiacOdliczVat { get; set; }

    public int? TeIdTerminPlatnosci { get; set; }

    public bool TeRozliczanaUsluga { get; set; }

    public int TeCelZakupu { get; set; }

    public bool TeVatMarza { get; set; }

    public virtual ICollection<ImSchematImportu> ImSchematImportuSiIdEwidVatNavigations { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<ImSchematImportu> ImSchematImportuSiIdEwidVatdokZrodlowegoNavigations { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<ImSchematImportu> ImSchematImportuSiIdEwidVatooNavigations { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<ImSchematImportu> ImSchematImportuSiIdEwidVatzakNavigations { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<KhKontrahent> KhKontrahentKhIdEwVatspNavigations { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhKontrahent> KhKontrahentKhIdEwVatzakNavigations { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhParametr> KhParametrKhpIdEwVatspNavigations { get; set; } = new List<KhParametr>();

    public virtual ICollection<KhParametr> KhParametrKhpIdEwVatzakNavigations { get; set; } = new List<KhParametr>();

    public virtual ICollection<PojParametr> PojParametrs { get; set; } = new List<PojParametr>();

    public virtual ICollection<SlRejestrKsiegowy> SlRejestrKsiegowies { get; set; } = new List<SlRejestrKsiegowy>();

    public virtual SlKategorium? TeIdKategoriiNavigation { get; set; }

    public virtual SlFormaPlatnosci? TeIdTerminPlatnosciNavigation { get; set; }

    public virtual ICollection<VatEwidVat> VatEwidVats { get; set; } = new List<VatEwidVat>();

    public virtual ICollection<VatParametr> VatParametrVatpIdEwidVatspImportNavigations { get; set; } = new List<VatParametr>();

    public virtual ICollection<VatParametr> VatParametrVatpIdEwidVatspItpuNavigations { get; set; } = new List<VatParametr>();

    public virtual ICollection<VatParametr> VatParametrVatpIdEwidVatspNabyciaNavigations { get; set; } = new List<VatParametr>();

    public virtual ICollection<VatParametr> VatParametrVatpIdEwidVatspOoNavigations { get; set; } = new List<VatParametr>();
}
