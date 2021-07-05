using System;
namespace CajeroAutomatico
{
    public class ModoDeDispensacion
    {
        static Menu menu = new Menu();
        public int Valor1 {get;}=1000;
        public int Valor2 {get;}=200;
        public int Valor3 {get;}=500;
        public int Valor4 {get;}=100;
        public int Cifra {get; set;}
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        public ModoDeDispensacion()
        {
             
        }

        public void Modo1()
        {

            Cuenta(Valor1, Valor2, count1, count2);
        }

        public void Modo2()
        {
            Cuenta(Valor3, Valor4, count3, count4);
         }

        public void Modo3()
        {   //Eficiente
            while (this.Cifra - this.Valor1 >= 0)
            {
                this.Cifra -= this.Valor1;
                count1++;
            }
            while (this.Cifra - this.Valor3 >= 0)
            {
                this.Cifra -= this.Valor3;
                count3++;
            }
            while (this.Cifra - this.Valor2 >= 0)
            {
                this.Cifra -= this.Valor2;
                count2++;
            }
            while (this.Cifra - this.Valor4 >= 0)
            {
                this.Cifra -= this.Valor4;
                count4++;
            }
            Console.WriteLine("\nSe le dio "+count1+" papeletas de "+Valor1+", "+count3+" papeletas de "+Valor3+", "+count2+" papeletas de "+Valor2+" y "+count4+" papeletas de "+Valor4+ "\n\nPulse Enter.");
            Console.ReadKey();
            Console.Clear();
            Menu.salida();
        }

        public void Cuenta(int Valor1,int Valor2,int count1, int count2)
        {
            while (this.Cifra - Valor1 >= 0)
            {
                this.Cifra -= Valor1;
                count1++;
            }
            //Cuenta(Valor2, count2);
            while (this.Cifra - Valor2 >= 0)
            {
                this.Cifra -= Valor2;
                count2++;
            }
            Console.WriteLine("\nSe le dio " + count1 + " papeletas de " + Valor1 + ", " + count2 + " papeletas de " + Valor2 + "\n\nPulse Enter.");
            Console.ReadKey();
            Console.Clear();
            Menu.salida();
        }
    }
}