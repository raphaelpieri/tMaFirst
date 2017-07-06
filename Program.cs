using System;
using Domain; 

namespace teste_avaliacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            var opcao = 0;
            Regra regra = null;
            var valorInformado = 0.0;
            do{
                Console.WriteLine("Informar Regra: 1");
                Console.WriteLine("Informar Valores: 2");
                Console.WriteLine("Sair: -1");
                Console.WriteLine("Selecione uma opção: ");
                var opcaoEscolhida = Console.ReadLine();
                opcao = int.Parse(opcaoEscolhida);

                switch(opcao){
                    case 1:
                        regra = InformarRegra();
                        break;
                    case 2:
                        valorInformado = Pontuar(valorInformado,regra);
                        Console.WriteLine(valorInformado);
                        break;

                }
            }while(opcao != -1);
        }

        static Regra InformarRegra(){
            Console.WriteLine("Digite a regra: \n1.Valor de compras não acumulativo \n2.Valor de compras acumulativa");
            var regra = short.Parse(Console.ReadLine());

            if(regra < 1 || regra > 2){
                throw new Exception("Regra informada invalida");
            }

            Console.WriteLine("Digite o valor:");
            var valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de pontos a ganhar:");
            var pontos = int.Parse(Console.ReadLine());

            return new Regra((TipoDeRegra)regra, valor, pontos);
        }

        static double Pontuar(double valor, Regra regra){
            if(regra == null){
                throw new Exception("Deve ser informada uma regra");
            }

            Console.WriteLine("Digite o valor comprado: ");
            var valorComprado = double.Parse(Console.ReadLine());
            
            valor += valorComprado;
            return regra.Pontuar(valor);
        }
    }
}
