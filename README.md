# 🧠 ML.NET Medical Symptom Triage — ASP.NET Core MVC

An ASP.NET Core MVC web application that integrates a trained ML.NET text classification model to classify user-described symptoms into a suggested medical specialist category.

> ⚠️ **Educational Project:** This application is developed for learning and demonstration purposes only. It does not provide a medical diagnosis .

---

## 📌 Project Overview

This project is the web application implementation of a trained ML.NET medical symptom classification model.

The user enters a description of their symptoms through a Bootstrap-based web interface. The application sends the input to the trained ML.NET model and displays the predicted specialist category.

### Application Flow

```text
User enters symptoms
        ↓
ASP.NET Core MVC
        ↓
HomeController
        ↓
MLModelService
        ↓
Trained ML.NET Model
        ↓
Prediction
        ↓
Result View
```

---

## 🖥️ Application Demo

<img width="400" height="225" alt="export-GIF" src="https://github.com/user-attachments/assets/93b7bfb6-4258-45e7-94e2-44cc9e2ed988" />




### 🎥 YouTube Demo

[<!-- Add your YouTube video link here -->](https://youtu.be/1meycAtT6oY?si=kezZuxIwSzvHXb4z)

[▶️ Watch the Application Demo on YouTube](YOUR_YOUTUBE_LINK)

---

## ✨ Features

* 📝 Symptom text input
* 🤖 ML.NET multiclass text classification
* 🩺 Suggested specialist category
* 🎨 Bootstrap-based user interface
* ⚡ ASP.NET Core MVC architecture
* 🔄 Ability to check multiple symptoms
* 📦 Uses a previously trained ML.NET model
* ⚠️ Educational/non-diagnostic disclaimer

---

## 🏥 Supported Categories

The model can classify symptoms into the following categories:

| Category             | Suggested Specialist  |
| -------------------- | --------------------- |
| `general_physician`  | General Physician     |
| `cardiologist`       | Cardiologist          |
| `dermatologist`      | Dermatologist         |
| `orthopedic`         | Orthopedic Specialist |
| `neurologist`        | Neurologist           |
| `gastroenterologist` | Gastroenterologist    |
| `ent`                | ENT Specialist        |
| `emergency`          | Emergency Care        |

---

## 🛠️ Technologies Used

* **C#**
* **.NET 8**
* **ASP.NET Core MVC**
* **ML.NET**
* **Bootstrap**
* **Razor Views**
* **Visual Studio**

---

## 🧠 Machine Learning Model

The application uses a previously trained ML.NET multiclass classification model.

The model was trained using:

* Text Featurization
* Label Mapping
* SDCA Maximum Entropy
* Multiclass Classification

The trained model is loaded from:

```text
MLModels/SymptomsModel.zip
```

The model achieved approximately **92% Macro Accuracy** on the current train/test split used during development.

> This evaluation result is based on the project's current dataset and split. It should not be interpreted as clinical accuracy or medical validation.

---

## 📁 Project Structure

```text
MLNET-Medical-Symptom-Triage-MVC
│
├── Controllers
│   └── HomeController.cs
│
├── Models
│   ├── SymptomInputModel.cs
│   ├── SymptomPredictionModel.cs
│   ├── SymptomInputData.cs
│   └── SymptomPrediction.cs
│
├── Services
│   └── MLModelService.cs
│
├── MLModels
│   └── SymptomsModel.zip
│
├── Views
│   ├── Home
│   │   ├── Index.cshtml
│   │   └── Result.cshtml
│   │
│   └── Shared
│
├── wwwroot
│
├── Program.cs
└── README.md
```

---

## 🔄 How It Works

### 1. User Input

The user enters symptoms into the MVC form.

Example:

```text
I have severe chest pain and difficulty breathing
```

### 2. Controller

`HomeController` receives the submitted symptom text.

### 3. ML Model Service

`MLModelService` loads the trained `SymptomsModel.zip` and sends the symptom text to the prediction engine.

### 4. Prediction

The ML.NET model predicts a category.

Example:

```text
emergency
```

### 5. Result

The prediction is displayed on the result page.

---

## 🚀 Running the Project

### Prerequisites

* Visual Studio
* .NET 8 SDK
* ASP.NET Core development workload

### Steps

Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/MLNET-Medical-Symptom-Triage-MVC.git
```

Open the project in Visual Studio.

Make sure the ML.NET model exists at:

```text
MLModels/SymptomsModel.zip
```

Build the project and run it.

The application will open in the browser.

---

## 🧪 Example

### Input

```text
My knee hurts when I walk and climb stairs.
```

### Model Output

```text
orthopedic
```

Another example:

### Input

```text
My ear has been ringing continuously.
```

### Model Output

```text
ent
```

---

## 📊 Model Evaluation

The underlying ML.NET model achieved approximately:

**92% Macro Accuracy**

on the current train/test split.

The model was developed as an educational machine learning project and has not been clinically validated.

---

## 🔮 Future Improvements

* Improve the dataset with more diverse symptom descriptions
* Add prediction confidence visualization
* Improve handling of ambiguous symptoms
* Add additional UI improvements
* Add automated model evaluation
* Explore more ML.NET classification algorithms
* Improve accessibility and responsive design

---

## 👨‍💻 Author

**Subhranshu**

Engineering Student | C# | ASP.NET Core | ML.NET | Full Stack Development

---

## ⚠️ Disclaimer

This project is intended solely for educational and software-development demonstration purposes.

The predictions generated by this application are not medical diagnoses, and users should consult qualified healthcare professionals for medical concerns.
