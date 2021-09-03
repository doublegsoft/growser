using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Growser.HIS.Non
{

  public class NonHospitalHIS : HISSpecification
  {
    public decimal CalculatePrice(List<MedicalTestReport> testReports, List<MedicalLaboratoryReport> laboratoryReports)
    {
      throw new NotImplementedException();
    }

    public decimal CalculatePrice(Prescription prescription)
    {
      throw new NotImplementedException();
    }

    public void CreateLaboratoryReports(List<MedicalLaboratoryReport> laboratoryTests)
    {
      throw new NotImplementedException();
    }

    public void CreatePrescription(Prescription prescription)
    {
      throw new NotImplementedException();
    }

    public void CreateTestReports(List<MedicalTestReport> tests)
    {
      throw new NotImplementedException();
    }

    public string GetHospitalId()
    {
      return "没有医院标识";
    }

    public List<MedicalLaboratoryReport> GetLaboratoryReports()
    {
      throw new NotImplementedException();
    }

    public List<MedicalTestReport> GetTestReports()
    {
      throw new NotImplementedException();
    }
  }
}
