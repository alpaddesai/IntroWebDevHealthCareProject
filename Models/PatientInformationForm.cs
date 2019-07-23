using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace HealthCareProject.Models
{
    public class PatientInformationForm
    {
        public List<myNewPatient> PatientDatabase = new List<myNewPatient>();

       public PatientInformationForm()
        {

        }

      public int CreatePatientDatabase()
        {
            using (System.IO.StreamReader rwinformation = System.IO.File.OpenText("PatientDatabase.txt"))
            {
                string readLine;
                while ((readLine = rwinformation.ReadLine()) != null)  // reads one line at a time
                {
                    char delimiter = ',';
                    string[] parseReadLine = readLine.Split(delimiter); // string of arrays

                    // HealthRecordsFirstNameVariable, HealthRecordsLastNameVariable, HeightVariable, WeightVariable, MedicationsVariable, FamilyHistoryVariable, AllergiesVariable, MedicalHistoryVariable, ImmunizationsVariable, DiagnosisandTestResultsVariable, ZipCodeVariable
                    myNewPatient PatientObject = new myNewPatient(parseReadLine[0], parseReadLine[1], parseReadLine[2], parseReadLine[3], parseReadLine[4], parseReadLine[5], parseReadLine[6], parseReadLine[7], parseReadLine[8], parseReadLine[9], parseReadLine[10]);
                    PatientDatabase.Add(PatientObject);
                }

            }

          return 0;
        }  // create patient database


      
    } // patient information
} // Health_Care_Project
