using System;
using System.Collections.ObjectModel;
using System.Linq;
using SimpleChat.MVVM.Model;

namespace SimpleChat.MVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; } = new();
        public ObservableCollection<ContactModel> Contacts { get; set; } = new();

        public MainViewModel()
        {
            Messages.Add(new MessageModel
            {
                Username = "Allison",
                UsernameColour = "#3577FF",
                ImageSource = "",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                IsFirstMessage = true
            });

            Enumerable.Repeat(new MessageModel
            {
                Username = "Allison",
                UsernameColour = "#3577FF",
                ImageSource = "",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
            }, 3).ToList().ForEach(model => Messages.Add(model));
            Enumerable.Repeat(new MessageModel
            {
                Username = "Bob",
                UsernameColour = "#FF0013",
                ImageSource = "",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            }, 2).ToList().ForEach(model => Messages.Add(model));
            
            Messages.Add(new MessageModel
            {
                Username = "Bob",
                UsernameColour = "#FF0013",
                ImageSource = "",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });
            Contacts.Add(new ContactModel
            {
                Username = "Allison",
                ImageSource = "",
                Messages = Messages 
            });
        }
    }
}