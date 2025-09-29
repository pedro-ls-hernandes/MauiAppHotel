using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public double QntAdultos { get; set; }
        public double QntCriancas { get; set; }
        public DateTime DataCheckIn {  get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia => DataCheckOut.Subtract(DataCheckIn).Days;

        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos = QuartoSelecionado.ValorDiarioAdulto;

                double valor_criancas = QntCriancas = QuartoSelecionado.ValorDiarioCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;
            }
        }
    }
}
