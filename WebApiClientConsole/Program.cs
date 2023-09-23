using WebApiClientConsole;

Console.WriteLine("API CLIENT");
EmployeeApiClient.CallGetAllEmployee().Wait();
Console.ReadLine(); 
