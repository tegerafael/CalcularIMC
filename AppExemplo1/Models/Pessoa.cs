﻿namespace AppExemplo1.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double CalcularImc()
        {
            return Peso / (Altura * Altura);
        }
    }
}
