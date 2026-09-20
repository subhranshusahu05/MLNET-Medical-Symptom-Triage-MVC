namespace MedicalSymptomTriage.Models
{
    public class SymptomPredictionModel
    {
        public string PredictedLabel { get; set; } = string.Empty;

        public float[] Score { get; set; } = Array.Empty<float>();
    }
}
