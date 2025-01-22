using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Reserva
    {

            private static decimal desconto = 0.1M;
            public List<Pessoa> Hospedes { get; set; }
            public Suite Suite { get; set; }
            public int DiasReservados { get; set; }

            public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados) 
            { 
                Hospedes = hospedes;
                Suite = suite;
                DiasReservados = diasReservados;
        
            }

            public Reserva(int diasReservados)
            {
                DiasReservados = diasReservados;
            }

            public void CadastrarHospedes(List<Pessoa> hospedes)
            {
                // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
                // *IMPLEMENTE AQUI*
                if (hospedes.Count <= Suite.Capacidade)
                {
                    Hospedes = hospedes;    
                }
                else
                {
                throw new ArgumentException("Número de hospedes ultrapassa a capacidade da suíte.");
                    // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                    // *IMPLEMENTE AQUI*
                }
            }

            public void CadastrarSuite(Suite suite)
            {
                Suite = suite;
            }

            public int ObterQuantidadeHospedes()
            {
                return Hospedes.Count;
            }

            public decimal CalcularValorDiaria()
            {

            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*

            decimal valor = DiasReservados >= 10 ? Suite.ValorDiaria * DiasReservados * (1 - desconto) : Suite.ValorDiaria * DiasReservados;

                // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
                // *IMPLEMENTE AQUI*

                return valor;
            }
        }
}
