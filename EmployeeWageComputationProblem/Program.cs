// See https://aka.ms/new-console-template for more information
using EmployeeWageComputationProblem;

Console.WriteLine(" Hello, World! ");
Console.WriteLine(" Welcome to Employee Wage Computation Program on Master Branch");
Console.WriteLine(" _____________________________________________________________\n");


UC1_EmployeeCheck uc1 = new UC1_EmployeeCheck();
uc1.EmployeeCheck();
Console.WriteLine("\n _____________________________________________________________\n");
EmployeeWageComputationProblem.UC2_DailyEmployeeWage uc2 = new UC2_DailyEmployeeWage();
uc2.DailyEmployeeWage();
Console.WriteLine("\n _____________________________________________________________\n");
EmployeeWageComputationProblem.UC3_EmployeeWagePartTime uc3 = new UC3_EmployeeWagePartTime();
uc3.EmployeeWagePartTime();
Console.WriteLine("\n _____________________________________________________________\n");
EmployeeWageComputationProblem.UC4_SwitchCase uc4 = new UC4_SwitchCase();
uc4.SwichCase();
Console.WriteLine("\n _____________________________________________________________\n");
EmployeeWageComputationProblem.UC5_WagesForAMonth uc5 = new UC5_WagesForAMonth();
uc5.WagesForAMonth();
Console.WriteLine("\n _____________________________________________________________\n");
EmployeeWageComputationProblem.UC6_TotalWorkingHrs uc6 = new UC6_TotalWorkingHrs();
uc6.TotalWorkingHrs();