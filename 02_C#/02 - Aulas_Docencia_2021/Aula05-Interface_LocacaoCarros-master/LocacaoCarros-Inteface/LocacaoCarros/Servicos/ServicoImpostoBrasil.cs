﻿using System;

namespace LocacaoCarros.Servicos
{
    //class ServicoImpostoBrasil 

    //vamos colocar esta classe como filha(subclasse) da Interface
    class ServicoImpostoBrasil : IServicoImposto
    {
        public double Imposto(double valor)
        {
            if (valor <= 100.00)
            {
                return valor * 0.2; // mesma coisa de 20%
            }
            else
            {
                return valor * 0.15; // mesma coisa de 15%
            }
        }
    }
}
