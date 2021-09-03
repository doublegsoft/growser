using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Growser.HIS
{

  /// <summary>
  /// HIS接口规范定义。
  /// </summary>
  public interface HISSpecification
  {

    /// <summary>
    /// 获取医院标识，医院标识是指医院在妇幼专科联盟中的编码。
    /// </summary>
    /// <returns>医院标识</returns>
    string GetHospitalId();

    /// <summary>
    /// 获取检查报告列表。
    /// </summary>
    /// <returns>检查报告列表</returns>
    List<MedicalTestReport> GetTestReports();

    /// <summary>
    /// 获取检验报告列表。
    /// </summary>
    /// <returns>检验报告列表</returns>
    List<MedicalLaboratoryReport> GetLaboratoryReports();

    /// <summary>
    /// 计算检查/检验单价格。
    /// </summary>
    /// <param name="testReports">检查单</param>
    /// <param name="laboratoryReports">检验单</param>
    /// <returns>检查、检验单总价</returns>
    decimal CalculatePrice(List<MedicalTestReport> testReports, List<MedicalLaboratoryReport> laboratoryReports);

    /// <summary>
    /// 计算处方价格。
    /// </summary>
    /// <param name="prescription">处方</param>
    /// <returns>处方总价</returns>
    decimal CalculatePrice(Prescription prescription);

    /// <summary>
    /// 开具检查单。
    /// </summary>
    /// <param name="tests">检查单</param>
    void CreateTestReports(List<MedicalTestReport> tests);

    /// <summary>
    /// 开具检验单。
    /// </summary>
    /// <param name="laboratoryTests">检验单</param>
    void CreateLaboratoryReports(List<MedicalLaboratoryReport> laboratoryTests);

    /// <summary>
    /// 开具处方。
    /// </summary>
    /// <param name="prescription">处方对象</param>
    /// <returns>处方标识</returns>
    void CreatePrescription(Prescription prescription);
  }

  public class HISSpecificationHost
  {

    private HISSpecification hisSpecification;

    public HISSpecificationHost(HISSpecification hisSpecification)
    {
      this.hisSpecification = hisSpecification;
    }

    public string GetHospitalId()
    {
      return hisSpecification.GetHospitalId();
    }

    public decimal CalculatePrice(List<MedicalTestReport> testReports, List<MedicalLaboratoryReport> laboratoryReports)
    {
      return hisSpecification.CalculatePrice(testReports, laboratoryReports);
    }
  }
}
