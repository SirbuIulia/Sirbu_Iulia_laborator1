using Microsoft.AspNetCore.Mvc;

namespace Sirbu_Iulia_Lab1.Controllers
{
    public class HomeController1 : Controller
    {

        public string Index()
        {
            return "Bun venit, utilizatorule!";
        }

        public string Salut()
        {
            return "Salutare! Bine ai venit pe pagina mea web!";
        }

        public string Informatii(string nume, int varsta)
        {
            return $"Salut, {nume}! Ai {varsta} ani.";
        }

    }
}
