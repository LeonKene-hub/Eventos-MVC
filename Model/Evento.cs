using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos_MVC.Model
{
    public class Evento
    {
        public string Nome { get; set; } = "";
        public string Descricao { get; set; } = "";
        public int Data { get; set; }
        private const string PATH = "Database/Evento.csv";

        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] propriedades = item.Split(";");
                Evento e = new Evento();

                e.Nome = propriedades[0];
                e.Descricao = propriedades[1];
                e.Data = int.Parse(propriedades[2]);

                eventos.Add(e);
            }
            return eventos;
        }

        public string FormarLinha(Evento e)
        {
            return $"{e.Nome};{e.Descricao};{e.Data}";
        }

        public void Inserir(Evento e)
        {
            string[] linhas = {FormarLinha(e)};
            File.AppendAllLines(PATH,linhas);
        }
    }
}