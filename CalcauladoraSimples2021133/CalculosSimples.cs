﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculosSimples
{
    public double Somar(double numero1, double numero2)
    {
        double soma = numero1 + numero2;
        return soma;
    }

    public double Subtrair(double numero1, double numero2)
    {
        double subtracao = numero1 - numero2;
        return subtracao;
    }

    public double Dividir(double numero1, double numero2)
    {
        double divisao = numero1 / numero2;
        return divisao;
    }

    public double Multiplicar(double numero1, double numero2)
    {
        double multiplicacao = numero1 * numero2;
        return multiplicacao;
    }
}
