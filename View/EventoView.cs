using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos_MVC.Model;

namespace Eventos_MVC.View
{
    public class EventoView
    {
        public void Listar(List<Evento> evento)
        {
            Console.Clear();

            foreach (var item in evento)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Descricao: {item.Descricao}");
                Console.WriteLine($"Data: {item.Data}");
            }
        }

        public Evento Cadastrar()
        {
            Evento novo = new Evento();

            Console.WriteLine($"Informe o nome: ");
            novo.Nome = Console.ReadLine()!;
            
            Console.WriteLine($"Informe a descricao");
            novo.Descricao = Console.ReadLine()!;
            
            Console.WriteLine($"Informe o dia do evento (numero apenas)");
            novo.Data = int.Parse(Console.ReadLine()!);
            
            return novo;
        }
    }
}