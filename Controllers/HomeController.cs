using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "John Doe", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Jane Smith", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Mike Johnson", StudentId = "S003", StudentAge = "31" }
            new StudentInfoModel { Name = "Angel Vallermosa", StudentId = "20-1298", StudentAge = "21"}
            new StudentInfoModel { Name = "Feona Gana", StudentId = "21-2177", StudentAge = "21"}
            new StudentInfoModel { Name = "Alesa Tabios", StudentId ="21-2097", StudentAge = "20"}


        };

        return View(studentInfoArray);
    }
}
