namespace excelUpdate50kUsers;

public class ConstEnums
{
    public enum DepartmentName
    {
        Sales,

        Accounting,

        Marketing,

        Finance,

        Operations,

        [Display(Name = "Human Resources")] HumanResources,

        It,

        Management,

        Purchasing,

        [Display(Name = "Research and Development")]
        ResearchAndDevelopment,

        [Display(Name = "Product Management")] ProductManagement,

        [Display(Name = "UI/UX Design")] UiUxDesign,

        [Display(Name = "Program Management")] ProgramManagement,

        QualityAssurance,

        Development,

        Documentation,

        [Display(Name = "Customer Support")] CustomerSupport
    }

    public enum Country
    {
        Canada,

        India,

        UnitedKingdom,

        UnitedStates
    }
    
    
    #region Dept Employee Titles
    
    public string[] salesJobTitlesArr = { "Sales Engineer", "Sales Supervisor", "Senior Sales Representative", "Junior Sales Representative",
        "Logistics Engineer", "Logistics Supervisor", "Senior Logistics Representative", "Junior Logistics Representative" };
    
    public string[] accountingJobTitlesArr = { "Senior Accountant", "Junior Accountant", "Senior Tax Accountant", "Junior Tax Accountant", 
        "Senior Payroll Specialist", "Junior Payroll Specialist", "Senior Accounts Payable Specialist", "Junior Accounts Payable Specialist" };
    
    public string[] marketingJobTitlesArr = { "Marketing Technologist", "Copy Writer", "Product Marketing Specialist", "Product Analyst", 
        "Digital Marketing Analyst", "Social Media Marketing Analyst", "SEO Consultant", "SEO Engineer" };
    
    public string[] financeJobTitlesArr = { "Senior Cost Analyst", "Junior Cost Analyst", "Senior Budget Analyst", "Junior Budget Analyst", 
        "Senior Financial Analyst", "Junior Financial Analyst", "Senior Reporting Analyst", "Junior Reporting Analyst" };
    
    public string[] operationsJobTitlesArr = { "Inventory Specialist", "Demand Planner", "Purchasing Agent", "Procurement Specialist", 
        "Safety Coordinator", "Environmental Health Specialist", "Maintenance Technician", "Facilities Engineer" };
    
    public string[] humanResourcesJobTitlesArr = { "HR Specialist", "HR Generalist", "Training Coordinator", "Benefits Coordinator", 
        "Recruit Lead", "Recruiter", "Placement Coordinator", "Assignment Coordinator" };
    
    public string[] itJobTitlesArr = { "Senior Information Architect", "Junior Information Architect", "Senior Data Architect", 
        "Junior Data Architect", "Security Analyst", "Security Engineer", "Senior Network Engineer", "Junior Network Engineer" };
    
    public string[] managementJobTitlesArr = { "Change Management Specialist", "Demand Planner", "Project Analyst", "Project Coordinator", 
        "Quality Control Specialist", "Quality Assurance Specialist", "Business Analyst", "Process Improvement Specialist" };
    
    public string[] purchasingJobTitlesArr = { "Purchasing Assistant", "Purchasing Analyst", "Spend Analyst", "Budget Analyst", 
        "Sourcing Specialist", "Sourcing Analyst", "Procurement Specialist", "Procurement Systems Administrator" };
    
    public string[] researchAndDevelopmentJobTitlesArr = { "Research Scientist", "Research Technician", "Design Engineer", 
        "Prototype Specialist", "Senior Development Engineer", "Junior Development Engineer", "Intellectual Property Manager", 
        "Licensing Specialist" };
    
    public string[] productManagementJobTitlesArr = { "Product Development Engineer", "Product Trainer", "Pricing Analyst", 
        "Product Analyst", "Production Planner", "Cross-Functional Team Leader", "Product Marketing Specialist", 
        "Product Marketing Analyst" };
    
