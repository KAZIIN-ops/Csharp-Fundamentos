//Usando Classes
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using Models;














//Listas
List<string> listastring = new List<string>();
 listastring.Add("SP");
 listastring.Add("MA");
 listastring.Add("SE");

//Percorrendo a lista com o for
 for( int Cont=0;Cont< listastring.Count;Cont++){
     Console.WriteLine($"N° {Cont} é {listastring[Cont]}");


 }
//Percorrendo a lista com o foreach
// int contador = 0;
// foreach(string item in listastring){
//     Console.WriteLine($"{contador} {item}");
//     contador++;

// }
 




//ARRAYS

// int [] arrayinteiro =new int[5];
// arrayinteiro[0]=75;
// arrayinteiro[1]=65;
// arrayinteiro[2]=44;
// arrayinteiro[3]=66;
// arrayinteiro[4]=55;

// //Mudar tamanho do array com resize
// Array.Resize(ref arrayinteiro, arrayinteiro.Length*9);

// //percorrendo o array com o for
// for(int cont=0;cont <arrayinteiro.Length;cont++){

//     Console.WriteLine($" Posição N° {cont+1} é {arrayinteiro[cont]}");
// }
// //percorrendo o array com o foreach
// int contador =1;
// foreach(int valor in arrayinteiro){
//     Console.WriteLine($" Posição N° {contador} é {valor}");
//     contador++;

// }










//While com Switch
// string opcao;

// while (true){
//   Console.Clear();
//     Console.WriteLine("Opcao");
//     Console.WriteLine("1 ");
//     Console.WriteLine("2");
//     Console.WriteLine("3");
//     opcao=Console.ReadLine();

//     switch(opcao){

//         case "1":

//             break;

//         case "2":
           
//             break;
            
//         case "3":
//             Console.WriteLine("Finalizando!");
//             Environment.Exit(0);
//             break;

           
//     }
// }

















//Estrutura Do while
// int soma=0, numero =0;

// do{
//     Console.WriteLine("Digite um numero");
//     numero= Convert.ToInt32(Console.ReadLine());
   
//     soma+=numero;

    
// } while(numero!=1);
// Console.WriteLine(soma);


//Estrutura de Repetição While!
// int numero =6;
// int cont=1;
// while (cont<=10){
//     Console.WriteLine($"{cont }° {numero} X {cont} =  {cont * numero}");
//     cont++;
//     if (cont ==6){
//         break;
//     }
//     else if(cont ==3){
//         break;
//     }

// }


//Estrutura de rpetição For com Conversão de String para Inteiro!
// string numero = Console.ReadLine();

//  int numero2 = Convert.ToInt32(numero);

//   int cont =0;
//   for (cont=0; cont <=20;cont++)
//   {
//       Console.WriteLine($"{numero2} X {cont} = {cont * numero2}");
//  }


//Classe Calculadora
// Calculadora calc = new Calculadora();
// calc.Somar(5,5);
// calc.Subtrair(30,50);
// calc.Multiplicar(40,50);
// calc.Divisao(44,56);
// calc.Potencia(5,9);
// calc.Tangente(4);
// calc.Seno(3);
// calc.Coseno(4);
//calc.raizquadrada(9);


//Switch e Case
// Console.WriteLine("Digite uma letra!");
// string letra = Console.ReadLine();
// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal!");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal!");
//         break;


// }

//Condições If, else if e Else
/*int estoque = 5;
int compra =4;
bool possivel = compra >0 && estoque>= compra;
Console.WriteLine(possivel);

if (compra ==0 ){
    Console.WriteLine("Venda Invalida");

}
else if (possivel){
    Console.WriteLine("Venda Realizada");
}
else{
    Console.WriteLine("Quantida de Compra Indisponivel!");
}
*/
//string letra = Console.ReadLine ();
// if (letra == "a"
// |letra== "e"
// |letra=="i"
// |letra=="o"
// |letra =="u"){
//     Console.WriteLine("É uma vogal!");
// }
// else{
//     Console.WriteLine("É uma consoante");
// }

// Condições com '&&'
// bool emaiordeiade= true;
// bool possuiautoridade=false;

// if (emaiordeiade && possuiautoridade == true){
//     Console.WriteLine("Entrada Liberada");

// }
// else
// {
//     Console.WriteLine("Entrada Negada!");
// }


// Operacao com not!
// bool choveu =false;
// bool estatarde = true;
// if ( !choveu && !estatarde)
// {
//     Console.WriteLine("Vou  Pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");

// }





//
// double a=4 /(2.5 +2);
// Console.WriteLine(a);


//cast
//  int a =Convert.ToInt32("5");
//  Console.WriteLine(a);

//  int d =Convert.ToInt32(10);
//  int b =Convert.ToInt32(null);
//  Console.WriteLine(d);
//  Console.WriteLine(b);

// int inteiro =5;
// string a = inteiro.ToString();

//Conversão segura se 'a' não for possivel converte o valor de 'b'.
// string a="15";
// int.TryParse(a,out int b);
// Console.WriteLine(b);



//Variaveis
//  int a = 10;
//  int b = 5;
//  int c = a +b;
//  c+=5;
//  c-=5;

//  Console.WriteLine(c);

//Datetime
//  DateTime dataatual=DateTime.Now;
//  Console.WriteLine(dataatual.ToString("dd/MM/yyyy HH:mm"));

//Tipos de Variaveis
//  string Apresentar ="ola mundo";
//  int quantidade =1;
//  double altura = 1.80;
//  decimal preco=1.80m;

//  Console.WriteLine(Apresentar);
//  Console.WriteLine(quantidade);
//  Console.WriteLine(altura);
//  Console.WriteLine(preco);

