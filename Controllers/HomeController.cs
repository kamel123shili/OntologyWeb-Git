using Microsoft.AspNetCore.Mvc;
using Smart_Cities.Models;
using System.Diagnostics;
using System.Xml;

namespace Smart_Cities.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _environment;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }


        public IActionResult Index()
        {
            var ontologies = new List<Ontologie.Ontology>
            {
              new Ontologie.Ontology
              {
                  SubClassOf = new List<Ontologie.SubClassOf>
                  {
                     new Ontologie.SubClassOf
                     {
                         Classes = new List<Ontologie.Class>
                         {
                            new Ontologie.Class { IRI = "IRI1" },
                            new Ontologie.Class { IRI = "IRI2" }
                         }
                     },
                // Ajoutez d'autres données si nécessaire
                  }
              },
        // Ajoutez d'autres objets Ontology si nécessaire
            };

            return View(ontologies);
        }

        [HttpPost]
        public IActionResult Index(Ontologie.Ontology ontology)
        {
            // Here, you can use the posted Ontology data as needed
            // For example, you can save it to a database or perform any other operations

            // Redirect to another action or return a view
            return RedirectToAction("Index");
        }
        //public IActionResult Index()
        //{
        //    //Model.Ontologies = new List<Ontologie>();
        //    List<Ontologie> employees = new List<Ontologie>();
        //    string filePath = Path.Combine(_environment.WebRootPath, "Saafinesrine-ontology"); // Chemin relatif à partir de wwwroot

        //    if (System.IO.File.Exists(filePath))
        //    {
        //        XmlDocument document = new XmlDocument();
        //        document.Load(filePath);

        //        // Ajouter la logique pour extraire les données du fichier RDF XML et les ajouter à viewModel.Ontologies
        //        // Par exemple :
        //        foreach (XmlNode node in document.SelectNodes("..."))
        //        {
        //            var ontology = new Ontologie();
        //            Ontologies.Add(ontology);
        //        }
        //    }
        //    else
        //    {
        //        // Gérer le cas où le fichier n'est pas trouvé
        //        // Vous pouvez logger un message d'erreur ou afficher un message à l'utilisateur
        //    }

        //    return View(viewModel);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