    public string[] uiUxDesignJobTitlesArr = { "UI Design Technologist", "UI Developer", "UI Product Designer", 
        "UI Usability Tester", "UX Design Technologist", "UX Developer", "UX Product Designer", "UX Usability Tester" };
    
    public string[] programManagementJobTitlesArr = { "Program Management Specialist", "Risk Management Specialist", 
        "Business Analyst", "Financial Analyst", "Assistant Project Manager", "Technical Project Manager", "Data Analyst", 
        "Technical Writer" };
    
    public string[] qualityAssuranceJobTitlesArr = { "Quality Inspector", "Quality Auditor", "Quality Assurance Analyst", 
        "Quality Lead", "Automation Tester", "Performance Tester", "Test Lead", "Test Engineer" };
    
    public string[] developmentJobTitlesArr = { "Software Engineer", "Senior Developer", "Full Stack Developer",
        "Front End Developer", "Senior Database Administrator", "Junior Database Administrator",
        " Senior Technical Support Engineer", "Junior Technical Support Engineer" };
    
    public string[] documentationJobTitlesArr = { "Senior Technical Writer", "Junior Technical Writer", 
        "Senior Content Developer", "Junior Content Developer", "Senior Document Control Specialist", 
        "Junior Document Control Specialist", "Content Operations Specialist", "Training Operations Specialist" };
    
    public string[] customerSupportJobTitlesArr = { "Senior Customer Support Specialist", 
        "Junior Customer Support Specialist", "Senior Support Engineer", "Junior Support Engineer", 
        "Senior Customer Success Specialist", "Junior Customer Success Specialist", "Support Operations Engineer", 
        "Support Operations Specialist" };
    
    #endregion
    
    
    #region The Big Boys of the departments

    public ArrayList theBigBoysOfSalesArrLis = new ArrayList() { "Manager Logistics Representative", "Manager Logistics Supervisor", 
        "Manager Sales Representative", "Manager Sales Supervisor", "GM Logistics Supervisor", "GM Sales Supervisor", "Sales Director" };
    
    public ArrayList theBigBoysOfAccountingArrLis = new ArrayList() { "Accounts Payable Manager", "Payroll Manager", "Tax Manager", 
        "Accounting Manager", "GM Payroll", "GM Accounting", "Accounting Director" };
    
    public ArrayList theBigBoysOfMarketingArrLis = new ArrayList() { "SEO Manager", "Social Media Manager", "Product Manager", 
        "Marketing Manager", "GM Digital Marketing", "GM Marketing", "Marketing Director" };
    
    public ArrayList theBigBoysOfFinanceArrLis = new ArrayList() { "Finance Reporting Manager", "Finance Analysis Manager", 
        "Finance Budget Manager", "Finance Planning Manager", "GM Finance Analysis", "GM Finance Planning", "Finance Director" };
    
    public ArrayList theBigBoysOfOperationsArrLis = new ArrayList() { "Maintanance Manager", "Safety Manager", "Purchasing Manager", 
        "Inventory Manager", "GM Facilities", "GM Supply Chain", "Operations Director" };
    
    public ArrayList theBigBoysOfHumanResourcesArrLis = new ArrayList() { "Recruitment Coordinator Manager", "Recruitment Manager", 
        "HR Coordinator Manager", "HR Manager", "GM Recruitment", "GM HR", "HR Director" };
    
    public ArrayList theBigBoysOfITArrLis = new ArrayList() { "Systems Administrator Manager", "IT Security Manager",
        "Infrastructure Manager", "IT Manager", "GM IT Security", "GM IT", "IT Director" };
    
    public ArrayList theBigBoysOfManagementArrLis = new ArrayList() { "Business Process Management", "Quality Management Manager",
        "Project Management Manager", "Management Manager", "GM Business Process Management", "GM Management", "Management Director" };
    
