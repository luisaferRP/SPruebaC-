using System;

using SimulacroPruebaC.models;

class Program
{
    static void Main(string[] args)
    {
        int option;

        do
        {
            VisualInterfaz.Visual();
            try
            {
                bool opSuccess = int.TryParse(Console.ReadLine(), out option);
                if (opSuccess != true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Ey! ¡Por favor ingresa un dato valido!");
                    Console.ResetColor();
                }

                //switch
                switch (option)
                {
                    case 1:
                        Console.WriteLine(@"
                        **************Conductor**********
                        1.Agregar conductor.
                        2.Mostrar conductores.
                        3.Actualizar conductor.
                        4.ELiminar conductor.");
                        int option2;
                        bool optionSuccess = int.TryParse(Console.ReadLine(), out option2);
                        
                        switch (option2)
                        {
                            case 1:
                                AddDriver();
                                break;
                            case 2:
                                Admon.ShowDrivers();
                                break;
                            
                            default:
                                break;
                        }
                        
                        break;


                    case 2:
                        AddCustormer();
                        break;
                    case 3:
                        AddVehicle();
                        break;

                    default:
                        break;
                }

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Ey! ¡Por favor ingresa un dato valido!");
                Console.ResetColor();
            }

        } while (true);

        //metodos
        void AddDriver()
        {
            Console.WriteLine("Ingrese los datos del conductor:");
            Console.WriteLine("Nombre:");
            string name = Console.ReadLine();

            Console.WriteLine("Apellido:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Tipo de documento ej: C.c");
            string typeDocument = Console.ReadLine();

            Console.WriteLine("Numero de documento:");
            string identificationNumber = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento: AAAA-MM-DD");
            DateOnly brithDate;
            bool brith = DateOnly.TryParse(Console.ReadLine(), out brithDate);

            Console.WriteLine("Email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Numero de telefono: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Direccion: ");
            string adreess = Console.ReadLine();

            Console.WriteLine("Numero de licencia: ");
            string licenseNumber = Console.ReadLine();

            Console.WriteLine("¿Qué tipo de vehiculo maneja? ");
            string typeVehicle = Console.ReadLine().Trim();

            string licenseCategory = "Not found";


            if (typeVehicle.Equals("moto", StringComparison.OrdinalIgnoreCase))
            {
                licenseCategory = "A2";
            }
            else if (typeVehicle.Equals("carro", StringComparison.OrdinalIgnoreCase) || typeVehicle.Equals("camioneta", StringComparison.OrdinalIgnoreCase) || typeVehicle.Equals("microbus", StringComparison.OrdinalIgnoreCase))
            {
                licenseCategory = "B2";
            }
            else
            {
                Console.WriteLine("Por favor ingresa un vehiculo valido");
            }

            Console.WriteLine("Experiencia de condución: ");
            int drivingExperience = Convert.ToInt32(Console.ReadLine());

            Driver newDrive = new Driver(name, lastName, typeDocument, identificationNumber, brithDate, email, phoneNumber, adreess, licenseNumber, licenseCategory, drivingExperience);
            Admon.AddDriver(newDrive);
        }

        void AddCustormer()
        {
            Console.WriteLine("Ingrese los datos del cliente:");
            Console.WriteLine("Nombre:");
            string name = Console.ReadLine();

            Console.WriteLine("Apellido:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Tipo de documento ej: C.c");
            string typeDocument = Console.ReadLine();

            Console.WriteLine("Numero de documento:");
            string identificationNumber = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento: AAAA-MM-DD");
            DateOnly brithDate;
            bool brith = DateOnly.TryParse(Console.ReadLine(), out brithDate);

            Console.WriteLine("Email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Numero de telefono: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Direccion: ");
            string adreess = Console.ReadLine();

            Console.WriteLine("Nivel de afiliación: ");
            string membershipLevel = Console.ReadLine();

            Console.WriteLine("Metodo de pago preferido eje: pago en efectivo. ");
            string preferredPaymentMethod = Console.ReadLine();

            Customer newCustomer = new Customer(name, lastName, typeDocument, identificationNumber, brithDate, email, phoneNumber, adreess, membershipLevel, preferredPaymentMethod);
            Admon admon = new Admon();
            admon.AddCustomer(newCustomer);
        }

        void AddVehicle()
        {
            Console.WriteLine(@"****************** Ingrese los datos del vehiculo ******************");

            Console.WriteLine("Placa del vehiculo:");
            string placa = Console.ReadLine();

            Console.WriteLine("Tipo de vehiculo :");
            string type = Console.ReadLine();

            Console.WriteLine("Numero de motor:");
            string engineNumber = Console.ReadLine();

            Console.WriteLine("Numero de serie:");
            string serialNumber = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de vehiculo que maneja (moto,carro,camioneta,microbus):");
            string typeVehicle = Console.ReadLine();

            //Me aseguro de que cada valor numérico esté convertido a byte 
            byte peopleCapacity = typeVehicle == "moto" ? (byte)2 : typeVehicle == "carro" ? (byte)4 : typeVehicle == "camioneta" ? (byte)6 : typeVehicle == "microbus" ? (byte)14 : (byte)0;

        }
    }

}




