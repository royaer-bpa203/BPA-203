using Microsoft.AspNetCore.Mvc;

namespace MVCIntro.Controllers
{
    public class HomeConroller : Controller
    {
        public JsonResult Index()
        {
            var student = new JsonResult(

                new
                {
                    Id = 1,
                    Name = "John Doe",
                    Age = 21
                }
            );

            return student;
        }

        public int? Detail(int? id)
        {
            if (id is null || id < 1) 
            {
                throw new Exception("ID is invalid");
            }
            
            return id;
        }
    }
}
