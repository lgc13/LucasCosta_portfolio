using System;
namespace LucasHelloWorldMVC.Controllers
{
    public class LucasController
    {
        public LucasController 
        {
            // 
            // GET: /HelloWorld/

            public string Index()
            {
                return "This is my default action...";
            }

            // 
            // GET: /HelloWorld/Welcome/ 

            public string Welcome()
            {
                return "This is the Welcome action method...";
            }
        }
    }
}
