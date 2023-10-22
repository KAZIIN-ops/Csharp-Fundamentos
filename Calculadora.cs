using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Models
{
    public class Calculadora
    {
        public void Somar (int x , int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair (int x , int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
         public void Multiplicar (int x , int y){
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
         public void Divisao (int x , int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia (int x, int y){
           double pot= Math.Pow(x,y);
           Console.WriteLine($"{x}^{y}={pot}");
       
        
           }
            public void Seno (double angulo){
               double radiano =angulo * Math.PI /180;
               double seno = Math.Sin(radiano);
               Console.WriteLine ($" seno de {angulo} é igual a {Math.Round( seno,4)}");

            }
             public void Coseno (double angulo){
               double radiano =angulo * Math.PI /180;
               double Cosseno = Math.Cos(radiano);
               Console.WriteLine ($" Cosseno de {angulo} é igual a {Math.Round( Cosseno,4)}");

        }
             public void Tangente (double angulo){
               double radiano =angulo * Math.PI /180;
               double tangente = Math.Tan(radiano);
               Console.WriteLine ($" Tangente de {angulo} é igual a {Math.Round( tangente, 4)}");

        }
            public void raizquadrada (double x)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($" a raiz de {x} é {raiz}");
                
            }

    }
}
    
    
