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

    #region 配置数据

    /// <summary>
    /// 获取医院标识，医院标识是指医院在妇幼专科联盟中的编码。
    /// </summary>
    /// <returns>医院标识</returns>
    string GetHospitalId();

    #endregion

    #region 医院基础数据

    /// <summary>
    /// 获取医院检查报告列表。
    /// </summary>
    /// <returns>检查报告列表</returns>
    List<MedicalTestReport> GetTestReports();

    /// <summary>
    /// 获取医院检验报告列表。
    /// </summary>
    /// <returns>检验报告列表</returns>
    List<MedicalLaboratoryReport> GetLaboratoryReports();

    /// <summary>
    /// 获取医院药品列表。
    /// </summary>
    /// <returns>药品列表</returns>
    List<Medicine> GetMedicines();

    /// <summary>
    /// 查询HIS患者基本信息。
    /// </summary>
    /// <param name="patientName">患者姓名</param>
    /// <param name="idCardNumber">身份证号</param>
    /// <param name="mobile">手机号</param>
    /// <param name="genderCode">性别编码</param>
    /// <param name="birthDate">出生日期</param>
    /// <returns></returns>
    Patient GetPatient(string patientName, string idCardNumber = "", string mobile = "", string genderCode = "", string birthDate = "");

    #endregion

    #region 医生交互用例

    /// <summary>
    /// 获取排队等候用户列表。
    /// </summary>
    /// <param name="hospitalId">医院标识</param>
    /// <param name="clinicId">门诊科室标识</param>
    /// <returns>等候用户</returns>
    List<Patient> GetWaitingPatients(string clinicId);

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
    /// <param name="patientId">患者标识</param>
    /// <param name="outpatientNumber">门诊号</param>
    /// <param name="clinicId">开单科室标识</param>
    /// <param name="attendingDoctorId">主诊医生标识</param>
    /// <param name="medicalTestReports">检查单</param>
    List<PatientTestReport> CreateTestReports(string patientId, string outpatientNumber, string clinicId, string attendingDoctorId, List<MedicalTestReport> medicalTestReports);

    /// <summary>
    /// 开具检验单。
    /// </summary>
    /// <param name="patientId">患者标识</param>
    /// <param name="outpatientNumber">门诊号</param>
    /// <param name="clinicId">开单科室标识</param>
    /// <param name="attendingDoctorId">主诊医生标识</param>
    /// <param name="medicalLaboratoryReports">检验单</param>
    /// <returns>持久化后的患者报告</returns>
    /// <remarks>
    /// </remarks>
    List<PatientLaboratoryReport> CreateLaboratoryReport(string patientId, string outpatientNumber, string clinicId, string attendingDoctorId, List<MedicalLaboratoryReport> medicalLaboratoryReports);

    /// <summary>
    /// 开具处方。
    /// </summary>
    /// <param name="patientId">患者标识</param>
    /// <param name="outpatientNumber">门诊号</param>
    /// <param name="clinicId">开单科室标识</param>
    /// <param name="attendingDoctorId">主诊医生标识</param>
    /// <param name="prescription">处方对象</param>
    /// <returns>持久化后的处方</returns>
    Prescription CreatePrescription(string patientId, string outpatientNumber, string clinicId, string attendingDoctorId, Prescription prescription);

    /// <summary>
    /// 获取患者门诊的检查报告。
    /// </summary>
    /// <param name="patientId">患者标识</param>
    /// <param name="outpatientNumber">门诊号</param>
    /// <param name="reportNumber">报告单号</param>
    /// <returns>门诊检查报告</returns>
    List<PatientTestReport> GetPatientTestReports(string patientId, string outpatientNumber = "", string reportNumber = "");

    /// <summary>
    /// 获取患者门诊的检验报告。
    /// </summary>
    /// <param name="patientId">患者标识</param>
    /// <param name="outpatientNumber">门诊号</param>
    /// <param name="reportNumber">报告单号</param>
    /// <returns>门诊检验报告</returns>
    List<PatientLaboratoryReport> GetPatientLaboratoryReports(string patientId, string outpatientNumber = "", string reportNumber = "");

    Outpatient MakeDiagnosis(string patientId, string diagnosisCode, string diagnosis);

    /// <summary>
    /// 获取患者门诊信息。
    /// </summary>
    /// <param name="patientId">患者标识</param>
    /// <returns>门诊信息</returns>
    List<Outpatient> GetOutpatients(string patientId);

    #endregion
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
