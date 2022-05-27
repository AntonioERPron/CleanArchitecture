using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meta.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public int CPF { get; set; }
        public string Nome { get; set; }
    }
}
