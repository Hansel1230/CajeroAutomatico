using System;
namespace CajeroAutomatico
{
    public class Menu
    {
        static ModoDeDispensacion modo = new ModoDeDispensacion(9);
        //int opcion = 0;
        public static void menu()
        {
            Console.WriteLine("Bienvenido a su cajero preferido!!\n\n");
            Console.WriteLine("1-Modo de dispensacion\n2-Retiro de dinero\n\nSeleccione la opcion deseada:");
            int opcion = Convert.ToInt16(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nModo de dispensacion\n\n");
                    menudispensacion();
                    Console.WriteLine("\n\nPulse enter.");
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("\nRetiro de dinero\n\n");
                    menuRetiro();
                    modo.Modo3();
                    Console.WriteLine("\n\nPara Continuar (1)\nPara salir (2)\n\nSeleccione la opcion deseada:");
                    int  salir = Convert.ToInt16(Console.ReadLine());
                    salida(salir);
                    break;
            }
            menu();
        }
        public static void menudispensacion()
        {
            Console.WriteLine("1-De 200 y 1000\n2-De 100 y 500\n3-Eficiente: 1000,500,200 y 100  \n\nSeleccione la opcion deseada:");
            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    menuRetiro();
                    modo.Modo1();
                    Console.ReadKey();
                    break;
                case 2:
                    menuRetiro();
                    modo.Modo2();
                    Console.ReadKey();
                    break;
                case 3:
                    menuRetiro();
                    modo.Modo3();
                    Console.ReadKey();
                    break;
            }
        }
        public static void menuRetiro()
        {
            Console.WriteLine("\nIngrese cifra de dinero a retirar, referente al modo de dispensacion. Ejemplo:1000 :");
            int cifra = Convert.ToInt32(Console.ReadLine());

            if (cifra % 2 == 0 && cifra > 100)
            {
                modo.Cifra = cifra;
            }
            else
            {
                Console.WriteLine("\nDebe ingresar una cifra adecuada al monto de dispensacion. Pulse enter");
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