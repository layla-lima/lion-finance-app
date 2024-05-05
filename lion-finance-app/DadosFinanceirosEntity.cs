using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lion_finance_app
{
    public class DadosFinanceirosEntity
    {
        // Propriedades públicas para os dados financeiros
        public double RendaFixa { get; set; }
        public double RendaVariavel { get; set; }
        public DespesasEntity Despesas { get; set; }

        // Construtor da classe DadosFinanceirosEntity
        public DadosFinanceirosEntity(double rendaFixa, double rendaVariavel, DespesasEntity despesas)
        {
            RendaFixa = rendaFixa;
            RendaVariavel = rendaVariavel;
            Despesas = despesas;
        }

        // Definição da classe DespesasEntity
        public class DespesasEntity
        {
            // Propriedades públicas para os dados de despesas
            public double Financiamento { get; set; }
            public double Contas { get; set; }
            public double Parcelamento { get; set; }
            public double Aluguel { get; set; }
            public double Compras { get; set; }
            public double Lazer { get; set; }
            public double Transporte { get; set; }

            // Construtor da classe DespesasEntity
            public DespesasEntity(double financiamento, double contas, double parcelamento, double aluguel, double compras, double lazer, double transporte)
            {
                Financiamento = financiamento;
                Contas = contas;
                Parcelamento = parcelamento;
                Aluguel = aluguel;
                Compras = compras;
                Lazer = lazer;
                Transporte = transporte;
            }
        }
    }
}
