using System;
namespace CajeroAutomatico
{
    public class Menu
    {
        public static int Opcion { get; set; }

        static ModoDeDispensacion modo = new ModoDeDispensacion();
        //int opcion = 0;
        public Menu()
        {

        }
        public static void menu()
        {
            Console.WriteLine("Bienvenido a su cajero preferido!!\n\n");
            Console.WriteLine("1-Modo de dispensacion\n2-Retiro de dinero\n\nSeleccione la opcion deseada:");

            try
            {
                int opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nModo de dispensacion\n\n");

                        Console.WriteLine("1-De 200 y 1000\n2-De 100 y 500\n3-Eficiente: 1000,500,200 y 100  \n\nSeleccione la opcion deseada:");
                        opcion = Convert.ToInt16(Console.ReadLine());
                        if (opcion > 3)
                        {
                            Console.WriteLine("\nDebe ingresar una opcion correcta. Pulse enter");
                            Console.ReadKey();
                            
                        }
                        //asignacion a propiedad
                        Opcion = opcion;
                        Console.WriteLine("\n\nModo guardado. Pulse enter.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("\nRetiro de dinero\n\n");
                         menuRetiro();
                        break;

                    default:
                        Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                        Console.ReadKey();

                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                Console.ReadKey();
                Console.Clear();
                menu();
            }
            menu();
        }

        public static void menuRetiro()
        {
            Console.WriteLine("\nIngrese cifra de dinero a retirar, referente al modo de dispensacion. Ejemplo:1000 :");

            int cifra = Convert.ToInt32(Console.ReadLine());
            if (Opcion == 1)
            {
                if (cifra % 200 == 0 && cifra > 199)
                {
                    modo.Cifra = cifra;
                    modo.Modo1();
                    Console.ReadKey();
                }
            }
            
            if (Opcion == 2)
            {
                if (cifra % 2 == 0 && cifra > 99)
                {
                    modo.Cifra = cifra;
                    modo.Modo2();
                    Console.ReadKey();
                }
            }
            
            if (Opcion == 3)
            {
                if (cifra % 2 == 0 || cifra % 200 == 0 && cifra >= 100)
                {
                    modo.Cifra = cifra;
                    modo.Modo3();
                    Console.ReadKey();
                }
            }
            else
            {
                Error();
            }
        }
        public static void salida()
        {
            Console.WriteLine("\n\nPara Continuar (1)\nPara salir (2)\n\nSeleccione la opcion deseada:");
            int salir = Convert.ToInt16(Console.ReadLine());
            switch (salir)
            {
                case 1:
                    Console.Clear();
                    menu();
                    break;
                case 2:
                    Console.WriteLine("Gracias por Preferirnos. Pulse Enter");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                    Console.ReadKey();
                    salida();
                    break;
            }
        }
        public static  void Error()
        {
            Console.WriteLine("\nDebe ingresar una cifra adecuada al monto de dispensacion. Pulse enter");
            Console.ReadKey();
            //menuRetiro();
        }
    }
}
//Hansel De Los Santos Ramirez (202010355)