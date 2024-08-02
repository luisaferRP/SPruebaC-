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
                        ******Conductor******
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
                            case 3:
                            //actualizar
                                break;
                            case 4:
                                Admon.Delete();
                                break;

                            
                            default:
                                break;
                        }
                        
                        break;

                    case 2:
                    Console.WriteLine(@"
                        ****** Cliente ******
                        1.Agregar Cliente.
                        2.Mostrar Cliente.
                        3.Actualizar Cliente.
                        4.ELiminar Cliente.");

                        int option3;
                        bool optionSucces = int.TryParse(Console.ReadLine(), out option3);

                        switch (option3)
                        {
                            case 1:
                                AddCustormer();
                                break;
                            case 2:
                                Admon.ShowCustomers();
                                break;
                            case 3:
                            //actualizar
                                break;
                            case 4:
                                Admon.Delete();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                    Console.WriteLine(@"
                        ****** Vehiculo ******
                        1.Agregar un Vehiculo.
                        2.Mostrar Vehiculos.
                        3.Actualizar un vehiculo.
                        4.ELiminar un vehiculo.");

                        int option4;
                        bool optionSuccessV = int.TryParse(Console.ReadLine(), out option4);

                        switch (option4)
                        {
                            case 1:
                                AddVehicle();
                                break;
                            case 2: 
                            Admon.ShowVehicles();
                                break;
                            case 3:
                            //actualizar
                                break;
                            case 4: 
                                Admon.Delete();
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                    Console.WriteLine("La opción ingresada no es valida");
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

        //driver-------------------------------------
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

        //customer---------------------------------
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
        //vehicle--------------------------------------
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

        
            Console.WriteLine("Por favor ingrese el tipo de documento del conductor :");
            string DocumentNumber = Console.ReadLine();

            //validación de si existe el owner
            var FindOwner = Admon.ExistOwner(DocumentNumber);

            if(FindOwner != null){

                Vehicle newVehicle = new Vehicle(placa,type,engineNumber,serialNumber,peopleCapacity,FindOwner);

            }else
            {
                Console.WriteLine("El conductor no existe,creemos uno.");
                AddDriver();
                Console.WriteLine("Por favor ingrese el tipo de documento del conductor :");
                string FindDocumentNumber = Console.ReadLine();
                var FindOwnerD = Admon.ExistOwner(FindDocumentNumber);

                Vehicle newVehicle = new Vehicle(placa,type,engineNumber,serialNumber,peopleCapacity,FindOwner);
            }
        }
    }

}




