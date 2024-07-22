using Microsoft.AspNetCore.Mvc;
namespace FirstCoreMVCWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public string GetAllStudents()
        {
            return "Return All Students";
        }
    }
}