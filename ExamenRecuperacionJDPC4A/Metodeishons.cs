using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRecuperacionJDPC4A
{
    internal class Metodeishons
    {
        public void Vendedores()
        {
            int[,] ganancias =
            {
                {500,3000,100,400 },
                {1000,150,200,500 },
                {250,1800,2900,300 },
                {400,130,90,2400 },
                {60,20,4000,3600 }
                };
            int[,] producto = new int[5, 5];
            int[,] vendedor = new int[4, 4];


            for (int i =0; i < ganancias.GetLength(0); i++)
            {
                for (int j =0; j < ganancias.GetLength(1); j++)
                {
                    producto[0, i] += ganancias[0, j];
                    producto[1, i] += ganancias[1, j];
                    producto[2, i] += ganancias[2, j];
                    producto[3, i] += ganancias[3, j];
                    producto[4, i] += ganancias[4, j];

                    vendedor[j,0] += ganancias[i,0];
                    vendedor[j, 1] += ganancias[i, 1];
                    vendedor[j, 2] += ganancias[i, 2];
                    vendedor[j, 3] += ganancias[i, 3];

                }
            }
            for (int i = 0; i<vendedor.GetLength(0);i++)
            Console.WriteLine("La ganancia de1 vendedor "+i +" es "+vendedor[i,i]);

            for (int i = 0; i <producto.GetLength(0); i++)
                Console.WriteLine("La ganancia del producto "+i+" es "+producto[i, i]);
        }
        
        public void Curp()
        {
            Console.WriteLine("Favor de Ingresar su Curp Profesor");
            string curp =Console.ReadLine();
            if (curp.Length != 18)
                Console.WriteLine("La curp no es valida, revise sus datos.");
            else { 

           string sexo= curp.Substring(10,1);
            if (sexo == "H" || sexo == "h")
                sexo = "masculino";
            else
                sexo = "mujer";


            string año= curp.Substring(4,2);
            string mes = curp.Substring(6,2);
            string dia = curp.Substring(8,2);

            if (Convert.ToInt32(año) > 23)
              año = "19"+año;
            else
                año = "20"+año;

            Console.WriteLine($"Usted es de sexo {sexo} y su fecha de nacimiento es {dia}/{mes}/{año}.");
            }
        }

        public void NumerosDesordenados()
        {
            Random rambo = new Random();
            int[] numeros= new int[10];
            for (int i=0;i<numeros.Length; i++) 
            {
                numeros[i]= rambo.Next(70,100);
            }
            Console.WriteLine("Numeros Desordenados");
            Console.Write(string.Join(",",numeros));

            int auxiliar = 0;
            for(int i=0; i<numeros.Length-1; i++)
            {
                for(int j=0; j<numeros.Length-1; j++) 
                {
                    if (numeros[j]< numeros[j+1])
                    {
                        auxiliar = numeros[j];
                        numeros[j] = numeros[j+1];
                        numeros[j+1]= auxiliar;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Numeros ordenados");
            Console.Write(string.Join(",", numeros));
            Console.WriteLine();
            int encontrar = 75;
            bool centinela=false;
            for (int c = 0; c <numeros.Length; c++) { 
             

                if (numeros[c]==encontrar)
                {
                    Console.WriteLine("El numero " +encontrar +" se encuentra en la posicion " + c);
                    centinela = true;
                }
                }
                if (!centinela)
            {
                Console.WriteLine("El numero no se encuentra");
            }
        }
    }
}
