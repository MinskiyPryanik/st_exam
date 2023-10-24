using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentREST.Models;
using System.IO;

namespace StudentREST.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet, Route("all")]
        public List<Student> writeall()
        {
            string text= System.IO.File.ReadAllText(StudentList.path);
            StudentList.students = JsonSerial.JsonDeserializeObject<List<Student>>(text);

            return StudentList.students;
        }

        [HttpGet,Route("new/{id}/{name}/{vozrast}")]
        public Student postthis(int id,string name,int vozrast)
        {
            Student student = new Student()
            {
                Id = id,
                Name = name,
                Age = vozrast

           };
            StudentList.students.Add(student);
            //JsonSerial.JsonSerializeObject(StudentList.students);
            System.IO.File.WriteAllText(StudentList.path, JsonSerial.JsonSerializeObject(StudentList.students));
            return student;
        }

        [HttpGet, Route("check/{id}")]
        public Student currentstud (int id)
        {
            string text = System.IO.File.ReadAllText(StudentList.path);
            StudentList.students = JsonSerial.JsonDeserializeObject<List<Student>>(text);
            return StudentList.students.FirstOrDefault(p => p.Id == id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}