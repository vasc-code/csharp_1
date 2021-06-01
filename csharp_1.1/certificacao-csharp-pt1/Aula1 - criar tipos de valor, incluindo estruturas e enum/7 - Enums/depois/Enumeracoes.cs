using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            DiasDaSemana primeiroDia = DiasDaSemana.Seg;
        }
    }

    enum DiasDaSemana { Seg=3, Ter, Qua, Qui, Sex, Sab, Dom }
}
