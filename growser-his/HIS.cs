using System;
using System.Collections.Generic;

namespace Growser.HIS
{

  public class MedicalDocumentCategory
  {

    /// <summary>
    /// 医疗文档分类标识.
    /// </summary>
    private string medicalDocumentCategoryId;

    public string MedicalDocumentCategoryId
    {
      get
      {
        return medicalDocumentCategoryId;
      }

      set
      {
        medicalDocumentCategoryId = value;
      }
    }

  }

  public class MedicalDocument
  {

    /// <summary>
    /// 医疗文档标识.
    /// </summary>
    private string medicalDocumentId;

    public string MedicalDocumentId
    {
      get
      {
        return medicalDocumentId;
      }

      set
      {
        medicalDocumentId = value;
      }
    }

  }

  public class MedicalReportCategory
  {

    /// <summary>
    /// 医疗报告分类标识.
    /// </summary>
    private string medicalReportCategoryId;

    public string MedicalReportCategoryId
    {
      get
      {
        return medicalReportCategoryId;
      }

      set
      {
        medicalReportCategoryId = value;
      }
    }

  }

  public class MedicalTestReport
  {

    /// <summary>
    /// 检查报告标识.
    /// </summary>
    private string medicalTestReportId;

    /// <summary>
    /// 检查报告名称.
    /// </summary>
    private string medicalTestReportName;

    /// <summary>
    /// 报告类别.
    /// </summary>
    private string medicalReportCategoryId;

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

    public string MedicalTestReportName
    {
      get
      {
        return medicalTestReportName;
      }

      set
      {
        medicalTestReportName = value;
      }
    }

    public string MedicalReportCategoryId
    {
      get
      {
        return medicalReportCategoryId;
      }

      set
      {
        medicalReportCategoryId = value;
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

  public class MedicalTestItem
  {

    /// <summary>
    /// 检查项目标识.
    /// </summary>
    private string medicalTestItemId;

    /// <summary>
    /// 检验项目名称.
    /// </summary>
    private string medicalTestItemName;

    /// <summary>
    /// 检查报告.
    /// </summary>
    private string medicalTestReportId;

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

    public string MedicalTestItemId
    {
      get
      {
        return medicalTestItemId;
      }

      set
      {
        medicalTestItemId = value;
      }
    }

    public string MedicalTestItemName
    {
      get
      {
        return medicalTestItemName;
      }

      set
      {
        medicalTestItemName = value;
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

  public class MedicalLaboratoryReport
  {

    /// <summary>
    /// 检验报告标识.
    /// </summary>
    private string medicalLaboratoryReportId;

    /// <summary>
    /// 检验报告名称.
    /// </summary>
    private string medicalLaboratoryReportName;

    /// <summary>
    /// 报告类别.
    /// </summary>
    private string medicalReportCategoryId;

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

    public string MedicalLaboratoryReportId
    {
      get
      {
        return medicalLaboratoryReportId;
      }

      set
      {
        medicalLaboratoryReportId = value;
      }
    }

    public string MedicalLaboratoryReportName
    {
      get
      {
        return medicalLaboratoryReportName;
      }

      set
      {
        medicalLaboratoryReportName = value;
      }
    }

    public string MedicalReportCategoryId
    {
      get
      {
        return medicalReportCategoryId;
      }

      set
      {
        medicalReportCategoryId = value;
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

  public class MedicalLaboratoryItem
  {

    /// <summary>
    /// 检验项目标识.
    /// </summary>
    private string medicalLaboratoryItemId;

    /// <summary>
    /// 检验项目名称.
    /// </summary>
    private string medicalLaboratoryItemName;

    /// <summary>
    /// 检验报告.
    /// </summary>
    private string medicalLaboratoryReportId;

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

    public string MedicalLaboratoryItemId
    {
      get
      {
        return medicalLaboratoryItemId;
      }

      set
      {
        medicalLaboratoryItemId = value;
      }
    }

    public string MedicalLaboratoryItemName
    {
      get
      {
        return medicalLaboratoryItemName;
      }

      set
      {
        medicalLaboratoryItemName = value;
      }
    }

    public string MedicalLaboratoryReportId
    {
      get
      {
        return medicalLaboratoryReportId;
      }

      set
      {
        medicalLaboratoryReportId = value;
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
