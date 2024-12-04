using Microsoft.AspNetCore.Mvc;
using Students.Models;

namespace Students.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> _studentsList = new List<Student>
        {
            new Student {
                Id = 1,
                StudentName = "John Smith",
                StudentEmail = "john.smith@email.com",
                StudentNationality = "Jordanian",
                City = "Amman",
                Address = "Gardens Street",
                DOB = DateTime.Parse("11/26/1998"),
                IsActive = true,
                HighSchool = "Al-Manhal Highschool"
            },
            new Student {
                Id = 2,
                StudentName = "Sarah Adams",
                StudentEmail = "adams94@gmail.com",
                StudentNationality = "Syrian",
                City = "Damascus",
                Address = "Abu Remaneh Street",
                DOB = DateTime.Parse("05/14/2001"),
                IsActive = true,
                HighSchool = "Teshreen High School"
            },
             new Student {
                Id = 3,
                StudentName = "Ali Kareem",
                StudentEmail = "ali_k@gmail.com",
                StudentNationality = "Jordanian",
                City = "Irbid",
                Address = "Hassan Town",
                DOB = DateTime.Parse("10/19/1982"),
                IsActive = true,
                HighSchool = "King Abdullah I High School"
            }
        };
        public IActionResult Index()
        {
            return View(_studentsList);
        }

        // Create new Student menu
        [HttpGet]
        public IActionResult Create()
        {
            // Passing data from the controller to its respective view (Create)

            return View();
        }
        // Add the created Student from Create - Get to _studentsList
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _studentsList.Add(student);
            return RedirectToAction(nameof(Index));
        }

        // Edit Student Menu
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _studentsList.Where(stu => stu.Id == id).FirstOrDefault();

            return View("Create", model);    // Call the Create action method instead, passing along the model object.
        }
        // Update edited student information from Edit-Get and save them.
        [HttpPost]
        public IActionResult Edit(int id, Student student)
        {
            var model = _studentsList.Where(stu => stu.Id == id).FirstOrDefault();

            model.StudentName = student.StudentName;
            model.StudentEmail = student.StudentEmail;
            model.StudentNationality = student.StudentNationality;
            model.City = student.City;
            model.Address = student.Address;
            model.DOB = student.DOB;
            model.IsActive = student.IsActive;
            model.HighSchool = student.HighSchool;

            return RedirectToAction("index");
        }

        // Student Delete menu
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _studentsList.Where(stu => stu.Id == id).FirstOrDefault();

            _studentsList.Remove(model);
            return RedirectToAction(nameof(Index));
            return View(model);
        }

        // The Delete - Post action method is no longer needed now since we added onClick event 
        // in Index view file inside Delete button.


        // Remove selected student from  _studentsList
        //[HttpPost]
        //public IActionResult Delete(int id, Student student)
        //{
        //    var model = _studentsList.Find(stu => stu.Id == id);
        //    _studentsList.Remove(model);

        //    return RedirectToAction(nameof(Index));
        //}
    }
}
