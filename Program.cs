using Eventos_MVC.Model;
using Eventos_MVC.Controller;

Evento eventos = new Evento();
EventoController ec = new EventoController();

ec.CadastrarEvento();
ec.ListarEventos();