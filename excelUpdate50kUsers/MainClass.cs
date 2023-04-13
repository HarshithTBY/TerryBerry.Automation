using excelUpdate50kUsers.Countries;

namespace excelUpdate50kUsers
{
    public class Mainclass 
    {
        static Random random = new Random();
        static ConstEnums constEnums = new ConstEnums();  // calling the another class

        static void Main(string[] args)
        {
            string excelFilePath = @"C:\Users\rharshith\Downloads\fiftykusers - wip - Copy.xlsx";
            int numRows = 50001;
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
                
                // Create a dictionary to store unique usernames
                Dictionary<string, int> uniqueUsernamesDict = new Dictionary<string, int>();
                
                // Create a dictionary to store random zipcodes for cities
                Dictionary<string, int> zipcodesCityDict = new Dictionary<string, int>();
                
                
                #region Job title and empid dictionary for the big boys of the dept
                
                Dictionary<string, string> SalesWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };
                
                Dictionary<string, string> AccountingWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };
                
                Dictionary<string, string> MarketingWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> FinanceWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> OperationsWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> HumanResourcesWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> ItWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> ManagementWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> PurchasingWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> ResearchAndDevelopmentWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> ProductManagementWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> UiUxDesignWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> ProgramManagementWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> QualityAssuranceWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> DevelopmentWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> DocumentationWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };

                Dictionary<string, string> CustomerSupportWithEmpIdDict = new Dictionary<string, string>()
                {
                    {"CEO", "1"}
                };
                
                #endregion
                
                
                for (int i = 3; i <= numRows; i++)
                {
                    #region Variables
                    
                    string randomDepartmentName = GetRandomEnumValue<DepartmentName>();
                    string randomCountry = GetRandomEnumValue<Country>();
                    string randomState = "";
                    string randomCity = "";
                    string randomJobTitle = "";
                    string locationCode = "";
                    string departmentCode = "";
                    int randomZipCode;
                    
                    #endregion
                    
                    
                    #region Counts
                    
                    int salesCount = constEnums.theBigBoysOfSalesArrLis.Count - 1;
                    int accountingCount = constEnums.theBigBoysOfAccountingArrLis.Count - 1;
                    int marketingCount = constEnums.theBigBoysOfMarketingArrLis.Count - 1;
                    int financeCount = constEnums.theBigBoysOfFinanceArrLis.Count - 1;
                    int operationsCount = constEnums.theBigBoysOfOperationsArrLis.Count - 1;
                    int humanresourcesCount = constEnums.theBigBoysOfHumanResourcesArrLis.Count - 1;
                    int itCount = constEnums.theBigBoysOfITArrLis.Count - 1;
                    int managementCount = constEnums.theBigBoysOfManagementArrLis.Count - 1;
                    int purchasingCount = constEnums.theBigBoysOfPurchasingArrLis.Count - 1;
                    int researchandevelopmentCount = constEnums.theBigBoysOfResearchandDevelopmentArrLis.Count - 1;
                    int productmanagementCount = constEnums.theBigBoysOfProductManagementArrLis.Count - 1;
                    int uiuxdesignCount = constEnums.theBigBoysOfUiUxDesignArrLis.Count - 1;
                    int programmanagementCount = constEnums.theBigBoysOfProgramManagementArrLis.Count - 1;
                    int qualityassuranceCount = constEnums.theBigBoysOfQualityAssuranceArrLis.Count - 1;
                    int developmentCount = constEnums.theBigBoysOfDevelopmentArrLis.Count - 1;
                    int documentationCount = constEnums.theBigBoysOfDocumentationArrLis.Count - 1;
                    int customersupportCount = constEnums.theBigBoysOfCustomerSupportArrLis.Count - 1;
                    
                    #endregion
                    
                    
                    // Getting random country, state and city
                    switch (randomCountry)
                    {
                        case "Canada":
                            randomState = GetRandomEnumValue<Canada.Canadian_States>();

                            switch (randomState)
                            {
                                case "Ontario":
                                    randomCity = GetRandomEnumValue<Canada.Ontario_Cities>();
                                    break;
                                case "Quebec":
                                    randomCity = GetRandomEnumValue<Canada.Quebec_Cities>();
                                    break;
                                case "BritishColumbia":
                                    randomCity = GetRandomEnumValue<Canada.BritishColumbia_Cities>();
                                    break;
                                case "Alberta":
                                    randomCity = GetRandomEnumValue<Canada.Alberta_Cities>();
                                    break;
                                case "Saskatchewan":
                                    randomCity = GetRandomEnumValue<Canada.Saskatchewan_Cities>();
                                    break;
                                case "Manitoba":
                                    randomCity = GetRandomEnumValue<Canada.Manitoba_Cities>();
                                    break;
                                case "NovaScotia":
                                    randomCity = GetRandomEnumValue<Canada.NovaScotia_Cities>();
                                    break;
                                case "NewBrunswick":
                                    randomCity = GetRandomEnumValue<Canada.NewBrunswick_Cities>();
                                    break;
                                case "NewfoundlandandLabrador":
                                    randomCity = GetRandomEnumValue<Canada.NewfoundlandandLabrador_Cities>();
                                    break;
                                case "PrinceEdwardIsland":
                                    randomCity = GetRandomEnumValue<Canada.PrinceEdwardIsland_Cities>();
                                    break;
                                default:
                                    break;
                            }
                            break;

                        
                        case "India":
                            randomState = GetRandomEnumValue<India.Indian_States>();

                            switch (randomState)
                            {
                                case "Maharashtra":
                                    randomCity = GetRandomEnumValue<India.Maharashtra_Cities>();
                                    break;
                                case "UttarPradesh":
                                    randomCity = GetRandomEnumValue<India.UttarPradesh_Cities>();
                                    break;
                                case "TamilNadu":
                                    randomCity = GetRandomEnumValue<India.TamilNadu_Cities>();
                                    break;
                                case "Karnataka":
                                    randomCity = GetRandomEnumValue<India.Karnataka_Cities>();
                                    break;
                                case "Gujarat":
                                    randomCity = GetRandomEnumValue<India.Gujarat_Cities>();
                                    break;
                                case "Rajasthan":
                                    randomCity = GetRandomEnumValue<India.Rajasthan_Cities>();
                                    break;
                                case "AndhraPradesh":
                                    randomCity = GetRandomEnumValue<India.AndhraPradesh_Cities>();
                                    break;
                                case "WestBengal":
                                    randomCity = GetRandomEnumValue<India.WestBengal_Cities>();
                                    break;
                                case "MadhyaPradesh":
                                    randomCity = GetRandomEnumValue<India.MadhyaPradesh_Cities>();
                                    break;
                                case "Bihar":
                                    randomCity = GetRandomEnumValue<India.Bihar_Cities>();
                                    break;
                                default:
                                    break;
                            }
                            break;

                        
                        case "UnitedStates":
                            randomState = GetRandomEnumValue<USA.UnitedStates_States>();

                            switch (randomState)
                            {
                                case "California":
                                    randomCity = GetRandomEnumValue<USA.California_Cities>();
                                    break;
                                case "Texas":
                                    randomCity = GetRandomEnumValue<USA.Texas_Cities>();
                                    break;
                                case "Florida":
                                    randomCity = GetRandomEnumValue<USA.Florida_Cities>();
                                    break;
                                case "NewYork":
                                    randomCity = GetRandomEnumValue<USA.NewYork_Cities>();
                                    break;
                                case "Pennsylvania":
                                    randomCity = GetRandomEnumValue<USA.Pennsylvania_Cities>();
                                    break;
                                case "Illinois":
                                    randomCity = GetRandomEnumValue<USA.Illinois_Cities>();
                                    break;
                                case "Ohio":
                                    randomCity = GetRandomEnumValue<USA.Ohio_Cities>();
                                    break;
                                case "Georgia":
                                    randomCity = GetRandomEnumValue<USA.Georgia_Cities>();
                                    break;
                                case "NorthCarolina":
                                    randomCity = GetRandomEnumValue<USA.NorthCarolina_Cities>();
                                    break;
                                case "Michigan":
                                    randomCity = GetRandomEnumValue<USA.Michigan_Cities>();
                                    break;
                                default:
                                    break;
                            }
                            break;

                        
                        case "UnitedKingdom":
                            randomState = GetRandomEnumValue<UK.UnitedKingdom_States>();

                            switch (randomState)
                            {
                                case "England":
                                    randomCity = GetRandomEnumValue<UK.England_Cities>();
                                    break;
                                case "Scotland":
                                    randomCity = GetRandomEnumValue<UK.Scotland_Cities>();
                                    break;
                                case "Wales":
                                    randomCity = GetRandomEnumValue<UK.Wales_Cities>();
                                    break;
                                case "NorthernIreland":
                                    randomCity = GetRandomEnumValue<UK.NorthernIreland_Cities>();
                                    break;
                                default:
                                    break;
                            }
                            break;


                        default:
                            break;
                    }
                    
                    
                    // Getting random DepartmentName and JobTitle
                    switch (randomDepartmentName)
                    {
                        case "Sales":
                            if (salesCount >= 0)  // if there is a value in the big boys arr
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfSalesArrLis[salesCount];  // First, taking a value from the big boys arr
                                constEnums.theBigBoysOfSalesArrLis.RemoveAt(salesCount);  // then, removing that value that arr
                                
                                string empId = worksheet.Cells[i, 1].Text;  // storing the emp id of that value
                                SalesWithEmpIdDict[randomJobTitle] = empId;  // storing the job title and empid in a dictionary
                            }
                            else  // if there are no values in the big boys arr
                                randomJobTitle = GetRandomArrayValue(constEnums.salesJobTitlesArr);  
                            break;
                        case "Accounting":
                            if (accountingCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfAccountingArrLis[accountingCount];
                                constEnums.theBigBoysOfAccountingArrLis.RemoveAt(accountingCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                AccountingWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.accountingJobTitlesArr);
                            break;
                        case "Marketing":
                            if (marketingCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfMarketingArrLis[marketingCount];
                                constEnums.theBigBoysOfMarketingArrLis.RemoveAt(marketingCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                MarketingWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.marketingJobTitlesArr);
                            break;
                        case "Finance":
                            if (financeCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfFinanceArrLis[financeCount];
                                constEnums.theBigBoysOfFinanceArrLis.RemoveAt(financeCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                FinanceWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.financeJobTitlesArr);
                            break;
                        case "Operations":
                            if (operationsCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfOperationsArrLis[operationsCount];
                                constEnums.theBigBoysOfOperationsArrLis.RemoveAt(operationsCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                OperationsWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.operationsJobTitlesArr);
                            break;
                        case "HumanResources":
                            if (humanresourcesCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfHumanResourcesArrLis[humanresourcesCount];
                                constEnums.theBigBoysOfHumanResourcesArrLis.RemoveAt(humanresourcesCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                HumanResourcesWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.humanResourcesJobTitlesArr);
                            break;
                        case "It":
                            if (itCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfITArrLis[itCount];
                                constEnums.theBigBoysOfITArrLis.RemoveAt(itCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                ItWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.itJobTitlesArr);
                            break;
                        case "Management":
                            if (managementCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfManagementArrLis[managementCount];
                                constEnums.theBigBoysOfManagementArrLis.RemoveAt(managementCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                ManagementWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.managementJobTitlesArr);
                            break;
                        case "Purchasing":
                            if (purchasingCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfPurchasingArrLis[purchasingCount];
                                constEnums.theBigBoysOfPurchasingArrLis.RemoveAt(purchasingCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                PurchasingWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.purchasingJobTitlesArr);
                            break;
                        case "ResearchAndDevelopment":
                            if (researchandevelopmentCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfResearchandDevelopmentArrLis[researchandevelopmentCount];
                                constEnums.theBigBoysOfResearchandDevelopmentArrLis.RemoveAt(researchandevelopmentCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                ResearchAndDevelopmentWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.researchAndDevelopmentJobTitlesArr);
                            break;
                        case "ProductManagement":
                            if (productmanagementCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfProductManagementArrLis[productmanagementCount];
                                constEnums.theBigBoysOfProductManagementArrLis.RemoveAt(productmanagementCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                ProductManagementWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.productManagementJobTitlesArr);
                            break;
                        case "UiUxDesign":
                            if (uiuxdesignCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfUiUxDesignArrLis[uiuxdesignCount];
                                constEnums.theBigBoysOfUiUxDesignArrLis.RemoveAt(uiuxdesignCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                UiUxDesignWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.uiUxDesignJobTitlesArr);
                            break;
                        case "ProgramManagement":
                            if (programmanagementCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfProgramManagementArrLis[programmanagementCount];
                                constEnums.theBigBoysOfProgramManagementArrLis.RemoveAt(programmanagementCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                ProgramManagementWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.programManagementJobTitlesArr);
                            break;
                        case "QualityAssurance":
                            if (qualityassuranceCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfQualityAssuranceArrLis[qualityassuranceCount];
                                constEnums.theBigBoysOfQualityAssuranceArrLis.RemoveAt(qualityassuranceCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                QualityAssuranceWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.qualityAssuranceJobTitlesArr);
                            break;
                        case "Development":
                            if (developmentCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfDevelopmentArrLis[developmentCount];
                                constEnums.theBigBoysOfDevelopmentArrLis.RemoveAt(developmentCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                DevelopmentWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.developmentJobTitlesArr);
                            break;
                        case "Documentation":
                            if (documentationCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfDocumentationArrLis[documentationCount];
                                constEnums.theBigBoysOfDocumentationArrLis.RemoveAt(documentationCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                DocumentationWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.documentationJobTitlesArr);
                            break;
                        case "CustomerSupport":
                            if (customersupportCount >= 0)
                            {
                                randomJobTitle = (string)constEnums.theBigBoysOfCustomerSupportArrLis[customersupportCount];
                                constEnums.theBigBoysOfCustomerSupportArrLis.RemoveAt(customersupportCount);
                                
                                string empId = worksheet.Cells[i, 1].Text;
                                CustomerSupportWithEmpIdDict[randomJobTitle] = empId;
                            }
                            else
                                randomJobTitle = GetRandomArrayValue(constEnums.customerSupportJobTitlesArr);
                            break;
                    }
                    
                    
                    #region Generate unique username
                    
                    // Get the first name, last name, and usercode from the row
                    string firstName = worksheet.Cells[i, 4].Text;
                    string lastName = worksheet.Cells[i, 6].Text;
                    int userCode = int.Parse(worksheet.Cells[i, 3].Text);

                    // Create the base username from the first name and last name
                    string baseUsername = firstName.ToLower() + lastName.Substring(0, Math.Min(1, lastName.Length)).ToLower();

                    // Create the unique username by appending a number if necessary
                    string username = baseUsername;
                    int count = 1;
                    int digit = 1;
                    
                    while (uniqueUsernamesDict.ContainsKey(username))
                    {
                        count++;
                        if (count == 2)
                        {
                            username = baseUsername.Substring(0, baseUsername.Length -1) + lastName.Substring(0, Math.Min(2, lastName.Length)).ToLower();
                        }
                        else if (count == 3)
                        {
                            username = baseUsername.Substring(0, baseUsername.Length -1) + lastName.Substring(0, Math.Min(3, lastName.Length)).ToLower();
                        }
                        else if (count == 4)
                        {
                            username = baseUsername.Substring(0, baseUsername.Length -1) + lastName.Substring(0, Math.Min(4, lastName.Length)).ToLower();
                        }
                        else
                        {
                            username = baseUsername + digit.ToString();
                            digit++;
                        }
                    }

                    // Add the username to the dictionary of unique usernames
                    uniqueUsernamesDict[username] = userCode;
                    
                    #endregion
    
                    
                    #region Generate random zipcodes for cities

                    if (zipcodesCityDict.ContainsKey(randomCity))
                    {
                        randomZipCode = zipcodesCityDict[randomCity];
                    }
                    else
                    {
                        randomZipCode = random.Next(100000, 999999);
                        while (uniqueUsernamesDict.ContainsValue(randomZipCode))
                        {
                            randomZipCode = random.Next(100000, 999999);
                        }
                        
                        zipcodesCityDict[randomCity] = randomZipCode;
                    }

                    #endregion
                    
                    
                    #region Set Cells Value
                    worksheet.Cells[i, 9].Value = randomJobTitle;
                    worksheet.Cells[i, 16].Value = randomDepartmentName;
                    worksheet.Cells[i, 10].Value = randomCountry;
                    worksheet.Cells[i, 11].Value = randomState;
                    worksheet.Cells[i, 12].Value = randomCity;
                    worksheet.Cells[i, 2].Value = username;  // Unique username
                    
                    locationCode = randomCity + "1111";
                    departmentCode = randomDepartmentName + "1111";
                    worksheet.Cells[i, 13].Value = randomCity; 
                    worksheet.Cells[i, 14].Value = locationCode;  
                    worksheet.Cells[i, 17].Value = departmentCode;  
                    worksheet.Cells[i, 22].Value = randomZipCode;

                    worksheet.Cells[i, 23].Value = $"{locationCode}, TestAddress1ForUserResidingAtLocation";
                    worksheet.Cells[i, 24].Value = $"{locationCode}, TestAddress2ForZipCode-{randomZipCode}";
                    
                    #endregion

                }
                
                
                // Setting supervisor id
                for (int i = 3; i <= numRows; i++)
                {
                    string tempJobTitle = worksheet.Cells[i, 9].Text;
                    string tempDepartmentName = worksheet.Cells[i, 16].Text;
                    string supervisorEmpId = "";
                    
                    switch (tempDepartmentName)
                    {
                        case "Sales":
                            var supervisor1 = constEnums.salesSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor1))
                            {
                                supervisorEmpId = SalesWithEmpIdDict[supervisor1];
                            }
                            break;
                        case "Accounting":
                            var supervisor2 = constEnums.accountingSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor2))
                            {
                                supervisorEmpId = AccountingWithEmpIdDict[supervisor2];
                            }
                            break;
                        case "Marketing":
                            var supervisor3 = constEnums.marketingSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor3))
                            {
                                supervisorEmpId = MarketingWithEmpIdDict[supervisor3];
                            }
                            break;
                        case "Finance":
                            var supervisor4 = constEnums.financeSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor4))
                            {
                                supervisorEmpId = FinanceWithEmpIdDict[supervisor4];
                            }
                            break;
                        case "Operations":  // using linq to check if the value is there in the dictionary, if so then returning the key of that value
                            var supervisor5 = constEnums.operationsSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor5))
                            {
                                supervisorEmpId = OperationsWithEmpIdDict[supervisor5];  // using that key to get the empid from a dictionary
                            }
                            break;
                        case "HumanResources":
                            var supervisor6 = constEnums.humanresourcesSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor6))
                            {
                                supervisorEmpId = HumanResourcesWithEmpIdDict[supervisor6];
                            }
                            break;
                        case "It":
                            var supervisor7 = constEnums.itSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor7))
                            {
                                supervisorEmpId = ItWithEmpIdDict[supervisor7];
                            }
                            break;
                        case "Management":
                            var supervisor8 = constEnums.managementSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor8))
                            {
                                supervisorEmpId = ManagementWithEmpIdDict[supervisor8];
                            }
                            break;
                        case "Purchasing":
                            var supervisor9 = constEnums.purchasingSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor9))
                            {
                                supervisorEmpId = PurchasingWithEmpIdDict[supervisor9];
                            }
                            break;
                        case "ResearchAndDevelopment":
                            var supervisor10 = constEnums.researchanddevelopmentSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor10))
                            {
                                supervisorEmpId = ResearchAndDevelopmentWithEmpIdDict[supervisor10];
                            }
                            break;
                        case "ProductManagement":
                            var supervisor11 = constEnums.productmanagementSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor11))
                            {
                                supervisorEmpId = ProductManagementWithEmpIdDict[supervisor11];
                            }
                            break;
                        case "UiUxDesign":
                            var supervisor12 = constEnums.uiuxdesignSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor12))
                            {
                                supervisorEmpId = UiUxDesignWithEmpIdDict[supervisor12];
                            }
                            break;
                        case "ProgramManagement":
                            var supervisor13 = constEnums.programmanagementSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor13))
                            {
                                supervisorEmpId = ProgramManagementWithEmpIdDict[supervisor13];
                            }
                            break;
                        case "QualityAssurance":
                            var supervisor14 = constEnums.qualityassuranceSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor14))
                            {
                                supervisorEmpId = QualityAssuranceWithEmpIdDict[supervisor14];
                            }
                            break;
                        case "Development":
                            var supervisor15 = constEnums.developmentSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor15))
                            {
                                supervisorEmpId = DevelopmentWithEmpIdDict[supervisor15];
                            }
                            break;
                        case "Documentation":
                            var supervisor16 = constEnums.documentationSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor16))
                            {
                                supervisorEmpId = DocumentationWithEmpIdDict[supervisor16];
                            }
                            break;
                        case "CustomerSupport":
                            var supervisor17 = constEnums.customersupportSupervisorDict.FirstOrDefault(x => x.Value.Contains(tempJobTitle)).Key;
                            if (!string.IsNullOrEmpty(supervisor17))
                            {
                                supervisorEmpId = CustomerSupportWithEmpIdDict[supervisor17];
                            }
                            break;
                    }
                    
                    worksheet.Cells[i, 21].Value = supervisorEmpId;

                }
                
                
                excelPackage.Save();
            }
        }


        #region Methods
        
        // Generic method to get a random value from an enum
        static string GetRandomEnumValue<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            var temp = values.GetValue(new Random().Next(values.Length));
            return temp.ToString();
        }
        
        // Get random string value from an array
        public static string GetRandomArrayValue(string[] array)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, array.Length);
            return array[randomIndex];
        }
        
        #endregion
       
        
    }
}
