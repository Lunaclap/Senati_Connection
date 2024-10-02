using LunaSenatiConnection.Views;
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




        public ObservableCollection<Message> Messages
        {
            get => messages;
            set => SetProperty(ref messages, value);
        }

        // Propiedad para el mensaje seleccionado
        public Message SelectedMessage
        {
            get => selectedMessage;
            set
            {
                if (SetProperty(ref selectedMessage, value) && selectedMessage != null)
                {
                    // Invocar el comando de navegación al seleccionar un chat
                    NavigateToChatCommand.Execute(selectedMessage);
                }
            }
        }

        public Command<Message> NavigateToChatCommand { get; } //obtener mensaje de seleccion de chat

        public MainPageViewModel()
        {
            Messages = new ObservableCollection<Message>();
            GenerateSource();

            // Inicializar el comando de navegación
            NavigateToChatCommand = new Command<Message>(OnNavigateToChat);
        }

        private async void OnNavigateToChat(Message selectedChat)
        {
            if (selectedChat != null)
            {
                // Navega a la página del chat seleccionado
                await Application.Current.MainPage.Navigation.PushAsync(new Chat(selectedChat)); // Pasa el mensaje seleccionado
            }
        }


        // Método para cargar mensajes de ejemplo
        private void GenerateSource()
        {
            Messages.Add(new Message { 
                Sender = "Desarrollo de Aplicaciones Móviles", 
                Content = "Hola!", 
                Initials = "AP" });
            Messages.Add(new Message { 
                Sender = "Seminario de Complementacion III", 
                Content = "¿Cómo estás?", 
                Initials = "SC" });
            Messages.Add(new Message { 
                Sender = "Mejora de Metodos", 
                Content = "Buenas noches", 
                Initials = "MM" });
        }
    }
    public class Message
    {
        public string Sender { get; set; }          // Nombre del remitente
        public string Content { get; set; }         // Contenido del mensaje
        public string Initials { get; set; }        // Iniciales para el avatar
    }



    //private async void OnNavigateToChat(Message selectedChat)
    //{
        
    //}

}