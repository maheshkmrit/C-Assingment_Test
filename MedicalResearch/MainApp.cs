using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalResearch;

namespace MedicalResearch
{

    class HelperFunctions
    {
        public static void HelperGetAllDiseases()
        {
            DiseaseRepo ds = new DiseaseRepo();

            Disease[] data = ds.GetAllDisease();
            foreach (var disease in data)
            {
                Console.WriteLine($"{disease.DiseaseName} {disease.DiseaseCause} {disease.DiseaseSeverity}");
            }
        }

        public static void HelperAddDisease()
        {
            Console.WriteLine("Enter the Disease Name: ");
            string dName = Console.ReadLine();
            Console.WriteLine("Enter the Disease Severity: [high, low, Mid]");
            string dServ = Console.ReadLine();
            Console.WriteLine("Enter the Disease Cause: [internal Factor, ExternalFactor]");
            string cause = Console.ReadLine();

            DiseaseRepo ds = new DiseaseRepo();

            ds.AddDisease(new Disease { DiseaseName = dName, DiseaseCause = cause, DiseaseSeverity = dServ });

            Console.WriteLine("Added successful: ");

        }

        public static void HelperAddPatient()
        {
            Console.WriteLine("Enter the Patient Id: ");
            int Pid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Patient Name: ");
            string PName = Console.ReadLine();


            Console.WriteLine("Enter the Patient Disease: ");
            string dName = Console.ReadLine();



            PatientRepo pr = new PatientRepo();
            Disease ds = new Disease { DiseaseName = dName, DiseaseCause = "Fever", DiseaseSeverity = "Dengue" };
            Patient ps = new Patient();
            ps.SetDisease(ds);


            pr.AddPatient(new Patient { PatientId = Pid, PatientName = PName, });

            Console.WriteLine("Added successful: ");

        }

        public static void HelperGetAllPatient()
        {
            PatientRepo ds = new PatientRepo();

            Patient[] data = ds.GetAllPatient();
            foreach (var pat in data)
            {
                Console.WriteLine($"{pat.PatientId} {pat.PatientName}");
            }
        }


    }














    class MainApp
    {


        static void Main(string[] args)
        {
            DiseaseRepo ds = new DiseaseRepo();
            Disease newDisease = new Disease { DiseaseName = "Maleria", DiseaseCause = "High-Fever", DiseaseSeverity = "Mid" };
            Disease ds1 = new Disease { DiseaseName = "Cough", DiseaseCause = "Cold", DiseaseSeverity = "High" };
            ds.AddDisease(newDisease);
            ds.AddDisease(ds1);
            //HelperFunctions.HelperGetAllDiseases();
            //HelperFunctions.HelperAddDisease();
            //HelperFunctions.HelperGetAllDiseases();
            //DiseaseRepo dk = new DiseaseRepo();


            DiseaseRepo dd = new DiseaseRepo();

            Disease[] data = dd.GetAllDisease();
            foreach (var disease in data)
            {
                Console.WriteLine($"{disease.DiseaseName} {disease.DiseaseCause} {disease.DiseaseSeverity}");
            }
            Ui.UiConsole();





        }

    }

    class Ui
    {
        public static void UiConsole()
        {
            HelperFunctions hs = new HelperFunctions();
            string AppHeader = "------------------------Medical Research Application-----------------------------------------------------------\n\n";

            string display = "Press 1 --------------->to Add Disease\nPress 2 --------------->Get All Diseases\nPress 3 --------------->to Add Patient\nPress 4 --------------->to view all Patient\nPress 5 --------------->to Exit";
            //Console.WriteLine(display);
            bool operation = true;
            while (operation)
            {
                Console.WriteLine(AppHeader);
                Console.WriteLine(display);
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HelperFunctions.HelperAddDisease();
                        Console.WriteLine("enter to clear screen");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "2":
                        HelperFunctions.HelperGetAllDiseases();
                        Console.WriteLine("enter to clear screen");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "3":
                        HelperFunctions.HelperAddPatient();
                        Console.WriteLine("enter to clear screen");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "4":
                        HelperFunctions.HelperGetAllPatient();
                        Console.WriteLine("enter to clear screen");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "5":
                        operation = false;

                        Console.WriteLine("Thank You for using our App");
                        break;

                    default:
                        break;


                }
            }
        }
    }
}
