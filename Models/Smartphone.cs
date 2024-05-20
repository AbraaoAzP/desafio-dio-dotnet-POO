using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDOTNETPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string Imei;
        protected int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria; 
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void RecebendoLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informações:\nNúmero: {Numero}\nModelo: {Modelo}\nIMEI: {Imei}\nMemória: {Memoria}Gb");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}