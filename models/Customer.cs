namespace SimulacroPruebaC.models
{
    public class Customer : User
    {
        //miembro atributos
        public string MembershipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }

        //miembro constructor
        public Customer(string Name,string LastName,string TypeDocument,string IdentificationNumber,DateOnly BrithDate,string Email,string PhoneNumber,
        string Adreess,string membershipLevel,string preferredPaymentMethod):base(Name, LastName, TypeDocument, IdentificationNumber, BrithDate, Email,PhoneNumber, Adreess)
        {
            MembershipLevel = membershipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
        }

        //actualizar membership Level(nivel de afiliacion)
        public void UpdateMembershipLevel(){
            
        }

        //ver cliente
        public void ShowCustomer(){
            Console.WriteLine(@$"
            --------------------------------------- Cliente  -----------------------------------------
            Id : {Id} Nombre: {Name,-5}, Apellido: {LastName,-5},
            Tipo de documento : {TypeDocument}, Numero de identificació: {IdentificationNumber},
            Fecha de nacimiento :{BrithDate} , Correo electronico: {Email},
            Numero de telefono : {PhoneNumber}, Direccion : {Adreess} ,
            Nivel de afiliación : {MembershipLevel} Metodo de pago preferido {this.PreferredPaymentMethod}");
        }
    }
}