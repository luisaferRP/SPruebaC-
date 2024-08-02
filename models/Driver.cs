using System.Runtime.CompilerServices;

namespace SimulacroPruebaC.models
{
    public class Driver : User
    {
        //miembros atributos
        public string LicenseNumber {get;set;}
        public string LicenseCategory {get;set;}
        public int DrivingExperience { get; set; }

        //miembro constructor
        public Driver(string Name,string LastName,string TypeDocument,string IdentificationNumber,DateOnly BrithDate,string Email,string PhoneNumber,
        string Adreess,string licenseNumber,string licenseCategory,int drivingExperience): base(Name, LastName, TypeDocument, IdentificationNumber, BrithDate, Email,PhoneNumber, Adreess)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperience;
        }

        //Actualizar la categoria de licensia 
        public void UpdateLicenseCategory(string newCategory){
            LicenseCategory = newCategory;
        }

        //añadir años de experiencia
        public void AddExperience(int years){
            DrivingExperience += years;
        }
    }
}