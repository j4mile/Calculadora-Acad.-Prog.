using System.Reflection.Metadata.Ecma335;

string continuar = "";

do
{
    Console.Clear();
    Console.WriteLine("---------------\n| CALCULADORA |\n---------------\n");

    Console.WriteLine("Insira o primeiro número: ");
    double primeiroNum = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nInsira o segundo número: ");
    double segundoNum = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\nEscolha a operação:\n1. Adição\n2. Subtração\n3. Multiplicação\n4. Divisão\n");
    int operacao = Convert.ToInt16(Console.ReadLine());

    switch (operacao)
    {
        case 1:
            Console.WriteLine("Operação escolhida: adição");
            double adicao = primeiroNum + segundoNum;
            Console.WriteLine(primeiroNum + " + " + segundoNum + " = " + adicao);
            break;

        case 2:
            Console.WriteLine("Operação escolhida: subtração");
            double subtracao = primeiroNum - segundoNum;
            Console.WriteLine(primeiroNum + " - " + segundoNum + " = " + subtracao);
            break;

        case 3:
            Console.WriteLine("Operação escolhida: multiplicação");
            double mult = primeiroNum * segundoNum;
            Console.WriteLine(primeiroNum + " x " + segundoNum + " = " + mult);
            break;

        case 4:
            Console.WriteLine("Operação escolhida: divisão");
            if (primeiroNum == 0 || segundoNum == 0)
            {
                Console.WriteLine("Esse número é inválido para essa operação. Por favor, digite outro.");
                break;
            }
            else
            {
                double divisao = primeiroNum / segundoNum;
                Console.WriteLine(primeiroNum + " : " + segundoNum + " = " + divisao);
                break;
            }

        default:
            Console.WriteLine("\nOpção inválida. Escolha entre os números acima.");
            break;
    }

    Console.WriteLine("\nDeseja continuar?\nDigite \"sim\" ou \"s\". Pressione qualquer outra tecla para sair.");
    continuar = Console.ReadLine();
}
while (continuar == "sim" || continuar == "s");

