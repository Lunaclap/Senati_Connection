using LunaSenatiConnection.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LunaSenatiConnection.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class ChatViewModel : BaseViewModel
    {
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public string Status { get; set; }

        private List<ChatViewModel> _messages;
        public List<ChatViewModel> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }


        public ChatViewModel()
        {
            // Load sample messages (this could be dynamic in the future)
            Messages = new List<ChatViewModel>()
            {
                new ChatViewModel()
                {
                    FromUser = "Freud",
                    ToUser = "Luna",
                    Message = "Hola, este es un mensaje de prueba",
                    DateSent = DateTime.Now,
                    Status = "Sent",
                },
                new ChatViewModel()
                {
                    FromUser = "Luna",
                    ToUser = "Freud",
                    Message = "Hola, este es un segundo mensaje de prueba",
                    DateSent = DateTime.Now,
                    Status = "Received",
                }
            };
        }

        public ChatViewModel(Message message)
        {
            FromUser = message.Sender; // Asigna el remitente
            Message = message.Content;  // Asigna el contenido
                                        // Aquí podrías inicializar otras propiedades si es necesario
        }
    }
}