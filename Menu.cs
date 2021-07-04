using System;
namespace CajeroAutomatico
{
    public class Menu
    {
        static ModoDeDispensacion modo = new ModoDeDispensacion(9);
        public static void menu()
        {
            Console.WriteLine("Bienvenido a su cajero preferido!!\n\n");
            Console.WriteLine("1-Modo de dispensacion\n2-Retiro de dinero\n\nSeleccione la opcion deseada:");
            int opcion = Convert.ToInt16(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Modo de dispensacion\n\n");
                    menudispensacion();
                    break;

                case 2:
                    Console.WriteLine("Retiro de dinero\n\n");
                    menuRetiro();

                    Console.WriteLine("Para Continuar (1)\nPara salir (2)\n\nSeleccione la opcion deseada:");
                    int  salir = Convert.ToInt16(Console.ReadLine());
                    salida(salir);
                    break;
            }
        }

        public static void menudispensacion()
        {
            Console.WriteLine("1-De 200 y 1000\n2-De 100 y 500\n3-Eficiente: 100,200,500 y 1000\n Seleccione la opcion deseada:");
            int opcion = Convert.ToInt16(Console.ReadLine());
            //ModoDeDispensacion(opcion);
        }

        public static void menuRetiro()
        {
            Console.WriteLine("\nIngrese cifra de dinero a retirar, referente al modo de dispensacion. Ejemplo:1000 :");
            int cifra = Convert.ToInt32(Console.ReadLine());

            if (cifra % 2 == 0 && cifra > 100)
            {

            }
            else
            {
                Console.WriteLine("Debe ingresar una cifra adecuada al monto de dispensacion. Pulse enter");
                Console.ReadKey();
                menuRetiro();
            }
        }

        public static void salida(int salir)
        {
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
            }
        }
    }
}