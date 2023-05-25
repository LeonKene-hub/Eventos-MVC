using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos_MVC.Model;
using Eventos_MVC.View;

namespace Eventos_MVC.Controller
{
    public class EventoController
    {
        Evento e = new Evento();
        EventoView ev = new EventoView();

        public void ListarEventos()
        {
            List<Evento> eventos = e.Ler();
            ev.Listar(eventos);
        }

        public void CadastrarEvento()
        {
            Evento novo = ev.Cadastrar();
            e.Inserir(novo);
        }
    }
}