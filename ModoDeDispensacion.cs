using System;
namespace CajeroAutomatico
{
    
    public class ModoDeDispensacion
    {
        public  int Valor1 { get; set; } = 0;
        public int Valor2 { get; set; } = 0;
        public int Valor3 { get; set; } = 0;
        public int Valor4 { get; set; } = 0;
        public int Cifra { get; set; }
        int count1;
        int count2;
        int count3;
        int count4;

        public ModoDeDispensacion(int opcion)
        {
        }

        public void Modo1(int cifra)
        {

            while (this.Cifra - this.Valor1 >= 0)
            {
                this.Cifra -= this.Valor1;
                count1++;   
            }

            while (this.Cifra - this.Valor2 >= 0)
            {
                this.Cifra -= this.Valor2;
                count2++;
            }
        }

        public void Modo2(int cifra)
        {
            while (this.Cifra - this.Valor3 >= 0)
            {
                this.Cifra -= this.Valor3;
                count3++;
            }

            while (this.Cifra - this.Valor4 >= 0)
            {
                this.Cifra -= this.Valor4;
                count4++;
            }
        }

        public void Modo3(int cifra)
        {

        }
        
    }
}

/* public string Nombre { get; set; }

        public Categorias(string Nombre )
        {
            this.Nombre = Nombre;
        }*/