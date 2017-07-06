using System;

namespace Domain{
    public class Regra{

        public Regra(TipoDeRegra descricao, double valor, int quantidadeDePontos){
            Descricao = descricao;
            Valor = valor;
            QuantidadeDePontos = quantidadeDePontos;
        }

        public TipoDeRegra Descricao{get; private set;}    
        public double Valor{get; private set;}
        public int QuantidadeDePontos{get; private set;}

        public double Pontuar(double valorDeCompra){
            var retorno = 0.0;
            if(valorDeCompra >= Valor){
                Console.WriteLine($"Parabens você ganhou {QuantidadeDePontos} pontos");
                return 0;
            }else{
                if(Descricao == TipoDeRegra.ValorDeComprasAcumulativo){
                    retorno = valorDeCompra;
                }
            }
            return retorno;
        }
    }
}