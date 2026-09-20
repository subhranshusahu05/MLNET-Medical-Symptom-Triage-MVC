using MedicalSymptomTriage.Models;
using MedicalSymptomTriage.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSymptomTriage.Controllers
{
    public class HomeController : Controller
    {
        private readonly MLModelService _mlModelService;

        public HomeController(MLModelService mlModelService)
        {
            _mlModelService = mlModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Predict(SymptomInputModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Content))
            {
                ModelState.AddModelError(
                    "Content",
                    "Please enter your symptoms.");

                return View("Index", model);
            }

            var prediction = _mlModelService.Predict(model.Content);

            var result = new SymptomPredictionModel
            {
                PredictedLabel = prediction.PredictedLabel,
                Score = prediction.Score
            };

            return View("Result", result);
        }
    }
}