    public ArrayList theBigBoysOfPurchasingArrLis = new ArrayList() { "Procurement Operations Manager", "Strategic Sourcing Manager", 
        "Spend Analysis Manager", "Purchasing Manager", "GM Inventory", "GM Purchasing", "Purchasing Director" };
    
    public ArrayList theBigBoysOfResearchandDevelopmentArrLis = new ArrayList() { "Technology Transfer Manager", "Development Manager",
        "Project Manager", "Research Manager", "GM Development", "GM Research", "Research and Development Director" };
    
    public ArrayList theBigBoysOfProductManagementArrLis = new ArrayList() { "Digital Marketing Manager", "Product Operations Manager", 
        "Brand Manager", "Product Development Manager", "GM Product Operations", "GM Product Management", "Product Management Director" };
    
    public ArrayList theBigBoysOfUiUxDesignArrLis = new ArrayList() { "UX Product Design Manager", "UX Design Manager",
        "UI Product Design Manager", "UI Design Manager", "GM UX Design", "GM UI Design", "UI/UX Design Director" };
    
    public ArrayList theBigBoysOfProgramManagementArrLis = new ArrayList() { "Business Operations Manager", "Project Manager",
        "Portfolio Manager", "Program Manager", "GM Project Management", "GM Program Management", "Program Management Director" };
    
    public ArrayList theBigBoysOfQualityAssuranceArrLis = new ArrayList() { "Senior Test Manager", "Test Manager", "Senior QA Manager", 
        "Quality Manager", "GM Test", "GM QA", "QA Director" };
    
    public ArrayList theBigBoysOfDevelopmentArrLis = new ArrayList() { "Technical Support Manager", "Database Manager", 
        "Web Development Manager", "Software Development Manager", "GM Database", "GM Development", "Development Director" };
    
    public ArrayList theBigBoysOfDocumentationArrLis = new ArrayList() { "Content Operations Manager", "Documentation Operations Manager",
        "Content Strategy Manager", "Documentation Strategy Manager", "GM Documentation Operations", "GM Documentation Strategy", 
        "Documentation Director" };
    
    public ArrayList theBigBoysOfCustomerSupportArrLis = new ArrayList() { "Support Operations Manager", "Customer Success Manager", 
        "Technical Support Manager", "Customer Support Manager", "GM Customer Success", "GM Customer Support Operations",
        "Customer Support Director" };
    
    #endregion


    #region Supervisors Dict

