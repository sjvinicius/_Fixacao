using System;

namespace _Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {

        // 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
        // ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

            // int at = 0;
            // int an = 0;
            // int idade = 0; 

            // Console.Write("Digite o ano atual: ");
            // at = int.Parse( Console.ReadLine() );
            // Console.Write("Digite o seu ano de nascimento: ");
            // an = int.Parse( Console.ReadLine() );

            // idade = at - an ;

            // if ( idade >=16 ) {
                
            //     Console.ForegroundColor = ConsoleColor.Green;
            //     Console.WriteLine("Você ja esta apto a tirar o seu titulo e ir as urnas ");
            //     Console.Write(":D :D :D :D :D :D :D :D :D :D");
            //     Console.ResetColor();

            // }
            // else{
            //     Console.ForegroundColor = ConsoleColor.Red;
            //     Console.WriteLine("Infelizmente voce esta inapto à ir as urnas");
            //     Console.Write("D: D: D: D: D: D: D: D: D: D:");
            //     Console.ResetColor();
            // }

            // 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
            // Álcool:
            // . até 20 litros, desconto de 3% por litro Álcool
            // . acima de 20 litros, desconto de 5% por litro
            // Gasolina:
            // . até 20 litros, desconto de 4% por litro Gasolina
            // . acima de 20 litros, desconto de 6% por litro

            // Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
            // da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
            // sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
            // Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


            // char combustivel;
            // double qtdl; 
            // double pg = 5.30;
            // double pa = 4.90;
            // double totp;
            // double desc;
            
            // do
            // {
                

            // Console.WriteLine("=============================");
            // Console.WriteLine("PERGUNTA LA NO POSTO IPIRANGA");
            // Console.WriteLine("=============================");

            // Console.Write("\n Álcool ou Gasolina (A-álcool // G-gasolina):");
            // combustivel = char.Parse( Console.ReadLine() );

            // } while ( combustivel != 'A' && combustivel != 'G' && combustivel != 'a' && combustivel != 'g' ); 

            // switch (combustivel) {
            //     case ('A'):
            //         Console.Write("Insira a QTD de litros abastecido: " );
            //         qtdl = double.Parse( Console.ReadLine() );
            //             if (qtdl > 20){
                        
            //                 desc = qtdl * pa / 100 * 5;
            //                 totp = qtdl * pa - desc;

            //                 Console.WriteLine($"O Valor total é: {qtdl * pa} com o desconto de: {desc}");                            
            //                 Console.WriteLine($"O Valor total a pagar é: {totp}");                            
            //             }
                        
            //             else if (qtdl > 0 && qtdl < 20) {

            //             desc = qtdl * pa / 100 * 3;
            //             totp = qtdl * pa - desc;

            //             Console.WriteLine($"O Valor total é: {qtdl * pa} com o desconto de: {desc}");                            
            //             Console.WriteLine($"O Valor total a pagar é: {totp}");

            //             };
            //         break;
            //     case ('a'):

            //         Console.Write("Insira a QTD de litros abastecido: " );
            //         qtdl = double.Parse( Console.ReadLine() );
            //             if (qtdl >= 20){
                        
            //                 desc = qtdl * pa / 100 * 5;
            //                 totp = qtdl * pa - desc;

            //                 Console.WriteLine($"O Valor total é: {qtdl * pa} com o desconto de: {desc}");                            
            //                 Console.WriteLine($"O Valor total a pagar é: R${totp}");  
                            
            //             }

            //             else if (qtdl > 0 && qtdl < 20) {

            //             desc = qtdl * pa / 100 * 3;
            //             totp = qtdl * pa - desc;

            //             Console.WriteLine($"O Valor total é: {qtdl * pa} com o desconto de: {desc}");                            
            //             Console.WriteLine($"O Valor total a pagar é: {totp}");

            //             };
            //         break;

            //     case ('G'):

            //         Console.Write("Insira a QTD de litros abastecidos:");
            //         qtdl = double.Parse( Console.ReadLine() );
                    
            //         if (qtdl >= 20) {

            //             desc = qtdl * pg / 100 * 6;
            //             totp = qtdl * pg - desc;

            //             Console.WriteLine($"O Valor total é: {qtdl * pg} com o desconto de: {desc}");                            
            //             Console.WriteLine($"O Valor total a pagar é: {totp}");

            //         }

            //        else if (qtdl > 0 && qtdl < 20) {

            //             desc = qtdl * pg / 100 * 4;
            //             totp = qtdl * pg - desc;

            //             Console.WriteLine($"O Valor total é: {qtdl * pg} com o desconto de: {desc}");                            
            //             Console.WriteLine($"O Valor total a pagar é: {totp}");

            //         };

                                           
            //         break;
                
            //     case ('g'):
            //         Console.Write("Insira a QTD de litros abastecidos:");
            //         qtdl = double.Parse( Console.ReadLine() );

            //         if (qtdl > 20) {

            //             desc = qtdl * pg / 100 * 20;
            //                 totp = qtdl * pg - desc;

            //                 Console.WriteLine($"O Valor total é: {qtdl * pg} com o desconto de: {desc}");                            
            //                 Console.WriteLine($"O Valor total a pagar é: {totp}");

            //         }
                    
