using WebApiClientConsole;

Console.WriteLine("API CLIENT");
//EmployeeApiClient.GetAllListlEmployee().Wait();
//EmployeeApiClient.AddNewEmployee().Wait();
//Console.ReadLine(); 
EmployeeApiClient.DeleteEmployee(15).Wait();
Console.ReadLine();
