using System;

namespace API.Models
{
    public class FolhaPagamento
    {
        public int Id { get; set; }

        public virtual Funcionario Funcionario { get; set;}
        public int FuncionarioId { get; set; }
        public double Valorhora { get; set; }
        public double Quantidadehoras { get; set; }
        public double Salariobruto { get; set; }
        public double  Impostoderenda { get; set; }
        public double Impostoinss { get; set; }
        public double Impostofgts { get; set; }
        public double Salarioliquido { get; set; }
    }
}