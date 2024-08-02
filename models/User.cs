namespace SimulacroPruebaC.models
{
    public class User
    {
        //miembros atributos
        protected Guid Id {get;set;}
        protected string Name {get;set;}
        protected string LastName { get; set; }
        protected string TypeDocument { get; set; }
        protected string IdentificationNumber {get;set;}
        protected DateOnly BrithDate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Adreess {get;set;}

        //miembro constructor
        public User(string name,string lastName,string typeDocument,string identificationNumber,
        DateOnly brithDate,string email,string phoneNumber,string adreess )
        {
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            BrithDate = brithDate;
            Email = email;
            PhoneNumber = phoneNumber;
            Adreess = adreess;
        }

        //miembro ver detalles
        public void ShowDetails(){

        }

        //miembro calcular edad
        public int CalculateAge(){
            return DateTime.Now.Year - BrithDate.Year;
        }

        //miembro ver edad 
        public void ShowAge(){
            Console.WriteLine($"Su edad es: {CalculateAge()}");
        }




    }
}