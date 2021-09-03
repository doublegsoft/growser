using System;
using System.Collections.Generic;

namespace Growser.HIS
{

  public class Hospital
  {

    /// <summary>
    /// 医院标识.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// HIS编码.
    /// </summary>
    private string hisCode;

    /// <summary>
    /// 医院名称.
    /// </summary>
    private string hospitalName;

    /// <summary>
    /// 医院地址.
    /// </summary>
    private string address;

    /// <summary>
    /// 详细描述.
    /// </summary>
    private string description;

    /// <summary>
    /// 其他属性.
    /// </summary>
    private string options;

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
    /// .
    /// </summary>
    private List<Doctor> doctors;

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

    public string HisCode
    {
      get
      {
        return hisCode;
      }

      set
      {
        hisCode = value;
      }
    }

    public string HospitalName
    {
      get
      {
        return hospitalName;
      }

      set
      {
        hospitalName = value;
      }
    }

    public string Address
    {
      get
      {
        return address;
      }

      set
      {
        address = value;
      }
    }

    public string Description
    {
      get
      {
        return description;
      }

      set
      {
        description = value;
      }
    }

    public string Options
    {
      get
      {
        return options;
      }

      set
      {
        options = value;
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

    public List<Doctor> Doctors
    {
      get
      {
        return doctors;
      }

      set
      {
        doctors = value;
      }
    }

  }

  public class Clinic
  {

    /// <summary>
    /// 门诊标识.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// HIS编码.
    /// </summary>
    private string hisCode;

    /// <summary>
    /// 医院标识.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 门诊科室.
    /// </summary>
    private string clinicName;

    /// <summary>
    /// 类别.
    /// </summary>
    private string category;

    /// <summary>
    /// 院内地址.
    /// </summary>
    private string address;

    /// <summary>
    /// 详细描述.
    /// </summary>
    private string description;

    /// <summary>
    /// 其他属性.
    /// </summary>
    private string options;

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

    public string HisCode
    {
      get
      {
        return hisCode;
      }

      set
      {
        hisCode = value;
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

    public string ClinicName
    {
      get
      {
        return clinicName;
      }

      set
      {
        clinicName = value;
      }
    }

    public string Category
    {
      get
      {
        return category;
      }

      set
      {
        category = value;
      }
    }

    public string Address
    {
      get
      {
        return address;
      }

      set
      {
        address = value;
      }
    }

    public string Description
    {
      get
      {
        return description;
      }

      set
      {
        description = value;
      }
    }

    public string Options
    {
      get
      {
        return options;
      }

      set
      {
        options = value;
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

  public class Doctor
  {

    /// <summary>
    /// 医生标识.
    /// </summary>
    private string doctorId;

    /// <summary>
    /// 医院标识.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 科室标识.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 医生姓名.
    /// </summary>
    private string doctorName;

    /// <summary>
    /// 职称.
    /// </summary>
    private string professionalTitle;

    /// <summary>
    /// 详细描述.
    /// </summary>
    private string description;

    /// <summary>
    /// 其他属性.
    /// </summary>
    private string options;

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

    public string DoctorId
    {
      get
      {
        return doctorId;
      }

      set
      {
        doctorId = value;
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

    public string DoctorName
    {
      get
      {
        return doctorName;
      }

      set
      {
        doctorName = value;
      }
    }

    public string ProfessionalTitle
    {
      get
      {
        return professionalTitle;
      }

      set
      {
        professionalTitle = value;
      }
    }

    public string Description
    {
      get
      {
        return description;
      }

      set
      {
        description = value;
      }
    }

    public string Options
    {
      get
      {
        return options;
      }

      set
      {
        options = value;
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

  public class Infertility
  {

    /// <summary>
    /// 患者标识.
    /// </summary>
    private string infertilityId;

    /// <summary>
    /// 档案号.
    /// </summary>
    private string serialNumber;

    /// <summary>
    /// 建档时间.
    /// </summary>
    private DateTime createTime;

    /// <summary>
    /// 男方信息.
    /// </summary>
    private string malePatientId;

    /// <summary>
    /// 女方信息.
    /// </summary>
    private string femalePatientId;

    /// <summary>
    /// 建档医院.
    /// </summary>
    private string hospitalId;

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

    public string InfertilityId
    {
      get
      {
        return infertilityId;
      }

      set
      {
        infertilityId = value;
      }
    }

    public string SerialNumber
    {
      get
      {
        return serialNumber;
      }

      set
      {
        serialNumber = value;
      }
    }

    public DateTime CreateTime
    {
      get
      {
        return createTime;
      }

      set
      {
        createTime = value;
      }
    }

    public string MalePatientId
    {
      get
      {
        return malePatientId;
      }

      set
      {
        malePatientId = value;
      }
    }

    public string FemalePatientId
    {
      get
      {
        return femalePatientId;
      }

      set
      {
        femalePatientId = value;
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

  public class PolycysticOvarySyndrome
  {

    /// <summary>
    /// 档案标识.
    /// </summary>
    private string polycysticOvarySyndromeId;

    /// <summary>
    /// 档案号.
    /// </summary>
    private string serialNumber;

    /// <summary>
    /// 建档时间.
    /// </summary>
    private DateTime createTime;

    /// <summary>
    /// 男方信息.
    /// </summary>
    private string malePatientId;

    /// <summary>
    /// 女方信息.
    /// </summary>
    private string femalePatientId;

    /// <summary>
    /// 建档医院.
    /// </summary>
    private string hospitalId;

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

    public string PolycysticOvarySyndromeId
    {
      get
      {
        return polycysticOvarySyndromeId;
      }

      set
      {
        polycysticOvarySyndromeId = value;
      }
    }

    public string SerialNumber
    {
      get
      {
        return serialNumber;
      }

      set
      {
        serialNumber = value;
      }
    }

    public DateTime CreateTime
    {
      get
      {
        return createTime;
      }

      set
      {
        createTime = value;
      }
    }

    public string MalePatientId
    {
      get
      {
        return malePatientId;
      }

      set
      {
        malePatientId = value;
      }
    }

    public string FemalePatientId
    {
      get
      {
        return femalePatientId;
      }

      set
      {
        femalePatientId = value;
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

  public class Patient
  {

    /// <summary>
    /// 患者标识.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 患者姓名.
    /// </summary>
    private string patientName;

    /// <summary>
    /// 性别.
    /// </summary>
    private string genderCode;

    /// <summary>
    /// 出生日期.
    /// </summary>
    private DateTime birthDate;

    /// <summary>
    /// 手机号码.
    /// </summary>
    private string mobile;

    /// <summary>
    /// 证件类型.
    /// </summary>
    private string idCardTypeCode;

    /// <summary>
    /// 院内地址.
    /// </summary>
    private string address;

    /// <summary>
    /// 证件号码.
    /// </summary>
    private string idCardNumber;

    /// <summary>
    /// 建档医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 创建时间.
    /// </summary>
    private DateTime createTime;

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
    /// 其他属性.
    /// </summary>
    private List<PatientMeta> properties;

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

    public string PatientName
    {
      get
      {
        return patientName;
      }

      set
      {
        patientName = value;
      }
    }

    public string GenderCode
    {
      get
      {
        return genderCode;
      }

      set
      {
        genderCode = value;
      }
    }

    public DateTime BirthDate
    {
      get
      {
        return birthDate;
      }

      set
      {
        birthDate = value;
      }
    }

    public string Mobile
    {
      get
      {
        return mobile;
      }

      set
      {
        mobile = value;
      }
    }

    public string IdCardTypeCode
    {
      get
      {
        return idCardTypeCode;
      }

      set
      {
        idCardTypeCode = value;
      }
    }

    public string Address
    {
      get
      {
        return address;
      }

      set
      {
        address = value;
      }
    }

    public string IdCardNumber
    {
      get
      {
        return idCardNumber;
      }

      set
      {
        idCardNumber = value;
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

    public DateTime CreateTime
    {
      get
      {
        return createTime;
      }

      set
      {
        createTime = value;
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

    public List<PatientMeta> Properties
    {
      get
      {
        return properties;
      }

      set
      {
        properties = value;
      }
    }

  }

  public class PatientMeta
  {

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 属性.
    /// </summary>
    private string propertyName;

    /// <summary>
    /// 值.
    /// </summary>
    private string propertyValue;

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

    public string PropertyName
    {
      get
      {
        return propertyName;
      }

      set
      {
        propertyName = value;
      }
    }

    public string PropertyValue
    {
      get
      {
        return propertyValue;
      }

      set
      {
        propertyValue = value;
      }
    }

  }

  public class PatientAcuteAttack
  {

    /// <summary>
    /// 急性发作史标识.
    /// </summary>
    private string patientAcuteAttackId;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 发作时间.
    /// </summary>
    private DateTime acuteAttackTime;

    /// <summary>
    /// 可能诱因.
    /// </summary>
    private string possibleCause;

    /// <summary>
    /// 发作表现.
    /// </summary>
    private string seizure;

    /// <summary>
    /// 措施.
    /// </summary>
    private string treatment;

    /// <summary>
    /// 处理效果.
    /// </summary>
    private string treatmentEffect;

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

    public string PatientAcuteAttackId
    {
      get
      {
        return patientAcuteAttackId;
      }

      set
      {
        patientAcuteAttackId = value;
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

    public DateTime AcuteAttackTime
    {
      get
      {
        return acuteAttackTime;
      }

      set
      {
        acuteAttackTime = value;
      }
    }

    public string PossibleCause
    {
      get
      {
        return possibleCause;
      }

      set
      {
        possibleCause = value;
      }
    }

    public string Seizure
    {
      get
      {
        return seizure;
      }

      set
      {
        seizure = value;
      }
    }

    public string Treatment
    {
      get
      {
        return treatment;
      }

      set
      {
        treatment = value;
      }
    }

    public string TreatmentEffect
    {
      get
      {
        return treatmentEffect;
      }

      set
      {
        treatmentEffect = value;
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

  public class PatientMenstruation
  {

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientMenstruationId;

    /// <summary>
    /// 初潮年龄.
    /// </summary>
    private int ageOfMenarche;

    /// <summary>
    /// 周期.
    /// </summary>
    private int period;

    /// <summary>
    /// 经期.
    /// </summary>
    private int menstrualPeriod;

    /// <summary>
    /// 经量.
    /// </summary>
    private int menstrualVolume;

    /// <summary>
    /// 最后一次月经日期.
    /// </summary>
    private DateTime lastMenstruationDate;

    /// <summary>
    /// 月经变化情况.
    /// </summary>
    private string menstrualChange;

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

    public string PatientMenstruationId
    {
      get
      {
        return patientMenstruationId;
      }

      set
      {
        patientMenstruationId = value;
      }
    }

    public int AgeOfMenarche
    {
      get
      {
        return ageOfMenarche;
      }

      set
      {
        ageOfMenarche = value;
      }
    }

    public int Period
    {
      get
      {
        return period;
      }

      set
      {
        period = value;
      }
    }

    public int MenstrualPeriod
    {
      get
      {
        return menstrualPeriod;
      }

      set
      {
        menstrualPeriod = value;
      }
    }

    public int MenstrualVolume
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

    public DateTime LastMenstruationDate
    {
      get
      {
        return lastMenstruationDate;
      }

      set
      {
        lastMenstruationDate = value;
      }
    }

    public string MenstrualChange
    {
      get
      {
        return menstrualChange;
      }

      set
      {
        menstrualChange = value;
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

  public class InfertilityHospital
  {

    /// <summary>
    /// 患者.
    /// </summary>
    private string infertilityId;

    /// <summary>
    /// 医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 进院时间.
    /// </summary>
    private DateTime visitDate;

    /// <summary>
    /// 进院类型.
    /// </summary>
    private string visitType;

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

    public string InfertilityId
    {
      get
      {
        return infertilityId;
      }

      set
      {
        infertilityId = value;
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

    public DateTime VisitDate
    {
      get
      {
        return visitDate;
      }

      set
      {
        visitDate = value;
      }
    }

    public string VisitType
    {
      get
      {
        return visitType;
      }

      set
      {
        visitType = value;
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

  public class Outpatient
  {

    /// <summary>
    /// 门诊标识.
    /// </summary>
    private string outpatientId;

    /// <summary>
    /// 门诊号.
    /// </summary>
    private string outpatientNumber;

    /// <summary>
    /// 医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 接诊医生.
    /// </summary>
    private string doctorId;

    /// <summary>
    /// 就诊日期.
    /// </summary>
    private DateTime outpatientDate;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 年龄.
    /// </summary>
    private decimal age;

    /// <summary>
    /// 身高.
    /// </summary>
    private decimal height;

    /// <summary>
    /// 体重.
    /// </summary>
    private decimal weight;

    /// <summary>
    /// 其他选项.
    /// </summary>
    private string options;

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

    public string OutpatientId
    {
      get
      {
        return outpatientId;
      }

      set
      {
        outpatientId = value;
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

    public string DoctorId
    {
      get
      {
        return doctorId;
      }

      set
      {
        doctorId = value;
      }
    }

    public DateTime OutpatientDate
    {
      get
      {
        return outpatientDate;
      }

      set
      {
        outpatientDate = value;
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

    public decimal Age
    {
      get
      {
        return age;
      }

      set
      {
        age = value;
      }
    }

    public decimal Height
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

    public decimal Weight
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

    public string Options
    {
      get
      {
        return options;
      }

      set
      {
        options = value;
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

  public class OutpatientInfantileAsthma
  {

    /// <summary>
    /// 门诊医嘱标识.
    /// </summary>
    private string outpatientInfantileAsthmaId;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 依从性.
    /// </summary>
    private string compliance;

    /// <summary>
    /// 控制水平.
    /// </summary>
    private string controlLevel;

    /// <summary>
    /// 量表名称.
    /// </summary>
    private string scaleName;

    /// <summary>
    /// 得分.
    /// </summary>
    private decimal score;

    /// <summary>
    /// 下次随访时间.
    /// </summary>
    private DateTime followupDate;

    /// <summary>
    /// 方式.
    /// </summary>
    private string followupType;

    /// <summary>
    /// 是否停药.
    /// </summary>
    private Boolean withdrawal;

    /// <summary>
    /// 其他选项.
    /// </summary>
    private string options;

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

    public string OutpatientInfantileAsthmaId
    {
      get
      {
        return outpatientInfantileAsthmaId;
      }

      set
      {
        outpatientInfantileAsthmaId = value;
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

    public string Compliance
    {
      get
      {
        return compliance;
      }

      set
      {
        compliance = value;
      }
    }

    public string ControlLevel
    {
      get
      {
        return controlLevel;
      }

      set
      {
        controlLevel = value;
      }
    }

    public string ScaleName
    {
      get
      {
        return scaleName;
      }

      set
      {
        scaleName = value;
      }
    }

    public decimal Score
    {
      get
      {
        return score;
      }

      set
      {
        score = value;
      }
    }

    public DateTime FollowupDate
    {
      get
      {
        return followupDate;
      }

      set
      {
        followupDate = value;
      }
    }

    public string FollowupType
    {
      get
      {
        return followupType;
      }

      set
      {
        followupType = value;
      }
    }

    public Boolean Withdrawal
    {
      get
      {
        return withdrawal;
      }

      set
      {
        withdrawal = value;
      }
    }

    public string Options
    {
      get
      {
        return options;
      }

      set
      {
        options = value;
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

  public class Prescription
  {

    /// <summary>
    /// 处方标识.
    /// </summary>
    private string prescriptionId;

    /// <summary>
    /// 处方号.
    /// </summary>
    private string prescriptionNumber;

    /// <summary>
    /// 门诊.
    /// </summary>
    private string outpatientId;

    public string PrescriptionId
    {
      get
      {
        return prescriptionId;
      }

      set
      {
        prescriptionId = value;
      }
    }

    public string PrescriptionNumber
    {
      get
      {
        return prescriptionNumber;
      }

      set
      {
        prescriptionNumber = value;
      }
    }

    public string OutpatientId
    {
      get
      {
        return outpatientId;
      }

      set
      {
        outpatientId = value;
      }
    }

  }

  public class MedicalCheckCategory
  {

    /// <summary>
    /// 医疗检查类标识.
    /// </summary>
    private string medicalCheckCategoryId;

    /// <summary>
    /// 上级医疗检查类.
    /// </summary>
    private string parentMedicalCheckCategoryId;

    /// <summary>
    /// 医疗检查类名称.
    /// </summary>
    private string medicalCheckCategoryName;

    /// <summary>
    /// 医疗检查类类型.
    /// </summary>
    private string medicalCheckCategoryType;

    /// <summary>
    /// 排序位置.
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

    public string MedicalCheckCategoryId
    {
      get
      {
        return medicalCheckCategoryId;
      }

      set
      {
        medicalCheckCategoryId = value;
      }
    }

    public string ParentMedicalCheckCategoryId
    {
      get
      {
        return parentMedicalCheckCategoryId;
      }

      set
      {
        parentMedicalCheckCategoryId = value;
      }
    }

    public string MedicalCheckCategoryName
    {
      get
      {
        return medicalCheckCategoryName;
      }

      set
      {
        medicalCheckCategoryName = value;
      }
    }

    public string MedicalCheckCategoryType
    {
      get
      {
        return medicalCheckCategoryType;
      }

      set
      {
        medicalCheckCategoryType = value;
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

  public class MedicalCheckItem
  {

    /// <summary>
    /// 医疗检查项标识.
    /// </summary>
    private string medicalCheckItemId;

    /// <summary>
    /// 医疗检查报告.
    /// </summary>
    private string medicalCheckReportId;

    /// <summary>
    /// 医疗检查项名称.
    /// </summary>
    private string medicalCheckItemName;

    /// <summary>
    /// 值域.
    /// </summary>
    private string values;

    /// <summary>
    /// 排序位置.
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

    public string MedicalCheckItemId
    {
      get
      {
        return medicalCheckItemId;
      }

      set
      {
        medicalCheckItemId = value;
      }
    }

    public string MedicalCheckReportId
    {
      get
      {
        return medicalCheckReportId;
      }

      set
      {
        medicalCheckReportId = value;
      }
    }

    public string MedicalCheckItemName
    {
      get
      {
        return medicalCheckItemName;
      }

      set
      {
        medicalCheckItemName = value;
      }
    }

    public string Values
    {
      get
      {
        return values;
      }

      set
      {
        values = value;
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

  public class MedicalCheckReport
  {

    /// <summary>
    /// 医疗检验项标识.
    /// </summary>
    private string medicalCheckReportId;

    /// <summary>
    /// 医疗检验类.
    /// </summary>
    private string medicalCheckCategoryId;

    /// <summary>
    /// 报告名称.
    /// </summary>
    private string medicalCheckReportName;

    /// <summary>
    /// 报告类型.
    /// </summary>
    private string medicalCheckReportType;

    /// <summary>
    /// 结论格式.
    /// </summary>
    private string resultFormat;

    /// <summary>
    /// 排序位置.
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

    public string MedicalCheckReportId
    {
      get
      {
        return medicalCheckReportId;
      }

      set
      {
        medicalCheckReportId = value;
      }
    }

    public string MedicalCheckCategoryId
    {
      get
      {
        return medicalCheckCategoryId;
      }

      set
      {
        medicalCheckCategoryId = value;
      }
    }

    public string MedicalCheckReportName
    {
      get
      {
        return medicalCheckReportName;
      }

      set
      {
        medicalCheckReportName = value;
      }
    }

    public string MedicalCheckReportType
    {
      get
      {
        return medicalCheckReportType;
      }

      set
      {
        medicalCheckReportType = value;
      }
    }

    public string ResultFormat
    {
      get
      {
        return resultFormat;
      }

      set
      {
        resultFormat = value;
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

  public class MedicalCheckResult
  {

    /// <summary>
    /// 医疗检验报告标识.
    /// </summary>
    private string medicalCheckResultId;

    /// <summary>
    /// 医疗检验报告标识.
    /// </summary>
    private string medicalCheckReportId;

    /// <summary>
    /// 来源标识.
    /// </summary>
    private string sourceId;

    /// <summary>
    /// 来源类型.
    /// </summary>
    private string sourceType;

    /// <summary>
    /// 医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 部门.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 检验结果.
    /// </summary>
    private string result;

    /// <summary>
    /// 报告时间.
    /// </summary>
    private DateTime reportTime;

    /// <summary>
    /// 报告人.
    /// </summary>
    private string reporterDoctorId;

    /// <summary>
    /// 审核时间.
    /// </summary>
    private DateTime auditTime;

    /// <summary>
    /// 审核人.
    /// </summary>
    private string auditorDoctorId;

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
    /// 结果明细.
    /// </summary>
    private List<MedicalCheckDetail> medicalCheckDetails;

    public string MedicalCheckResultId
    {
      get
      {
        return medicalCheckResultId;
      }

      set
      {
        medicalCheckResultId = value;
      }
    }

    public string MedicalCheckReportId
    {
      get
      {
        return medicalCheckReportId;
      }

      set
      {
        medicalCheckReportId = value;
      }
    }

    public string SourceId
    {
      get
      {
        return sourceId;
      }

      set
      {
        sourceId = value;
      }
    }

    public string SourceType
    {
      get
      {
        return sourceType;
      }

      set
      {
        sourceType = value;
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

    public string ReporterDoctorId
    {
      get
      {
        return reporterDoctorId;
      }

      set
      {
        reporterDoctorId = value;
      }
    }

    public DateTime AuditTime
    {
      get
      {
        return auditTime;
      }

      set
      {
        auditTime = value;
      }
    }

    public string AuditorDoctorId
    {
      get
      {
        return auditorDoctorId;
      }

      set
      {
        auditorDoctorId = value;
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

    public List<MedicalCheckDetail> MedicalCheckDetails
    {
      get
      {
        return medicalCheckDetails;
      }

      set
      {
        medicalCheckDetails = value;
      }
    }

  }

  public class MedicalCheckDetail
  {

    /// <summary>
    /// 医疗检验报告标识.
    /// </summary>
    private string medicalCheckResultId;

    /// <summary>
    /// 医疗检验项标识.
    /// </summary>
    private string medicalCheckItemId;

    /// <summary>
    /// 检验结果.
    /// </summary>
    private string value;

    /// <summary>
    /// 排序位置.
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

    public string MedicalCheckResultId
    {
      get
      {
        return medicalCheckResultId;
      }

      set
      {
        medicalCheckResultId = value;
      }
    }

    public string MedicalCheckItemId
    {
      get
      {
        return medicalCheckItemId;
      }

      set
      {
        medicalCheckItemId = value;
      }
    }

    public string Value
    {
      get
      {
        return value;
      }

      set
      {
        value = value;
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

  public class MedicalCheckAdvice
  {

    /// <summary>
    /// 医疗检验报告标识.
    /// </summary>
    private string medicalCheckAdviceId;

    /// <summary>
    /// 报告时间.
    /// </summary>
    private DateTime adviceTime;

    /// <summary>
    /// 报告人.
    /// </summary>
    private string doctorId;

    /// <summary>
    /// 检验结果.
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

    public string MedicalCheckAdviceId
    {
      get
      {
        return medicalCheckAdviceId;
      }

      set
      {
        medicalCheckAdviceId = value;
      }
    }

    public DateTime AdviceTime
    {
      get
      {
        return adviceTime;
      }

      set
      {
        adviceTime = value;
      }
    }

    public string DoctorId
    {
      get
      {
        return doctorId;
      }

      set
      {
        doctorId = value;
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

  public class MedicalConsultation
  {

    /// <summary>
    /// 医疗会诊标识.
    /// </summary>
    private string medicalConsultationId;

    /// <summary>
    /// 档案标识.
    /// </summary>
    private string archiveId;

    /// <summary>
    /// 档案类型.
    /// </summary>
    private string archiveType;

    /// <summary>
    /// 发起医生.
    /// </summary>
    private string consulteeDoctorId;

    /// <summary>
    /// 排期医生.
    /// </summary>
    private string operatorDoctorId;

    /// <summary>
    /// 创建时间.
    /// </summary>
    private DateTime createTime;

    /// <summary>
    /// 会诊时间.
    /// </summary>
    private DateTime consultTime;

    /// <summary>
    /// 会诊原因.
    /// </summary>
    private string reason;

    /// <summary>
    /// 会诊反馈.
    /// </summary>
    private string feedback;

    /// <summary>
    /// 状态.
    /// </summary>
    private string status;

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
    /// 会诊医生.
    /// </summary>
    private List<MedicalConsultationDoctor> consultants;

    public string MedicalConsultationId
    {
      get
      {
        return medicalConsultationId;
      }

      set
      {
        medicalConsultationId = value;
      }
    }

    public string ArchiveId
    {
      get
      {
        return archiveId;
      }

      set
      {
        archiveId = value;
      }
    }

    public string ArchiveType
    {
      get
      {
        return archiveType;
      }

      set
      {
        archiveType = value;
      }
    }

    public string ConsulteeDoctorId
    {
      get
      {
        return consulteeDoctorId;
      }

      set
      {
        consulteeDoctorId = value;
      }
    }

    public string OperatorDoctorId
    {
      get
      {
        return operatorDoctorId;
      }

      set
      {
        operatorDoctorId = value;
      }
    }

    public DateTime CreateTime
    {
      get
      {
        return createTime;
      }

      set
      {
        createTime = value;
      }
    }

    public DateTime ConsultTime
    {
      get
      {
        return consultTime;
      }

      set
      {
        consultTime = value;
      }
    }

    public string Reason
    {
      get
      {
        return reason;
      }

      set
      {
        reason = value;
      }
    }

    public string Feedback
    {
      get
      {
        return feedback;
      }

      set
      {
        feedback = value;
      }
    }

    public string Status
    {
      get
      {
        return status;
      }

      set
      {
        status = value;
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

    public List<MedicalConsultationDoctor> Consultants
    {
      get
      {
        return consultants;
      }

      set
      {
        consultants = value;
      }
    }

  }

  public class MedicalConsultationDoctor
  {

    /// <summary>
    /// 医疗会诊标识.
    /// </summary>
    private string medicalConsultationId;

    /// <summary>
    /// 医生标识.
    /// </summary>
    private string doctorId;

    /// <summary>
    /// 会诊意见.
    /// </summary>
    private string advice;

    /// <summary>
    /// 意见时间.
    /// </summary>
    private DateTime adviceTime;

    public string MedicalConsultationId
    {
      get
      {
        return medicalConsultationId;
      }

      set
      {
        medicalConsultationId = value;
      }
    }

    public string DoctorId
    {
      get
      {
        return doctorId;
      }

      set
      {
        doctorId = value;
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

    public DateTime AdviceTime
    {
      get
      {
        return adviceTime;
      }

      set
      {
        adviceTime = value;
      }
    }

  }

  public class MedicalReferral
  {

    /// <summary>
    /// 医疗转诊标识.
    /// </summary>
    private string medicalReferralId;

    /// <summary>
    /// 档案标识.
    /// </summary>
    private string archiveId;

    /// <summary>
    /// 档案类型.
    /// </summary>
    private string archiveType;

    /// <summary>
    /// 来源医院.
    /// </summary>
    private string sourceHospitalHospitalId;

    /// <summary>
    /// 目标医院.
    /// </summary>
    private string targetHospitalHospitalId;

    /// <summary>
    /// 发起日期.
    /// </summary>
    private DateTime createDate;

    /// <summary>
    /// 转诊日期.
    /// </summary>
    private DateTime referralDate;

    /// <summary>
    /// 转诊原因.
    /// </summary>
    private string reason;

    /// <summary>
    /// 反馈意见.
    /// </summary>
    private string feedback;

    /// <summary>
    /// 转诊状态.
    /// </summary>
    private string status;

    /// <summary>
    /// 修改者标识.
    /// </summary>
    private string modifierId;

    /// <summary>
    /// 修改者类型.
    /// </summary>
    private string modifierType;

    /// <summary>
    /// 最近修改时间.
    /// </summary>
    private DateTime lastModifiedTime;

    public string MedicalReferralId
    {
      get
      {
        return medicalReferralId;
      }

      set
      {
        medicalReferralId = value;
      }
    }

    public string ArchiveId
    {
      get
      {
        return archiveId;
      }

      set
      {
        archiveId = value;
      }
    }

    public string ArchiveType
    {
      get
      {
        return archiveType;
      }

      set
      {
        archiveType = value;
      }
    }

    public string SourceHospitalHospitalId
    {
      get
      {
        return sourceHospitalHospitalId;
      }

      set
      {
        sourceHospitalHospitalId = value;
      }
    }

    public string TargetHospitalHospitalId
    {
      get
      {
        return targetHospitalHospitalId;
      }

      set
      {
        targetHospitalHospitalId = value;
      }
    }

    public DateTime CreateDate
    {
      get
      {
        return createDate;
      }

      set
      {
        createDate = value;
      }
    }

    public DateTime ReferralDate
    {
      get
      {
        return referralDate;
      }

      set
      {
        referralDate = value;
      }
    }

    public string Reason
    {
      get
      {
        return reason;
      }

      set
      {
        reason = value;
      }
    }

    public string Feedback
    {
      get
      {
        return feedback;
      }

      set
      {
        feedback = value;
      }
    }

    public string Status
    {
      get
      {
        return status;
      }

      set
      {
        status = value;
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

  public class MedicalReferralLog
  {

    /// <summary>
    /// 医疗转诊标识.
    /// </summary>
    private string medicalReferralId;

    /// <summary>
    /// 状态改变时间.
    /// </summary>
    private DateTime statusChangedTime;

    /// <summary>
    /// 意见.
    /// </summary>
    private string note;

    /// <summary>
    /// 转诊状态.
    /// </summary>
    private string status;

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

    public string MedicalReferralId
    {
      get
      {
        return medicalReferralId;
      }

      set
      {
        medicalReferralId = value;
      }
    }

    public DateTime StatusChangedTime
    {
      get
      {
        return statusChangedTime;
      }

      set
      {
        statusChangedTime = value;
      }
    }

    public string Note
    {
      get
      {
        return note;
      }

      set
      {
        note = value;
      }
    }

    public string Status
    {
      get
      {
        return status;
      }

      set
      {
        status = value;
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

  public class MedicalSummary
  {

    /// <summary>
    /// 医疗小结标识.
    /// </summary>
    private string medicalSummaryId;

    /// <summary>
    /// 档案标识.
    /// </summary>
    private string archiveId;

    /// <summary>
    /// 档案类型.
    /// </summary>
    private string archiveType;

    /// <summary>
    /// 报告科室.
    /// </summary>
    private string clinicId;

    /// <summary>
    /// 来源医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 小结时间.
    /// </summary>
    private DateTime summaryTime;

    /// <summary>
    /// 小结内容.
    /// </summary>
    private string content;

    /// <summary>
    /// 其他选项.
    /// </summary>
    private string options;

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

    public string MedicalSummaryId
    {
      get
      {
        return medicalSummaryId;
      }

      set
      {
        medicalSummaryId = value;
      }
    }

    public string ArchiveId
    {
      get
      {
        return archiveId;
      }

      set
      {
        archiveId = value;
      }
    }

    public string ArchiveType
    {
      get
      {
        return archiveType;
      }

      set
      {
        archiveType = value;
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

    public DateTime SummaryTime
    {
      get
      {
        return summaryTime;
      }

      set
      {
        summaryTime = value;
      }
    }

    public string Content
    {
      get
      {
        return content;
      }

      set
      {
        content = value;
      }
    }

    public string Options
    {
      get
      {
        return options;
      }

      set
      {
        options = value;
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

  public class PatientFollowup
  {

    /// <summary>
    /// 患者随访标识.
    /// </summary>
    private string patientFollowupId;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 问卷.
    /// </summary>
    private string questionaire;

    public string PatientFollowupId
    {
      get
      {
        return patientFollowupId;
      }

      set
      {
        patientFollowupId = value;
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

    public string Questionaire
    {
      get
      {
        return questionaire;
      }

      set
      {
        questionaire = value;
      }
    }

  }

  public class Medicine
  {

    /// <summary>
    /// 药品标识.
    /// </summary>
    private string medicineId;

    /// <summary>
    /// 药品名称.
    /// </summary>
    private string medicineName;

    /// <summary>
    /// 品牌.
    /// </summary>
    private string brand;

    /// <summary>
    /// 制造商.
    /// </summary>
    private string manufacturerOrganizationId;

    /// <summary>
    /// 药品规格.
    /// </summary>
    private string specification;

    /// <summary>
    /// 说明.
    /// </summary>
    private string note;

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

    public string MedicineName
    {
      get
      {
        return medicineName;
      }

      set
      {
        medicineName = value;
      }
    }

    public string Brand
    {
      get
      {
        return brand;
      }

      set
      {
        brand = value;
      }
    }

    public string ManufacturerOrganizationId
    {
      get
      {
        return manufacturerOrganizationId;
      }

      set
      {
        manufacturerOrganizationId = value;
      }
    }

    public string Specification
    {
      get
      {
        return specification;
      }

      set
      {
        specification = value;
      }
    }

    public string Note
    {
      get
      {
        return note;
      }

      set
      {
        note = value;
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

  public class MedicineFrequency
  {

    /// <summary>
    /// 药品使用频率标识.
    /// </summary>
    private string medicineFrequencyId;

    /// <summary>
    /// 药品.
    /// </summary>
    private string medicineId;

    /// <summary>
    /// 前置条件.
    /// </summary>
    private string prerequisite;

    /// <summary>
    /// 频率.
    /// </summary>
    private string frequency;

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

    public string MedicineFrequencyId
    {
      get
      {
        return medicineFrequencyId;
      }

      set
      {
        medicineFrequencyId = value;
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

    public string Prerequisite
    {
      get
      {
        return prerequisite;
      }

      set
      {
        prerequisite = value;
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

  public class PatientMedicine
  {

    /// <summary>
    /// 患者标识.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 药品标识.
    /// </summary>
    private string medicineId;

    /// <summary>
    /// 处方.
    /// </summary>
    private string prescriptionId;

    /// <summary>
    /// 开药时间.
    /// </summary>
    private DateTime prescriptionTime;

    /// <summary>
    /// 数量.
    /// </summary>
    private decimal amount;

    /// <summary>
    /// 单位.
    /// </summary>
    private string unit;

    /// <summary>
    /// 用法.
    /// </summary>
    private string dose;

    /// <summary>
    /// 频率.
    /// </summary>
    private string doseFrequency;

    /// <summary>
    /// 用药时长.
    /// </summary>
    private string duration;

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

    public string PrescriptionId
    {
      get
      {
        return prescriptionId;
      }

      set
      {
        prescriptionId = value;
      }
    }

    public DateTime PrescriptionTime
    {
      get
      {
        return prescriptionTime;
      }

      set
      {
        prescriptionTime = value;
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

    public string Dose
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

    public string DoseFrequency
    {
      get
      {
        return doseFrequency;
      }

      set
      {
        doseFrequency = value;
      }
    }

    public string Duration
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

  public class PhysicalExamination
  {

    /// <summary>
    /// 体格检查标识.
    /// </summary>
    private string physicalExaminationId;

    /// <summary>
    /// 体格检查名称.
    /// </summary>
    private string physicalExaminationName;

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
    /// 体格检查项目.
    /// </summary>
    private List<PhysicalExaminationItem> physicalExaminationItems;

    public string PhysicalExaminationId
    {
      get
      {
        return physicalExaminationId;
      }

      set
      {
        physicalExaminationId = value;
      }
    }

    public string PhysicalExaminationName
    {
      get
      {
        return physicalExaminationName;
      }

      set
      {
        physicalExaminationName = value;
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

    public List<PhysicalExaminationItem> PhysicalExaminationItems
    {
      get
      {
        return physicalExaminationItems;
      }

      set
      {
        physicalExaminationItems = value;
      }
    }

  }

  public class PhysicalExaminationItem
  {

    /// <summary>
    /// 体格检查项目标识.
    /// </summary>
    private string physicalExaminationItemId;

    /// <summary>
    /// 体格检查项目名称.
    /// </summary>
    private string physicalExaminationItemName;

    /// <summary>
    /// 体格检查标识.
    /// </summary>
    private string physicalExaminationId;

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

    public string PhysicalExaminationItemId
    {
      get
      {
        return physicalExaminationItemId;
      }

      set
      {
        physicalExaminationItemId = value;
      }
    }

    public string PhysicalExaminationItemName
    {
      get
      {
        return physicalExaminationItemName;
      }

      set
      {
        physicalExaminationItemName = value;
      }
    }

    public string PhysicalExaminationId
    {
      get
      {
        return physicalExaminationId;
      }

      set
      {
        physicalExaminationId = value;
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

  public class PhysicalExaminationResult
  {

    /// <summary>
    /// 体格结果标识.
    /// </summary>
    private string physicalExaminationResultId;

    /// <summary>
    /// 体格检查.
    /// </summary>
    private string physicalExaminationId;

    /// <summary>
    /// 患者.
    /// </summary>
    private string patientId;

    /// <summary>
    /// 检查时间.
    /// </summary>
    private DateTime examinationTime;

    /// <summary>
    /// 检查结论.
    /// </summary>
    private string result;

    public string PhysicalExaminationResultId
    {
      get
      {
        return physicalExaminationResultId;
      }

      set
      {
        physicalExaminationResultId = value;
      }
    }

    public string PhysicalExaminationId
    {
      get
      {
        return physicalExaminationId;
      }

      set
      {
        physicalExaminationId = value;
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

    public DateTime ExaminationTime
    {
      get
      {
        return examinationTime;
      }

      set
      {
        examinationTime = value;
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

  public class Pregnant
  {

    /// <summary>
    /// 孕妇标识.
    /// </summary>
    private string pregnantId;

    /// <summary>
    /// 孕妇姓名.
    /// </summary>
    private string pregnantName;

    /// <summary>
    /// 性别.
    /// </summary>
    private string genderCode;

    /// <summary>
    /// 出生日期.
    /// </summary>
    private DateTime birthDate;

    /// <summary>
    /// 手机号码.
    /// </summary>
    private string mobile;

    /// <summary>
    /// 证件类型.
    /// </summary>
    private string idCardTypeCode;

    /// <summary>
    /// 证件号码.
    /// </summary>
    private string idCardNumber;

    /// <summary>
    /// 详细地址.
    /// </summary>
    private string address;

    /// <summary>
    /// 建档医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 创建时间.
    /// </summary>
    private DateTime createTime;

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

    public string PregnantName
    {
      get
      {
        return pregnantName;
      }

      set
      {
        pregnantName = value;
      }
    }

    public string GenderCode
    {
      get
      {
        return genderCode;
      }

      set
      {
        genderCode = value;
      }
    }

    public DateTime BirthDate
    {
      get
      {
        return birthDate;
      }

      set
      {
        birthDate = value;
      }
    }

    public string Mobile
    {
      get
      {
        return mobile;
      }

      set
      {
        mobile = value;
      }
    }

    public string IdCardTypeCode
    {
      get
      {
        return idCardTypeCode;
      }

      set
      {
        idCardTypeCode = value;
      }
    }

    public string IdCardNumber
    {
      get
      {
        return idCardNumber;
      }

      set
      {
        idCardNumber = value;
      }
    }

    public string Address
    {
      get
      {
        return address;
      }

      set
      {
        address = value;
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

    public DateTime CreateTime
    {
      get
      {
        return createTime;
      }

      set
      {
        createTime = value;
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

  public class PregnantSpouse
  {

    /// <summary>
    /// 孕妇配偶标识.
    /// </summary>
    private string pregnantSpouseId;

    /// <summary>
    /// 孕妇配偶姓名.
    /// </summary>
    private string pregnantSpouseName;

    /// <summary>
    /// 孕妇标识.
    /// </summary>
    private string pregnantId;

    /// <summary>
    /// 性别.
    /// </summary>
    private string genderCode;

    /// <summary>
    /// 出生日期.
    /// </summary>
    private DateTime birthDate;

    /// <summary>
    /// 手机号码.
    /// </summary>
    private string mobile;

    /// <summary>
    /// 证件类型.
    /// </summary>
    private string idCardTypeCode;

    /// <summary>
    /// 证件号码.
    /// </summary>
    private string idCardNumber;

    /// <summary>
    /// 详细地址.
    /// </summary>
    private string address;

    /// <summary>
    /// 建档医院.
    /// </summary>
    private string hospitalId;

    /// <summary>
    /// 创建时间.
    /// </summary>
    private DateTime createTime;

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

    public string PregnantSpouseId
    {
      get
      {
        return pregnantSpouseId;
      }

      set
      {
        pregnantSpouseId = value;
      }
    }

    public string PregnantSpouseName
    {
      get
      {
        return pregnantSpouseName;
      }

      set
      {
        pregnantSpouseName = value;
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

    public string GenderCode
    {
      get
      {
        return genderCode;
      }

      set
      {
        genderCode = value;
      }
    }

    public DateTime BirthDate
    {
      get
      {
        return birthDate;
      }

      set
      {
        birthDate = value;
      }
    }

    public string Mobile
    {
      get
      {
        return mobile;
      }

      set
      {
        mobile = value;
      }
    }

    public string IdCardTypeCode
    {
      get
      {
        return idCardTypeCode;
      }

      set
      {
        idCardTypeCode = value;
      }
    }

    public string IdCardNumber
    {
      get
      {
        return idCardNumber;
      }

      set
      {
        idCardNumber = value;
      }
    }

    public string Address
    {
      get
      {
        return address;
      }

      set
      {
        address = value;
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

    public DateTime CreateTime
    {
      get
      {
        return createTime;
      }

      set
      {
        createTime = value;
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