            //         break;

            //     default:

            //         Console.WriteLine("Essa não é uma opção válida");

            //         break;
            // }     


            // 3. Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
            // preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
            // desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
            // - Se quantidade <= 5 o desconto será de 2%
            // - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
            // - Se quantidade > 10 o desconto será de 5%
            // Dica: utilize if / else if / else

            // string nome;
            // float pu;
            // float qtda;
            // float totp;
            // float desc;
            // float totpd;
            // string refazer = "";

            // do
            // {
                
            // Console.Write("Digite o nome do produto adquirido: ");
            // nome = Console.ReadLine();

            // Console.Write("Digite o preço do produto: R$");
            // pu = float.Parse( Console.ReadLine() );

            // Console.Write("Digite a Quantidade de produto adquirido: ");
            // qtda = float.Parse( Console.ReadLine() );

            // if (qtda <= 5)
            // {
            //     desc = pu * qtda / 100 * 2;
            //     totp = pu * qtda;
            //     totpd = pu * qtda - desc;

            //     Console.WriteLine($"\nO valor unitário de {nome} é R${pu}, comprando {qtda},");
            //     Console.WriteLine($"\nO valor total é: R$ {totp} com o desconto de: R${desc}");
            //     Console.WriteLine($"O valor à ser pago é: R$ {totpd}");
            // }
            // else if (qtda > 5 && qtda <=10)
            // {
            //     desc = pu * qtda / 100 * 3;
            //     totp = pu * qtda;
            //     totpd = pu * qtda - desc;

            //     Console.WriteLine($"\nO valor unitário de {nome} é R${pu}, comprando {qtda},");
            //     Console.WriteLine($"\nO valor total é: R$ {totp} com o desconto de: R${desc}");
            //     Console.WriteLine($"O valor à ser pago é: R$ {totpd}");
            // }
            // else if (qtda > 10)
            // {
            //     desc = pu * qtda / 100 * 5;
            //     totp = pu * qtda;
            //     totpd = pu * qtda - desc;

            //     Console.WriteLine($"\nO valor unitário de {nome} é R${pu}, comprando {qtda}");
            //     Console.WriteLine($"\nO valor total é: R$ {totp} com o desconto de: R${desc}");
            //     Console.WriteLine($"O valor à ser pago é: R$ {totpd}");
            // }

            

            // Console.WriteLine("\n Deseja refazer a operação? (enter) ou (insira outro valor)");
            // refazer = Console.ReadLine();

            // } while (refazer == "");

            // Estruturas de repetição:
            // 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
            // menor valor lido.


            // int [] num = new int [10];
            // int mav = 0;
            // int men = 0;


            // for (var i = 0; i < 10; i++)
            // {
            //     Console.WriteLine($"Digite o {i+1}º Valor: ");
            //     num[i] = int.Parse(Console.ReadLine());

            // }

            // for (var i = 1; i <= 8; i++)
            // {                    
            //     if (num[i] <= num[i-1] || num[i] <= num[i+1]) 
            //     {
                    
            //         men = num[i];

            //     }
                

            //     if(num[i] >= num[i-1] || mav >= num[i] ){

            //         mav = num[i];

            //     }


            // }
            
            // Console.WriteLine($"\nO menor valor é: {men}");
            // Console.WriteLine($"O maior valor é: {mav}");



            // Console.WriteLine("Os valores inseridos foram: ");

            // for (var i = 0; i < q; i++)
            // {
            //     Console.Write($"{num[i]},");
                
            // }

            // 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
            // Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

            // int r;

            // for (var i = 0; i < 11; i++)
            // {
            //     for (var c = 0; c < 11; c++)
            //     {
            //         r = c * i;
            //         Console.WriteLine($"{c} * {i} = {r} ");

                    
            //     }

            //         Console.WriteLine($"================");
            // }


            // Vetores:
            // 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
            // lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
            // pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
            // entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.


            // int qtdp = 10;
            // string [] nomes = new string [10];
            // string search;

            // for (var i = 0; i < qtdp; i++)
            // {
                
            //     Console.Write($"Digite o nome da {i+1}º pessoa: ");
            //     nomes[i] = Console.ReadLine();

            // };

            // Console.Write("Digite o nome de busca: ");
            // search = Console.ReadLine();

            // for (var i = 0; i < qtdp; i++)
            // {
            //     if (nomes[i] == search)
            //     {
            //     Console.ForegroundColor = ConsoleColor.Green; 
            //     Console.Write(" ACHEI");
            //     Console.ResetColor();
            //     }
            //     if ( !(nomes[i] == search) )
            //     {
            //     Console.ForegroundColor = ConsoleColor.Red;
            //     Console.Write(" NAO ACHEI") ;
            //     Console.ResetColor();
            //     }

            // }

            // 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
            // 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
            // declarado.

            // int val = 15;
            // double [] num = new double [15];

            // for (var i = 0; i < val; i++)
            // {
            //     Console.Write($"Digite o {i+1}º numero: ");
            //     num [i] = double.Parse( Console.ReadLine() );
            // };

            // for (var c = num.Length; c >= 1; c--)
            // {
            //     Console.Write($" ( {num[c-1]} ) ");
            // };
        }
    }
}