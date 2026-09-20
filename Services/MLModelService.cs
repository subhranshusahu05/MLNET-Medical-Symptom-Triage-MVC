using Microsoft.ML;
using MedicalSymptomTriage.Models;

namespace MedicalSymptomTriage.Services
{
    public class MLModelService
    {
        private readonly MLContext _mlContext;
        private readonly PredictionEngine<SymptomInputData, SymptomPrediction> _predictionEngine;

        public MLModelService(IWebHostEnvironment environment)
        {
            _mlContext = new MLContext();

            var modelPath = Path.Combine(
                environment.ContentRootPath,
                "MLModels",
                "SymptomsModel.zip");

            ITransformer model = _mlContext.Model.Load(
                modelPath,
                out _);

            _predictionEngine =
                _mlContext.Model.CreatePredictionEngine<
                    SymptomInputData,
                    SymptomPrediction>(model);
        }

        public SymptomPrediction Predict(string content)
        {
            var input = new SymptomInputData
            {
                Content = content
            };

            return _predictionEngine.Predict(input);
        }
    }
}
