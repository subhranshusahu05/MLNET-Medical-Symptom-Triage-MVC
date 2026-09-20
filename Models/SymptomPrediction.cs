namespace MedicalSymptomTriage.Models
{
    public class SymptomPrediction
    {
       
        
            public string PredictedLabel { get; set; } = string.Empty;

            public float[] Score { get; set; } = Array.Empty<float>();
        
    }
}
