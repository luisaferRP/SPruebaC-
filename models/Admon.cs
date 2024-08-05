using System.Reflection.Metadata;
using SimulacroPruebaC.models;

namespace SimulacroPruebaC.models
{
    public class Admon
    {
        //miembros listas
        public static List<Vehicle> VehicleList = new List<Vehicle>();
        public static List<Customer> CustomersList = new List<Customer>();
        public static List<Driver> DriversList = new List<Driver>();
        //miembros añadir 
        public void AddVehivle(Vehicle vehicle)
        {
            VehicleList.Add(vehicle);
        }

        public void AddCustomer(Customer customer)
        {
            CustomersList.Add(customer);
            Mensaje.MensageSuccesAdd();
        }

        public static void AddDriver(Driver driver)
        {
            DriversList.Add(driver);
            Mensaje.MensageSuccesAdd();
        }

        //mostrar conductor
        public static void ShowDrivers()
        {
            foreach (var driver in DriversList)
            {
                driver.ShowDriver();
            }
        }

        //mostrar clientes
        public static void ShowCustomers()
        {

            foreach (var customer in CustomersList)
            {
                customer.ShowCustomer();
            }
        }

        //mostrar vehiculo
        public static void ShowVehicles()
        {
            foreach (var item in VehicleList)
            {
                item.ShowVehicles();
            }

        }
        //eliminar driver
        public static void Delete()
        {

            Console.WriteLine("¿Que vas a eliminar? 1.Condutor , 2.cliente, 3.vehiculo");
            int optionDelete = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Por favor ingrese el id (conductor y cliente) y placa para vehiculo");
            var dato = Console.ReadLine();

            if (optionDelete == 1)
            {
                var idExit = DriversList.FirstOrDefault(item => item.returnId() == dato);

                if (idExit != null)
                {
                    DriversList.Remove(idExit);
                    Mensaje.MensageEliminarSucces();
                }
                else
                {
                    Mensaje.MensageEliminarError();
                }

            }
            else if (optionDelete == 2)
            {
                var idExit = CustomersList.FirstOrDefault(item => item.returnId() == dato);

                if (idExit != null)
                {
                    CustomersList.Remove(idExit);
                    Mensaje.MensageEliminarSucces();
                }
                else
                {
                    Mensaje.MensageEliminarError();
                }
            }else if(optionDelete == 3){

                var findVehicle = VehicleList.FirstOrDefault(item => item.Placa == dato);

                if (findVehicle != null)
                {
                    VehicleList.Remove(findVehicle);
                    Mensaje.MensageEliminarSucces();
                }
                else
                {
                    Mensaje.MensageEliminarError();
                }
            }
        }

        //validacion de si existe el owner y me lo devuelve
        public static Driver ExistOwner(string DocumentNumber){
            var FindOwner = DriversList.FirstOrDefault(item =>item.returnTypeDocument() == DocumentNumber);
            return FindOwner;
        }

    }
}




