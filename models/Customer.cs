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
    }
}