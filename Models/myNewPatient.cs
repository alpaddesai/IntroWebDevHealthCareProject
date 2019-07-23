using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace HealthCareProject.Models
{
    public class myNewPatient
    {
        public string HealthRecordsFirstName { get; set; }
        public string HealthRecordsLastName { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Medications { get; set; }

        public string FamilyHistory { get; set; }
        public string Allergies { get; set; }

        public string MedicalHistory { get; set; }

        public string Immunizations { get; set; }

        public string DiagnosisandTestResults { get; set; }

        public string ZipCode { get; set; }

        public myNewPatient(string HealthRecordsFirstNameVariable, string HealthRecordsLastNameVariable, string HeightVariable, string WeightVariable, string MedicationsVariable, string FamilyHistoryVariable, string AllergiesVariable, string MedicalHistoryVariable, string ImmunizationsVariable, string DiagnosisandTestResultsVariable, string ZipCodeVariable)
        {
            HealthRecordsFirstName = HealthRecordsFirstNameVariable;
            HealthRecordsLastName = HealthRecordsLastNameVariable;
            Height = HeightVariable;
            Weight = WeightVariable;
            Medications = MedicationsVariable;
            FamilyHistory = FamilyHistoryVariable;
            Allergies = AllergiesVariable;
            MedicalHistory = MedicalHistoryVariable;
            Immunizations = ImmunizationsVariable;
            DiagnosisandTestResults = DiagnosisandTestResultsVariable;
            ZipCode = ZipCodeVariable;
        }

        public override string ToString()
        {
            return $"\n {HealthRecordsFirstName} {HealthRecordsLastName} {Height} {Weight} {Medications} {FamilyHistory} {Allergies} {MedicalHistory} {Immunizations} {DiagnosisandTestResults} {ZipCode} \n ";
        }


        public string RecommendAnInsurancePlan(myNewPatient element)
        {
            int cost = 0;

            switch (element.MedicalHistory)
            {
                case "EyeGlasses":
                    cost = 500;
                    break;
                case "Diabetes":
                    cost = 1000;
                    break;
                case "DentalHealthIssues":
                    cost = 500;
                    break;
                case "MorethanOneHealthIssue":
                    cost = 1500;
                    break;
                default:
                    break;
            }


            if (cost < 1000)
                return $"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} should select the basic health insurance plan with eye med and dental care ";
            else
                return $"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} should select the premium health insurance plan with eye med and dental care ";
        }


        public string RecommendPrimaryCarePhysician(myNewPatient element)
        {
            string RecommendPrimaryCarePhysicianText;

            switch (element.ZipCode)
            {
                case "02115":
                    RecommendPrimaryCarePhysicianText = $"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} should select amongst primary care physicians Dr. PersonA , Dr. PersonB and Dr. PersonC which are near zipcode {element.ZipCode }";
                    break;
                case "01803":
                    RecommendPrimaryCarePhysicianText = $"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} should select amongst primary care physicians Dr. PersonD , Dr. PersonE and Dr. PersonF which are near zipcode {element.ZipCode }";
                    break;
                case "02120":
                    RecommendPrimaryCarePhysicianText = $"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} should select amongst primary care physicians Dr. PersonG , Dr. PersonH and Dr. PersonI which are near zipcode {element.ZipCode }";
                    break;
                default:
                    RecommendPrimaryCarePhysicianText = $"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} should select amongst primary care physicians Dr. PersonA , Dr. PersonB and Dr. PersonC which are near zipcode {element.ZipCode }";
                    break;
            }

            return RecommendPrimaryCarePhysicianText;
        }


        public string RecommendSpecialists(myNewPatient element)
        {
            StringBuilder recommendSpecialistText = new StringBuilder();

            switch (element.DiagnosisandTestResults)
            {
                case "NormalBloodTest":
                    recommendSpecialistText.Append($"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} does not need a specialist");
                    break;
                case "LowVitaminD":
                    recommendSpecialistText.Append($"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} requires a nutritionalist");
                    break;
                default:
                    recommendSpecialistText.Append($"Patient {element.HealthRecordsFirstName} {element.HealthRecordsLastName} does not need a specialist");
                    break;
            }

            switch (element.FamilyHistory)
            {
                case "NoMajorFamilyHistoryIssue":
                    recommendSpecialistText.Append($" and has no major family medical history to report");
                    break;
                case "DiabetesFamilyHistory":
                    {
                        if (element.ZipCode == "02115")
                            recommendSpecialistText.Append($" and requires a diabetes specialist, recommendations include specialist A , specialist B and specialist C for zip code {element.ZipCode}");
                        else if (element.ZipCode == "01803")
                            recommendSpecialistText.Append($"and requires a diabetes specialist, recommendations include specialist D , specialist E and specialist F for zip code {element.ZipCode}");
                        else if (element.ZipCode == "02120")
                            recommendSpecialistText.Append($"and requires a diabetes specialist, recommendations include specialist G , specialist H and specialist I for zip code {element.ZipCode}");
                    }
                    break;
                default:
                    recommendSpecialistText.Append($" and has no major family medical history to report");
                    break;
            }
            return recommendSpecialistText.ToString();
        }


    }
}