    public Dictionary<string, string[]> salesSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Sales Director"}},
        {"Sales Director", new string[]{"GM Sales Supervisor", "GM Logistics Supervisor"}},
        {"GM Sales Supervisor", new string[]{"Manager Sales Supervisor", "Manager Sales Representative"}},
        {"GM Logistics Supervisor", new string[]{"Manager Logistics Supervisor", "Manager Logistics Representative"}},
        {"Manager Sales Supervisor", new string[]{"Sales Engineer", "Sales Supervisor"}},
        {"Manager Sales Representative", new string[]{"Senior Sales Representative", "Junior Sales Representative"}},
        {"Manager Logistics Supervisor", new string[]{"Logistics Engineer", "Logistics Supervisor"}},
        {"Manager Logistics Representative", new string[]{"Senior Logistics Representative", "Junior Logistics Representative"}}
    }; 
    
    
    public Dictionary<string, string[]> accountingSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Accounting Director"}},
        {"Accounting Director", new string[]{"GM Accounting", "GM Payroll"}},
        {"GM Accounting", new string[]{"Accounting Manager", "Tax Manager"}},
        {"GM Payroll", new string[]{"Payroll Manager", "Accounts Payable Manager"}},
        {"Accounting Manager", new string[]{"Senior Accountant", "Junior Accountant"}},
        {"Tax Manager", new string[]{"Senior Tax Accountant", "Junior Tax Accountant"}},
        {"Payroll Manager", new string[]{"Senior Payroll Specialist", "Junior Payroll Specialist"}},
        {"Accounts Payable Manager", new string[]{"Senior Accounts Payable Specialist", "Junior Accounts Payable Specialist"}}
    }; 
    
    
    public Dictionary<string, string[]> marketingSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Marketing Director"}},
        {"Marketing Director", new string[]{"GM Marketing", "GM Digital Marketing"}},
        {"GM Marketing", new string[]{"Marketing Manager", "Product Manager"}},
        {"GM Digital Marketing", new string[]{"Social Media Manager", "SEO Manager"}},
        {"Marketing Manager", new string[]{"Marketing Technologist", "Copy Writer"}},
        {"Product Manager", new string[]{"Product Marketing Specialist", "Product Analyst"}},
        {"Social Media Manager", new string[]{"Digital Marketing Analyst", "Social Media Marketing Analyst"}},
        {"SEO Manager", new string[]{"SEO Consultant", "SEO Engineer"}}
    }; 
    

    public Dictionary<string, string[]> financeSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Finance Director"}},
        {"Finance Director", new string[]{"GM Finance Planning", "GM Finance Analysis"}},
        {"GM Finance Planning", new string[]{"Finance Planning Manager", "Finance Budget Manager"}},
        {"GM Finance Analysis", new string[]{"Finance Analysis Manager", "Finance Reporting Manager"}},
        {"Finance Planning Manager", new string[]{"Senior Cost Analyst", "Junior Cost Analyst"}},
        {"Finance Budget Manager", new string[]{"Senior Budget Analyst", "Junior Budget Analyst"}},
        {"Finance Analysis Manager", new string[]{"Senior Financial Analyst", "Junior Financial Analyst"}},
        {"Finance Reporting Manager", new string[]{"Senior Reporting Analyst", "Junior Reporting Analyst"}}
    }; 


    public Dictionary<string, string[]> operationsSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Operations Director"}},
        {"Operations Director", new string[]{"GM Supply Chain", "GM Facilities"}},
        {"GM Supply Chain", new string[]{"Inventory Manager", "Purchasing Manager"}},
        {"GM Facilities", new string[]{"Safety Manager", "Maintanance Manager"}},
        {"Inventory Manager", new string[]{"Inventory Specialist", "Demand Planner"}},
        {"Purchasing Manager", new string[]{"Purchasing Agent", "Procurement Specialist"}},
        {"Safety Manager", new string[]{"Safety Coordinator", "Environmental Health Specialist"}},
        {"Maintanance Manager", new string[]{"Maintenance Technician", "Facilities Engineer"}}
    }; 


    public Dictionary<string, string[]> humanresourcesSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"HR Director"}},
        {"HR Director", new string[]{"GM HR", "GM Recruitment"}},
        {"GM HR", new string[]{"HR Manager", "HR Coordinator Manager"}},
        {"GM Recruitment", new string[]{"Recruitment Manager", "Recruitment Coordinator Manager"}},
        {"HR Manager", new string[]{"HR Specialist", "HR Generalist"}},
        {"HR Coordinator Manager", new string[]{"Training Coordinator", "Benefits Coordinator"}},
        {"Recruitment Manager", new string[]{"Recruit Lead", "Recruiter"}},
        {"Recruitment Coordinator Manager", new string[]{"Placement Coordinator", "Assignment Coordinator"}}
    }; 


    public Dictionary<string, string[]> itSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"IT Director"}},
        {"IT Director", new string[]{"GM IT", "GM IT Security"}},
        {"GM IT", new string[]{"IT Manager", "Infrastructure Manager"}},
        {"GM IT Security", new string[]{"IT Security Manager", "Systems Administrator Manager"}},
        {"IT Manager", new string[]{"Senior Information Architect", "Junior Information Architect"}},
        {"Infrastructure Manager", new string[]{"Senior Data Architect", "Junior Data Architect"}},
        {"IT Security Manager", new string[]{"Security Analyst", "Security Engineer"}},
        {"Systems Administrator Manager", new string[]{"Senior Network Engineer", "Junior Network Engineer"}}
    }; 


    public Dictionary<string, string[]> managementSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Management Director"}},
        {"Management Director", new string[]{"GM Management", "GM Business Process Management"}},
        {"GM Management", new string[]{"Management Manager", "Project Management Manager"}},
        {"GM Business Process Management", new string[]{"Quality Management Manager", "Business Process Management"}},
        {"Management Manager", new string[]{"Change Management Specialist", "Demand Planner"}},
        {"Project Management Manager", new string[]{"Project Analyst", "Project Coordinator"}},
        {"Quality Management Manager", new string[]{"Quality Control Specialist", "Quality Assurance Specialist"}},
        {"Business Process Management", new string[]{"Business Analyst", "Process Improvement Specialist"}}
    }; 


    public Dictionary<string, string[]> purchasingSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Purchasing Director"}},
        {"Purchasing Director", new string[]{"GM Purchasing", "GM Inventory"}},
        {"GM Purchasing", new string[]{"Purchasing Manager", "pend Analysis Manager"}},
        {"GM Inventory", new string[]{"Strategic Sourcing Manager", "Procurement Operations Manager"}},
        {"Purchasing Manager", new string[]{"Purchasing Assistant", "Purchasing Analyst"}},
        {"Spend Analysis Manager", new string[]{"Spend Analyst", "Budget Analyst"}},
        {"Strategic Sourcing Manager", new string[]{"Sourcing Specialist", "Sourcing Analyst"}},
        {"Procurement Operations Manager", new string[]{"Procurement Specialist", "Procurement Systems Administrator"}}
    };


    public Dictionary<string, string[]> researchanddevelopmentSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Research and Development Director"}},
        {"Research and Development Director", new string[]{"GM Research", "GM Development"}},
        {"GM Research", new string[]{"Research Manager", "Project Manager"}},
        {"GM Development", new string[]{"Development Manager", "Technology Transfer Manager"}},
        {"Research Manager", new string[]{"Research Scientist", "Research Technician"}},
        {"Project Manager", new string[]{"Design Engineer", "Prototype Specialist"}},
        {"Development Manager", new string[]{"Senior Development Engineer", "Junior Development Engineer"}},
        {"Technology Transfer Manager", new string[]{"Intellectual Property Manager", "Licensing Specialist"}}
    }; 


    public Dictionary<string, string[]> productmanagementSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Product Management Director"}},
        {"Product Management Director", new string[]{"GM Product Management", "GM Product Operations"}},
        {"GM Product Management", new string[]{"Product Development Manager", "Brand Manager"}},
        {"GM Product Operations", new string[]{"Product Operations Manager", "Digital Marketing Manager"}},
        {"Product Development Manager", new string[]{"Product Development Engineer", "Product Trainer"}},
        {"Brand Manager", new string[]{"Pricing Analyst", "Product Analyst"}},
        {"Product Operations Manager", new string[]{"Production Planner", "Cross-Functional Team Leader"}},
        {"Digital Marketing Manager", new string[]{"Product Marketing Specialist", "Product Marketing Analyst"}}
    }; 


    public Dictionary<string, string[]> uiuxdesignSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"UI/UX Design Director"}},
        {"UI/UX Design Director", new string[]{"GM UI Design", "GM UX Design"}},
        {"GM UI Design", new string[]{"UI Design Manager", "UI Product Design Manager"}},
        {"GM UX Design", new string[]{"UX Design Manager", "UX Product Design Manager"}},
        {"UI Design Manager", new string[]{"UI Design Technologist", "UI Developer"}},
        {"UI Product Design Manager", new string[]{"UI Product Designer", "UI Usability Tester"}},
        {"UX Design Manager", new string[]{"UX Design Technologist", "UX Developer"}},
        {"UX Product Design Manager", new string[]{"UX Product Designer", "UX Usability Tester"}}
    }; 


    public Dictionary<string, string[]> programmanagementSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Program Management Director"}},
        {"Program Management Director", new string[]{"GM Program Management", "GM Project Management"}},
        {"GM Program Management", new string[]{"Program Manager", "Portfolio Manager"}},
        {"GM Project Management", new string[]{"Project Manager", "Business Operations Manager"}},
        {"Program Manager", new string[]{"Program Management Specialist", "Risk Management Specialist"}},
        {"Portfolio Manager", new string[]{"Business Analyst", "Financial Analyst"}},
        {"Project Manager", new string[]{"Assistant Project Manager", "Technical Project Manager"}},
        {"Business Operations Manager", new string[]{"Data Analyst", "Technical Writer"}}
    }; 


    public Dictionary<string, string[]> qualityassuranceSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"QA Director"}},
        {"QA Director", new string[]{"GM QA", "GM Test"}},
        {"GM QA", new string[]{"Quality Manager", "Senior QA Manager"}},
        {"GM Test", new string[]{"Test Manager", "Senior Test Manager"}},
        {"Quality Manager", new string[]{"Quality Inspector", "Quality Auditor"}},
        {"Senior QA Manager", new string[]{"Quality Assurance Analyst", "Quality Lead"}},
        {"Test Manager", new string[]{"Automation Tester", "Performance Tester"}},
        {"Senior Test Manager", new string[]{"Test Lead", "Test Engineer"}}
    }; 


    public Dictionary<string, string[]> developmentSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Development Director"}},
        {"Development Director", new string[]{"GM Development", "GM Database"}},
        {"GM Development", new string[]{"Software Development Manager", "Web Development Manager"}},
        {"GM Database", new string[]{"Database Manager", "Technical Support Manager"}},
        {"Software Development Manager", new string[]{"Software Engineer", "Senior Developer"}},
        {"Web Development Manager", new string[]{"Full Stack Developer", "Front End Developer"}},
        {"Database Manager", new string[]{"Senior Database Administrator", "Junior Database Administrator"}},
        {"Technical Support Manager", new string[]{"Senior Technical Support Engineer", "Junior Technical Support Engineer"}}
    }; 


    public Dictionary<string, string[]> documentationSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Documentation Director"}},
        {"Documentation Director", new string[]{"GM Documentation Strategy", "GM Documentation Operations"}},
        {"GM Documentation Strategy", new string[]{"Documentation Strategy Manager", "Content Strategy Manager"}},
        {"GM Documentation Operations", new string[]{"Documentation Operations Manager", "Content Operations Manager"}},
        {"Documentation Strategy Manager", new string[]{"Senior Technical Writer", "Junior Technical Writer"}},
        {"Content Strategy Manager", new string[]{"Senior Content Developer", "Junior Content Developer"}},
        {"Documentation Operations Manager", new string[]{"Senior Document Control Specialist", "Junior Document Control Specialist"}},
        {"Content Operations Manager", new string[]{"Content Operations Specialist", "Training Operations Specialist"}}
    }; 


    public Dictionary<string, string[]> customersupportSupervisorDict = new Dictionary<string, string[]>()
    {
        {"CEO", new string[]{"Customer Support Director"}},
        {"Customer Support Director", new string[]{"GM Customer Support Operations", "GM Customer Success"}},
        {"GM Customer Support Operations", new string[]{"Customer Support Manager", "Technical Support Manager"}},
        {"GM Customer Success", new string[]{"Customer Success Manager", "Support Operations Manager"}},
        {"Customer Support Manager", new string[]{"Senior Customer Support Specialist", "Junior Customer Support Specialist"}},
        {"Technical Support Manager", new string[]{"Senior Support Engineer", "Junior Support Engineer"}},
        {"Customer Success Manager", new string[]{"Senior Customer Success Specialist", "Junior Customer Success Specialist"}},
        {"Support Operations Manager", new string[]{"Support Operations Engineer", "Support Operations Specialist"}}
    }; 
    
    
    #endregion
    
}




