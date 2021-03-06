/* 

Desafios Aritméticos Intermediários em C#
2 / 3 - Tipos de Triângulos

Intermediário - Princípios Básicos

Desafio
Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo 
que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo 
que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma 
mensagem adequada:

se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
Entrada
A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) 
e C (0 < C).

Saída
Imprima todas as classificações do triângulo especificado na entrada.

|---------------------------------------------------------------|
|       Exemplos de Entrada     |       Exemplos de Saída       |
|---------------------------------------------------------------|
|           7.0 5.0 7.0         |       TRIANGULO ACUTANGULO    |
|                               |       TRIANGULO ISOSCELES     |
|---------------------------------------------------------------|
|           6.0 6.0 10.0        |       TRIANGULO OBTUSANGULO   |
|                               |       TRIANGULO ISOSCELES     |
|---------------------------------------------------------------|
|           6.0 6.0 6.0         |       TRIANGULO ACUTANGULO    |
|                               |       TRIANGULO EQUILATERO    |
|---------------------------------------------------------------|
|           5.0 7.0 2.0         |       NAO FORMA TRIANGULO     |
|---------------------------------------------------------------|
|           6.0 8.0 10.0        |       TRIANGULO RETANGULO     |
|---------------------------------------------------------------|

*/


using System; 
class TiposTriangulos {
    static void Main(string[] args) { 

            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            double aux;

            if(a < b){
                aux = a;
                a = b;
                b = aux;
            }

            if(a < c){
                aux = a;
                a = c;
                c = aux;
            }

            if(b < c){
                aux = b;
                b = c;
                c = aux;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                    
                if (a == b && a == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }

                if ((a == b && a != c) || (a == c && a != b)){
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

            Console.ReadLine();
    }

}