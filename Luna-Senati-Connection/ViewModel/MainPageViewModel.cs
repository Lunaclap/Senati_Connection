using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LunaSenatiConnection.ViewModel
{
	public class MainPageViewModel : BaseViewModel

	{
        private ObservableCollection<Message> messages; // Colección de mensajes
        private Message selectedMessage; // Mensaje seleccionado

        // Propiedad para almacenar la colección de mensajes
        public ObservableCollection<Message> Messages
        {
            get => messages;
            set => SetProperty(ref messages, value);
        }

        // Propiedad para el mensaje seleccionado
        public Message SelectedMessage
        {
            get => selectedMessage;
            set => SetProperty(ref selectedMessage, value);
        }

        public MainPageViewModel()
        {
            Messages = new ObservableCollection<Message>(); // Inicializa la colección de mensajes
            GenerateSource(); // Genera mensajes de ejemplo
        }

        // Método para cargar mensajes de ejemplo
        private void GenerateSource()
        {
            Messages.Add(new Message { Sender = "Desarrollo de Aplicaciones Móviles", Content = "Hola!", Initials = "AP" });
            Messages.Add(new Message { Sender = "Seminario de Complementacion III", Content = "¿Cómo estás?", Initials = "SC" });
            Messages.Add(new Message { Sender = "Mejora de Metodos", Content = "Buenas noches", Initials = "MM" });
        }
    }
    public class Message
    {
        public string Sender { get; set; }          // Nombre del remitente
        public string Content { get; set; }         // Contenido del mensaje
        public string Initials { get; set; }        // Iniciales para el avatar
    }

}