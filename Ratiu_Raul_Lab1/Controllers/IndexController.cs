using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace Ratiu_Raul_Lab1.Controllers
{
    public class IndexController : Controller
    {
        public string Index()
        {
            return "Welcome to our website!";
        }
        public string GreetUser()
        {
            return "Hello!";
        }
        public string SelfIntroduction(string name = "Raul", int age = 21)
        {
            return $"My name is {name} and I'm {age} years old";
        }
    }
}
