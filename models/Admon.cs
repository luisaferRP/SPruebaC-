using SimulacroPruebaC.models;

namespace SimulacroPruebaC.models
{
    public class Admon
    {
        //miembros listas
        public List<Vehicle> VehicleList = new List<Vehicle>();
        public List<Customer> CustomersList = new List<Customer>();
        public static List<Driver> DriversList = new List<Driver>(); 
        //miembros añadir 
        public void AddVehivle(Vehicle vehicle){
            VehicleList.Add(vehicle);
        }

        public void AddCustomer(Customer customer){
            CustomersList.Add(customer);
            mensaje.MensageSuccesAdd();
        }
    
        public static void AddDriver(Driver driver)
        {
            DriversList.Add(driver); 
            mensaje.MensageSuccesAdd();
        }

        public static void ShowDriver(){
            foreach (var item in DriversList)
            {
            
                
            }
        }

    }
}




