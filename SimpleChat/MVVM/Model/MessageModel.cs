using System;

namespace SimpleChat.MVVM.Model
{
    public class MessageModel
    {
        public string Username { get; set; }
        public string UsernameColour { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool? IsFirstMessage { get; set; }
    }
}