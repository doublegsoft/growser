using System;
using System.Collections.Generic;

namespace Growser.HIS
{

  public class OutpatientDiagnosis
  {

    /// <summary>
    /// 门诊诊断标识.
    /// </summary>
    private string outpatientDiagnosisId;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 诊断名称.
    /// </summary>
    private string diagnosisName;

    /// <summary>
    /// 诊断编码.
    /// </summary>
    private string diagnosisCode;

    /// <summary>
    /// 诊断编码系统.
    /// </summary>
    private string diagnosisSystem;

    /// <summary>
    /// 诊断日期.
    /// </summary>
    private DateTime diagnosisDate;

    /// <summary>
    /// 医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 主诊医生.
    /// </summary>
    private string attendingDoctorDoctorId;

    /// <summary>
    /// 诊断序号.
    /// </summary>
    private int ordinalPosition;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string OutpatientDiagnosisId
    {
      get
      {
        return outpatientDiagnosisId;
      }

      set
      {
        outpatientDiagnosisId = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string DiagnosisName
    {
      get
      {
        return diagnosisName;
      }

      set
      {
        diagnosisName = value;
      }
    }

    public string DiagnosisCode
    {
      get
      {
        return diagnosisCode;
      }

      set
      {
        diagnosisCode = value;
      }
    }

    public string DiagnosisSystem
    {
      get
      {
        return diagnosisSystem;
      }

      set
      {
        diagnosisSystem = value;
      }
    }

    public DateTime DiagnosisDate
    {
      get
      {
        return diagnosisDate;
      }

      set
      {
        diagnosisDate = value;
      }
    }

    public string HospitalId
    {
      get
      {
        return hospitalId;
      }

      set
      {
        hospitalId = value;
      }
    }

    public string ClinicId
    {
      get
      {
        return clinicId;
      }

      set
      {
        clinicId = value;
      }
    }

    public string AttendingDoctorDoctorId
    {
      get
      {
        return attendingDoctorDoctorId;
      }

      set
      {
        attendingDoctorDoctorId = value;
      }
    }

    public int OrdinalPosition
    {
      get
      {
        return ordinalPosition;
      }

      set
      {
        ordinalPosition = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class OutpatientMedicine
  {

    /// <summary>
    /// 门诊开药标识.
    /// </summary>
    private string outpatientMedicineId;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 药品.
    /// </summary>
    private string medicineId;

    /// <summary>
    /// 用药频率.
    /// </summary>
    private string frequency;

    /// <summary>
    /// 用药次剂量.
    /// </summary>
    private decimal dose;

    /// <summary>
    /// 用药剂量单位.
    /// </summary>
    private string unit;

    /// <summary>
    /// 用药总剂量.
    /// </summary>
    private decimal amount;

    /// <summary>
    /// 用药时长.
    /// </summary>
    private decimal duration;

    /// <summary>
    /// 停药日期.
    /// </summary>
    private decimal withdrawalDate;

    /// <summary>
    /// 主诊医生.
    /// </summary>
    private string attendingDoctorDoctorId;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string OutpatientMedicineId
    {
      get
      {
        return outpatientMedicineId;
      }

      set
      {
        outpatientMedicineId = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string MedicineId
    {
      get
      {
        return medicineId;
      }

      set
      {
        medicineId = value;
      }
    }

    public string Frequency
    {
      get
      {
        return frequency;
      }

      set
      {
        frequency = value;
      }
    }

    public decimal Dose
    {
      get
      {
        return dose;
      }

      set
      {
        dose = value;
      }
    }

    public string Unit
    {
      get
      {
        return unit;
      }

      set
      {
        unit = value;
      }
    }

    public decimal Amount
    {
      get
      {
        return amount;
      }

      set
      {
        amount = value;
      }
    }

    public decimal Duration
    {
      get
      {
        return duration;
      }

      set
      {
        duration = value;
      }
    }

    public decimal WithdrawalDate
    {
      get
      {
        return withdrawalDate;
      }

      set
      {
        withdrawalDate = value;
      }
    }

    public string AttendingDoctorDoctorId
    {
      get
      {
        return attendingDoctorDoctorId;
      }

      set
      {
        attendingDoctorDoctorId = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class OutpatientSurgery
  {

    /// <summary>
    /// 门诊手术标识.
    /// </summary>
    private string outpatientSurgeryId;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 手术编码.
    /// </summary>
    private string surgeryCode;

    /// <summary>
    /// 手术名称.
    /// </summary>
    private string surgeryName;

    /// <summary>
    /// 手术日期.
    /// </summary>
    private DateTime surgeryDate;

    /// <summary>
    /// 门诊医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 手术科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 手术医生.
    /// </summary>
    private string surgeryDoctorDoctorId;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string OutpatientSurgeryId
    {
      get
      {
        return outpatientSurgeryId;
      }

      set
      {
        outpatientSurgeryId = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string SurgeryCode
    {
      get
      {
        return surgeryCode;
      }

      set
      {
        surgeryCode = value;
      }
    }

    public string SurgeryName
    {
      get
      {
        return surgeryName;
      }

      set
      {
        surgeryName = value;
      }
    }

    public DateTime SurgeryDate
    {
      get
      {
        return surgeryDate;
      }

      set
      {
        surgeryDate = value;
      }
    }

    public string HospitalId
    {
      get
      {
        return hospitalId;
      }

      set
      {
        hospitalId = value;
      }
    }

    public string ClinicId
    {
      get
      {
        return clinicId;
      }

      set
      {
        clinicId = value;
      }
    }

    public string SurgeryDoctorDoctorId
    {
      get
      {
        return surgeryDoctorDoctorId;
      }

      set
      {
        surgeryDoctorDoctorId = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class OutpatientDocument
  {

    /// <summary>
    /// 门诊文书标识.
    /// </summary>
    private string outpatientDocumentId;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 医疗文书.
    /// </summary>
    private string medicalDocmentMedicalDocumentId;

    /// <summary>
    /// 门诊医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 手术科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 手术医生.
    /// </summary>
    private string surgeryDoctorDoctorId;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string OutpatientDocumentId
    {
      get
      {
        return outpatientDocumentId;
      }

      set
      {
        outpatientDocumentId = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string MedicalDocmentMedicalDocumentId
    {
      get
      {
        return medicalDocmentMedicalDocumentId;
      }

      set
      {
        medicalDocmentMedicalDocumentId = value;
      }
    }

    public string HospitalId
    {
      get
      {
        return hospitalId;
      }

      set
      {
        hospitalId = value;
      }
    }

    public string ClinicId
    {
      get
      {
        return clinicId;
      }

      set
      {
        clinicId = value;
      }
    }

    public string SurgeryDoctorDoctorId
    {
      get
      {
        return surgeryDoctorDoctorId;
      }

      set
      {
        surgeryDoctorDoctorId = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class PatientTestReport
  {

    /// <summary>
    /// 检查报告标识.
    /// </summary>
    private string patientTestReportId;

    /// <summary>
    /// 检查报告名称.
    /// </summary>
    private string patientTestReportName;

    /// <summary>
    /// 检查报告.
    /// </summary>
    private string medicalTestReportId;

    /// <summary>
    /// 报告序号.
    /// </summary>
    private string reportNumber;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 报告医生.
    /// </summary>
    private DateTime reportDoctor;

    /// <summary>
    /// 审核医生.
    /// </summary>
    private string approvalDoctorDoctorId;

    /// <summary>
    /// 主诊医生.
    /// </summary>
    private string attendingDoctorDoctorId;

    /// <summary>
    /// 报告日期.
    /// </summary>
    private DateTime reportTime;

    /// <summary>
    /// 审核日期.
    /// </summary>
    private DateTime approvalTime;

    /// <summary>
    /// 发布日期.
    /// </summary>
    private DateTime publishTime;

    /// <summary>
    /// 检查结果.
    /// </summary>
    private string result;

    /// <summary>
    /// 解读.
    /// </summary>
    private string interpretation;

    /// <summary>
    /// 意见.
    /// </summary>
    private string advice;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string PatientTestReportId
    {
      get
      {
        return patientTestReportId;
      }

      set
      {
        patientTestReportId = value;
      }
    }

    public string PatientTestReportName
    {
      get
      {
        return patientTestReportName;
      }

      set
      {
        patientTestReportName = value;
      }
    }

    public string MedicalTestReportId
    {
      get
      {
        return medicalTestReportId;
      }

      set
      {
        medicalTestReportId = value;
      }
    }

    public string ReportNumber
    {
      get
      {
        return reportNumber;
      }

      set
      {
        reportNumber = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public DateTime ReportDoctor
    {
      get
      {
        return reportDoctor;
      }

      set
      {
        reportDoctor = value;
      }
    }

    public string ApprovalDoctorDoctorId
    {
      get
      {
        return approvalDoctorDoctorId;
      }

      set
      {
        approvalDoctorDoctorId = value;
      }
    }

    public string AttendingDoctorDoctorId
    {
      get
      {
        return attendingDoctorDoctorId;
      }

      set
      {
        attendingDoctorDoctorId = value;
      }
    }

    public DateTime ReportTime
    {
      get
      {
        return reportTime;
      }

      set
      {
        reportTime = value;
      }
    }

    public DateTime ApprovalTime
    {
      get
      {
        return approvalTime;
      }

      set
      {
        approvalTime = value;
      }
    }

    public DateTime PublishTime
    {
      get
      {
        return publishTime;
      }

      set
      {
        publishTime = value;
      }
    }

    public string Result
    {
      get
      {
        return result;
      }

      set
      {
        result = value;
      }
    }

    public string Interpretation
    {
      get
      {
        return interpretation;
      }

      set
      {
        interpretation = value;
      }
    }

    public string Advice
    {
      get
      {
        return advice;
      }

      set
      {
        advice = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class PatientLaboratoryReport
  {

    /// <summary>
    /// 检验报告标识.
    /// </summary>
    private string patientLaboratoryReportId;

    /// <summary>
    /// 检验报告名称.
    /// </summary>
    private string patientLaboratoryReportName;

    /// <summary>
    /// 报告类型.
    /// </summary>
    private string reportType;

    /// <summary>
    /// 报告序号.
    /// </summary>
    private string reportNumber;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 报告医生.
    /// </summary>
    private string reportDoctorDoctorId;

    /// <summary>
    /// 审核医生.
    /// </summary>
    private string approvalDoctorDoctorId;

    /// <summary>
    /// 主诊医生.
    /// </summary>
    private string attendingDoctorDoctorId;

    /// <summary>
    /// 报告日期.
    /// </summary>
    private DateTime reportTime;

    /// <summary>
    /// 审核日期.
    /// </summary>
    private DateTime approvalTime;

    /// <summary>
    /// 发布日期.
    /// </summary>
    private DateTime publishTime;

    /// <summary>
    /// 解读.
    /// </summary>
    private string interpretation;

    /// <summary>
    /// 意见.
    /// </summary>
    private string advice;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    /// <summary>
    /// 检验项目结果.
    /// </summary>
    private List<PatientLaboratoryResult> results;

    public string PatientLaboratoryReportId
    {
      get
      {
        return patientLaboratoryReportId;
      }

      set
      {
        patientLaboratoryReportId = value;
      }
    }

    public string PatientLaboratoryReportName
    {
      get
      {
        return patientLaboratoryReportName;
      }

      set
      {
        patientLaboratoryReportName = value;
      }
    }

    public string ReportType
    {
      get
      {
        return reportType;
      }

      set
      {
        reportType = value;
      }
    }

    public string ReportNumber
    {
      get
      {
        return reportNumber;
      }

      set
      {
        reportNumber = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string ReportDoctorDoctorId
    {
      get
      {
        return reportDoctorDoctorId;
      }

      set
      {
        reportDoctorDoctorId = value;
      }
    }

    public string ApprovalDoctorDoctorId
    {
      get
      {
        return approvalDoctorDoctorId;
      }

      set
      {
        approvalDoctorDoctorId = value;
      }
    }

    public string AttendingDoctorDoctorId
    {
      get
      {
        return attendingDoctorDoctorId;
      }

      set
      {
        attendingDoctorDoctorId = value;
      }
    }

    public DateTime ReportTime
    {
      get
      {
        return reportTime;
      }

      set
      {
        reportTime = value;
      }
    }

    public DateTime ApprovalTime
    {
      get
      {
        return approvalTime;
      }

      set
      {
        approvalTime = value;
      }
    }

    public DateTime PublishTime
    {
      get
      {
        return publishTime;
      }

      set
      {
        publishTime = value;
      }
    }

    public string Interpretation
    {
      get
      {
        return interpretation;
      }

      set
      {
        interpretation = value;
      }
    }

    public string Advice
    {
      get
      {
        return advice;
      }

      set
      {
        advice = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

    public List<PatientLaboratoryResult> Results
    {
      get
      {
        return results;
      }

      set
      {
        results = value;
      }
    }

  }

  public class PatientLaboratoryResult
  {

    /// <summary>
    /// 检验报告标识.
    /// </summary>
    private string patientLaboratoryReportId;

    /// <summary>
    /// 检验项目编码.
    /// </summary>
    private string componentCode;

    /// <summary>
    /// 检验项目名称.
    /// </summary>
    private string componentName;

    /// <summary>
    /// 参考值.
    /// </summary>
    private string referenceRange;

    /// <summary>
    /// 剂量单位.
    /// </summary>
    private string unit;

    /// <summary>
    /// 检验项目结果.
    /// </summary>
    private string result;

    public string PatientLaboratoryReportId
    {
      get
      {
        return patientLaboratoryReportId;
      }

      set
      {
        patientLaboratoryReportId = value;
      }
    }

    public string ComponentCode
    {
      get
      {
        return componentCode;
      }

      set
      {
        componentCode = value;
      }
    }

    public string ComponentName
    {
      get
      {
        return componentName;
      }

      set
      {
        componentName = value;
      }
    }

    public string ReferenceRange
    {
      get
      {
        return referenceRange;
      }

      set
      {
        referenceRange = value;
      }
    }

    public string Unit
    {
      get
      {
        return unit;
      }

      set
      {
        unit = value;
      }
    }

    public string Result
    {
      get
      {
        return result;
      }

      set
      {
        result = value;
      }
    }

  }

  public class PresentIllness
  {

    /// <summary>
    /// 现病史标识.
    /// </summary>
    private string presentIllnessId;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    public string PresentIllnessId
    {
      get
      {
        return presentIllnessId;
      }

      set
      {
        presentIllnessId = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

  }

  public class PastHistory
  {

    /// <summary>
    /// 既往史标识.
    /// </summary>
    private string pastHistoryId;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 既往健康状况.
    /// </summary>
    private string healthState;

    /// <summary>
    /// 手术史.
    /// </summary>
    private string surgery;

    /// <summary>
    /// 疾病史.
    /// </summary>
    private string illness;

    /// <summary>
    /// 输血史.
    /// </summary>
    private string transfusion;

    /// <summary>
    /// 传染病史.
    /// </summary>
    private string infectiousDisease;

    /// <summary>
    /// 预防接种史.
    /// </summary>
    private string vaccination;

    /// <summary>
    /// 食物过敏史.
    /// </summary>
    private string foodAllergy;

    /// <summary>
    /// 药物过敏史.
    /// </summary>
    private string drugAllergy;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string PastHistoryId
    {
      get
      {
        return pastHistoryId;
      }

      set
      {
        pastHistoryId = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string HealthState
    {
      get
      {
        return healthState;
      }

      set
      {
        healthState = value;
      }
    }

    public string Surgery
    {
      get
      {
        return surgery;
      }

      set
      {
        surgery = value;
      }
    }

    public string Illness
    {
      get
      {
        return illness;
      }

      set
      {
        illness = value;
      }
    }

    public string Transfusion
    {
      get
      {
        return transfusion;
      }

      set
      {
        transfusion = value;
      }
    }

    public string InfectiousDisease
    {
      get
      {
        return infectiousDisease;
      }

      set
      {
        infectiousDisease = value;
      }
    }

    public string Vaccination
    {
      get
      {
        return vaccination;
      }

      set
      {
        vaccination = value;
      }
    }

    public string FoodAllergy
    {
      get
      {
        return foodAllergy;
      }

      set
      {
        foodAllergy = value;
      }
    }

    public string DrugAllergy
    {
      get
      {
        return drugAllergy;
      }

      set
      {
        drugAllergy = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class ObstetricalHistory
  {

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 结婚状况.
    /// </summary>
    private string martialStatusCode;

    /// <summary>
    /// 结婚年龄.
    /// </summary>
    private decimal martialAge;

    /// <summary>
    /// 配偶健康状况.
    /// </summary>
    private string spouseHealthState;

    /// <summary>
    /// 有无子女.
    /// </summary>
    private string childless;

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string MartialStatusCode
    {
      get
      {
        return martialStatusCode;
      }

      set
      {
        martialStatusCode = value;
      }
    }

    public decimal MartialAge
    {
      get
      {
        return martialAge;
      }

      set
      {
        martialAge = value;
      }
    }

    public string SpouseHealthState
    {
      get
      {
        return spouseHealthState;
      }

      set
      {
        spouseHealthState = value;
      }
    }

    public string Childless
    {
      get
      {
        return childless;
      }

      set
      {
        childless = value;
      }
    }

  }

  public class PersonalHistory
  {

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 生活习惯.
    /// </summary>
    private string livingHabit;

    /// <summary>
    /// 出生地.
    /// </summary>
    private string birthPlace;

    /// <summary>
    /// 长期居住地.
    /// </summary>
    private string livingPlace;

    /// <summary>
    /// 烟.
    /// </summary>
    private string smoking;

    /// <summary>
    /// 酒.
    /// </summary>
    private string drinking;

    /// <summary>
    /// 药物.
    /// </summary>
    private string drugging;

    /// <summary>
    /// 工业毒物.
    /// </summary>
    private string industrialPoison;

    /// <summary>
    /// 粉尘.
    /// </summary>
    private string dust;

    /// <summary>
    /// 放射性物质.
    /// </summary>
    private string radioactiveMaterial;

    /// <summary>
    /// 冶游史.
    /// </summary>
    private string highRiskSexualActivities;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string LivingHabit
    {
      get
      {
        return livingHabit;
      }

      set
      {
        livingHabit = value;
      }
    }

    public string BirthPlace
    {
      get
      {
        return birthPlace;
      }

      set
      {
        birthPlace = value;
      }
    }

    public string LivingPlace
    {
      get
      {
        return livingPlace;
      }

      set
      {
        livingPlace = value;
      }
    }

    public string Smoking
    {
      get
      {
        return smoking;
      }

      set
      {
        smoking = value;
      }
    }

    public string Drinking
    {
      get
      {
        return drinking;
      }

      set
      {
        drinking = value;
      }
    }

    public string Drugging
    {
      get
      {
        return drugging;
      }

      set
      {
        drugging = value;
      }
    }

    public string IndustrialPoison
    {
      get
      {
        return industrialPoison;
      }

      set
      {
        industrialPoison = value;
      }
    }

    public string Dust
    {
      get
      {
        return dust;
      }

      set
      {
        dust = value;
      }
    }

    public string RadioactiveMaterial
    {
      get
      {
        return radioactiveMaterial;
      }

      set
      {
        radioactiveMaterial = value;
      }
    }

    public string HighRiskSexualActivities
    {
      get
      {
        return highRiskSexualActivities;
      }

      set
      {
        highRiskSexualActivities = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class FamilyHistory
  {

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 父母健康状况.
    /// </summary>
    private string parentHealthState;

    /// <summary>
    /// 兄弟健康状况.
    /// </summary>
    private string brotherHealthState;

    /// <summary>
    /// 姐妹健康状况.
    /// </summary>
    private string sisterHealthState;

    /// <summary>
    /// 家族遗传病.
    /// </summary>
    private string geneticDisease;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public string ParentHealthState
    {
      get
      {
        return parentHealthState;
      }

      set
      {
        parentHealthState = value;
      }
    }

    public string BrotherHealthState
    {
      get
      {
        return brotherHealthState;
      }

      set
      {
        brotherHealthState = value;
      }
    }

    public string SisterHealthState
    {
      get
      {
        return sisterHealthState;
      }

      set
      {
        sisterHealthState = value;
      }
    }

    public string GeneticDisease
    {
      get
      {
        return geneticDisease;
      }

      set
      {
        geneticDisease = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class MenstrualHistory
  {

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 初潮年龄.
    /// </summary>
    private decimal menarcheAge;

    /// <summary>
    /// 行经期天数.
    /// </summary>
    private decimal menstrualDays;

    /// <summary>
    /// 间隔天数.
    /// </summary>
    private decimal dayInterval;

    /// <summary>
    /// 闭经年龄.
    /// </summary>
    private decimal amenorrheaAge;

    /// <summary>
    /// 月经量.
    /// </summary>
    private string menstrualVolume;

    /// <summary>
    /// 痛经.
    /// </summary>
    private string dysmenorrhea;

    /// <summary>
    /// 生育.
    /// </summary>
    private string fertility;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public decimal MenarcheAge
    {
      get
      {
        return menarcheAge;
      }

      set
      {
        menarcheAge = value;
      }
    }

    public decimal MenstrualDays
    {
      get
      {
        return menstrualDays;
      }

      set
      {
        menstrualDays = value;
      }
    }

    public decimal DayInterval
    {
      get
      {
        return dayInterval;
      }

      set
      {
        dayInterval = value;
      }
    }

    public decimal AmenorrheaAge
    {
      get
      {
        return amenorrheaAge;
      }

      set
      {
        amenorrheaAge = value;
      }
    }

    public string MenstrualVolume
    {
      get
      {
        return menstrualVolume;
      }

      set
      {
        menstrualVolume = value;
      }
    }

    public string Dysmenorrhea
    {
      get
      {
        return dysmenorrhea;
      }

      set
      {
        dysmenorrhea = value;
      }
    }

    public string Fertility
    {
      get
      {
        return fertility;
      }

      set
      {
        fertility = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class GestationParturition
  {

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 孕次.
    /// </summary>
    private int gestationCount;

    /// <summary>
    /// 产次.
    /// </summary>
    private int parturitionCount;

    /// <summary>
    /// 异常孕产史.
    /// </summary>
    private string adversePregnancy;

    /// <summary>
    /// 人工流产次数.
    /// </summary>
    private int abortionCount;

    /// <summary>
    /// 自然流产次数.
    /// </summary>
    private int miscarriageCount;

    /// <summary>
    /// 药物流产次数.
    /// </summary>
    private int medicalAbortionCount;

    /// <summary>
    /// 中期流产次数.
    /// </summary>
    private int midtermMiscarriageCount;

    /// <summary>
    /// 早产次数.
    /// </summary>
    private int prematureDeliveryCount;

    /// <summary>
    /// 难产次数.
    /// </summary>
    private int dystociaCount;

    /// <summary>
    /// 死产次数.
    /// </summary>
    private int stillbirthCount;

    /// <summary>
    /// 畸形儿.
    /// </summary>
    private int deformedCount;

    /// <summary>
    /// 出生死亡次数.
    /// </summary>
    private int neonatalDeathCount;

    /// <summary>
    /// 宫外孕次数.
    /// </summary>
    private int ectopicPregnancy;

    /// <summary>
    /// 葡萄胎次数.
    /// </summary>
    private int hydatidiformMole;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public int GestationCount
    {
      get
      {
        return gestationCount;
      }

      set
      {
        gestationCount = value;
      }
    }

    public int ParturitionCount
    {
      get
      {
        return parturitionCount;
      }

      set
      {
        parturitionCount = value;
      }
    }

    public string AdversePregnancy
    {
      get
      {
        return adversePregnancy;
      }

      set
      {
        adversePregnancy = value;
      }
    }

    public int AbortionCount
    {
      get
      {
        return abortionCount;
      }

      set
      {
        abortionCount = value;
      }
    }

    public int MiscarriageCount
    {
      get
      {
        return miscarriageCount;
      }

      set
      {
        miscarriageCount = value;
      }
    }

    public int MedicalAbortionCount
    {
      get
      {
        return medicalAbortionCount;
      }

      set
      {
        medicalAbortionCount = value;
      }
    }

    public int MidtermMiscarriageCount
    {
      get
      {
        return midtermMiscarriageCount;
      }

      set
      {
        midtermMiscarriageCount = value;
      }
    }

    public int PrematureDeliveryCount
    {
      get
      {
        return prematureDeliveryCount;
      }

      set
      {
        prematureDeliveryCount = value;
      }
    }

    public int DystociaCount
    {
      get
      {
        return dystociaCount;
      }

      set
      {
        dystociaCount = value;
      }
    }

    public int StillbirthCount
    {
      get
      {
        return stillbirthCount;
      }

      set
      {
        stillbirthCount = value;
      }
    }

    public int DeformedCount
    {
      get
      {
        return deformedCount;
      }

      set
      {
        deformedCount = value;
      }
    }

    public int NeonatalDeathCount
    {
      get
      {
        return neonatalDeathCount;
      }

      set
      {
        neonatalDeathCount = value;
      }
    }

    public int EctopicPregnancy
    {
      get
      {
        return ectopicPregnancy;
      }

      set
      {
        ectopicPregnancy = value;
      }
    }

    public int HydatidiformMole
    {
      get
      {
        return hydatidiformMole;
      }

      set
      {
        hydatidiformMole = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class MucocutaneousPhysical
  {

    /// <summary>
    /// 皮肤黏膜检查标识.
    /// </summary>
    private string mucocutaneousPhysicalId;

    /// <summary>
    /// 孕妇.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 体格检查日期.
    /// </summary>
    private DateTime physicalDate;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 就诊医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 就诊科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 主诊医生.
    /// </summary>
    private string attendingDoctorDoctorId;

    /// <summary>
    /// 颜色.
    /// </summary>
    private string color;

    /// <summary>
    /// 温度.
    /// </summary>
    private decimal temperature;

    /// <summary>
    /// 湿度.
    /// </summary>
    private decimal humidity;

    /// <summary>
    /// 弹性.
    /// </summary>
    private string elasticity;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string MucocutaneousPhysicalId
    {
      get
      {
        return mucocutaneousPhysicalId;
      }

      set
      {
        mucocutaneousPhysicalId = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public DateTime PhysicalDate
    {
      get
      {
        return physicalDate;
      }

      set
      {
        physicalDate = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string HospitalId
    {
      get
      {
        return hospitalId;
      }

      set
      {
        hospitalId = value;
      }
    }

    public string ClinicId
    {
      get
      {
        return clinicId;
      }

      set
      {
        clinicId = value;
      }
    }

    public string AttendingDoctorDoctorId
    {
      get
      {
        return attendingDoctorDoctorId;
      }

      set
      {
        attendingDoctorDoctorId = value;
      }
    }

    public string Color
    {
      get
      {
        return color;
      }

      set
      {
        color = value;
      }
    }

    public decimal Temperature
    {
      get
      {
        return temperature;
      }

      set
      {
        temperature = value;
      }
    }

    public decimal Humidity
    {
      get
      {
        return humidity;
      }

      set
      {
        humidity = value;
      }
    }

    public string Elasticity
    {
      get
      {
        return elasticity;
      }

      set
      {
        elasticity = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class VitalSignsPhysical
  {

    /// <summary>
    /// 孕妇体格检查标识.
    /// </summary>
    private string vitalSignsPhysicalId;

    /// <summary>
    /// 孕妇.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 体格检查日期.
    /// </summary>
    private DateTime physicalDate;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 就诊医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 就诊科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 主诊医生.
    /// </summary>
    private string attendingDoctorDoctorId;

    /// <summary>
    /// 身高.
    /// </summary>
    private int height;

    /// <summary>
    /// 体重.
    /// </summary>
    private int weight;

    /// <summary>
    /// 舒张压.
    /// </summary>
    private int diastolicBloodPressure;

    /// <summary>
    /// 收缩压.
    /// </summary>
    private int systolicBloodPressure;

    /// <summary>
    /// 脉搏.
    /// </summary>
    private int pulse;

    /// <summary>
    /// 体温.
    /// </summary>
    private decimal temperature;

    /// <summary>
    /// BMI.
    /// </summary>
    private int bmi;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string VitalSignsPhysicalId
    {
      get
      {
        return vitalSignsPhysicalId;
      }

      set
      {
        vitalSignsPhysicalId = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public DateTime PhysicalDate
    {
      get
      {
        return physicalDate;
      }

      set
      {
        physicalDate = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string HospitalId
    {
      get
      {
        return hospitalId;
      }

      set
      {
        hospitalId = value;
      }
    }

    public string ClinicId
    {
      get
      {
        return clinicId;
      }

      set
      {
        clinicId = value;
      }
    }

    public string AttendingDoctorDoctorId
    {
      get
      {
        return attendingDoctorDoctorId;
      }

      set
      {
        attendingDoctorDoctorId = value;
      }
    }

    public int Height
    {
      get
      {
        return height;
      }

      set
      {
        height = value;
      }
    }

    public int Weight
    {
      get
      {
        return weight;
      }

      set
      {
        weight = value;
      }
    }

    public int DiastolicBloodPressure
    {
      get
      {
        return diastolicBloodPressure;
      }

      set
      {
        diastolicBloodPressure = value;
      }
    }

    public int SystolicBloodPressure
    {
      get
      {
        return systolicBloodPressure;
      }

      set
      {
        systolicBloodPressure = value;
      }
    }

    public int Pulse
    {
      get
      {
        return pulse;
      }

      set
      {
        pulse = value;
      }
    }

    public decimal Temperature
    {
      get
      {
        return temperature;
      }

      set
      {
        temperature = value;
      }
    }

    public int Bmi
    {
      get
      {
        return bmi;
      }

      set
      {
        bmi = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class LimbsPhysical
  {

    /// <summary>
    /// 四肢检查标识.
    /// </summary>
    private string limbsPhysicalId;

    /// <summary>
    /// 孕妇.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 体格检查日期.
    /// </summary>
    private DateTime physicalDate;

    /// <summary>
    /// 门诊序号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 就诊医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 就诊科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 主诊医生.
    /// </summary>
    private string attendingDoctorDoctorId;

    /// <summary>
    /// 下肢水肿.
    /// </summary>
    private string lowerExtremityEdemaCode;

    /// <summary>
    /// 温度.
    /// </summary>
    private decimal temperature;

    /// <summary>
    /// 湿度.
    /// </summary>
    private decimal humidity;

    /// <summary>
    /// 弹性.
    /// </summary>
    private string elasticity;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string LimbsPhysicalId
    {
      get
      {
        return limbsPhysicalId;
      }

      set
      {
        limbsPhysicalId = value;
      }
    }

    public string PatientId
    {
      get
      {
        return patientId;
      }

      set
      {
        patientId = value;
      }
    }

    public DateTime PhysicalDate
    {
      get
      {
        return physicalDate;
      }

      set
      {
        physicalDate = value;
      }
    }

    public string OutpatientNumber
    {
      get
      {
        return outpatientNumber;
      }

      set
      {
        outpatientNumber = value;
      }
    }

    public string HospitalId
    {
      get
      {
        return hospitalId;
      }

      set
      {
        hospitalId = value;
      }
    }

    public string ClinicId
    {
      get
      {
        return clinicId;
      }

      set
      {
        clinicId = value;
      }
    }

    public string AttendingDoctorDoctorId
    {
      get
      {
        return attendingDoctorDoctorId;
      }

      set
      {
        attendingDoctorDoctorId = value;
      }
    }

    public string LowerExtremityEdemaCode
    {
      get
      {
        return lowerExtremityEdemaCode;
      }

      set
      {
        lowerExtremityEdemaCode = value;
      }
    }

    public decimal Temperature
    {
      get
      {
        return temperature;
      }

      set
      {
        temperature = value;
      }
    }

    public decimal Humidity
    {
      get
      {
        return humidity;
      }

      set
      {
        humidity = value;
      }
    }

    public string Elasticity
    {
      get
      {
        return elasticity;
      }

      set
      {
        elasticity = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

  public class PregnantPhysical
  {

    /// <summary>
    /// 孕妇体格检查标识.
    /// </summary>
    private string pregnantPhysicalId;

    /// <summary>
    /// 孕妇.
    /// </summary>
    private string pregnantId;

    /// <summary>
    /// 体格检查日期.
    /// </summary>
    private DateTime physicalDate;

    /// <summary>
    /// 就诊医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 就诊科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 主诊医生.
    /// </summary>
    private string attendingDoctorDoctorId;

    /// <summary>
    /// 宫高.
    /// </summary>
    private decimal fundalHeight;

    /// <summary>
    /// 宫高异常.
    /// </summary>
    private string fundalHeightException;

    /// <summary>
    /// 腹围.
    /// </summary>
    private decimal abdominalCircumference;

    /// <summary>
    /// 腹围异常.
    /// </summary>
    private string abdominalCircumferenceException;

    /// <summary>
    /// 胎心.
    /// </summary>
    private int fetalHeart;

    /// <summary>
    /// 胎心异常.
    /// </summary>
    private string fetalHeartException;

    /// <summary>
    /// 胎方位.
    /// </summary>
    private string fetalPositionCode;

    /// <summary>
    /// 胎方位异常.
    /// </summary>
    private string fetalPositionException;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 系统状态.
    /// </summary>
    private string state;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string PregnantPhysicalId
    {
      get
      {
        return pregnantPhysicalId;
      }

      set
      {
        pregnantPhysicalId = value;
      }
    }

    public string PregnantId
    {
      get
      {
        return pregnantId;
      }

      set
      {
        pregnantId = value;
      }
    }

    public DateTime PhysicalDate
    {
      get
      {
        return physicalDate;
      }

      set
      {
        physicalDate = value;
      }
    }

    public string HospitalId
    {
      get
      {
        return hospitalId;
      }

      set
      {
        hospitalId = value;
      }
    }

    public string ClinicId
    {
      get
      {
        return clinicId;
      }

      set
      {
        clinicId = value;
      }
    }

    public string AttendingDoctorDoctorId
    {
      get
      {
        return attendingDoctorDoctorId;
      }

      set
      {
        attendingDoctorDoctorId = value;
      }
    }

    public decimal FundalHeight
    {
      get
      {
        return fundalHeight;
      }

      set
      {
        fundalHeight = value;
      }
    }

    public string FundalHeightException
    {
      get
      {
        return fundalHeightException;
      }

      set
      {
        fundalHeightException = value;
      }
    }

    public decimal AbdominalCircumference
    {
      get
      {
        return abdominalCircumference;
      }

      set
      {
        abdominalCircumference = value;
      }
    }

    public string AbdominalCircumferenceException
    {
      get
      {
        return abdominalCircumferenceException;
      }

      set
      {
        abdominalCircumferenceException = value;
      }
    }

    public int FetalHeart
    {
      get
      {
        return fetalHeart;
      }

      set
      {
        fetalHeart = value;
      }
    }

    public string FetalHeartException
    {
      get
      {
        return fetalHeartException;
      }

      set
      {
        fetalHeartException = value;
      }
    }

    public string FetalPositionCode
    {
      get
      {
        return fetalPositionCode;
      }

      set
      {
        fetalPositionCode = value;
      }
    }

    public string FetalPositionException
    {
      get
      {
        return fetalPositionException;
      }

      set
      {
        fetalPositionException = value;
      }
    }

    public string ModifierId
    {
      get
      {
        return modifierId;
      }

      set
      {
        modifierId = value;
      }
    }

    public string ModifierType
    {
      get
      {
        return modifierType;
      }

      set
      {
        modifierType = value;
      }
    }

    public string State
    {
      get
      {
        return state;
      }

      set
      {
        state = value;
      }
    }

    public DateTime LastModifiedTime
    {
      get
      {
        return lastModifiedTime;
      }

      set
      {
        lastModifiedTime = value;
      }
    }

  }

}
