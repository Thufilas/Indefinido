using System;
using System.Collections.Generic;
using System.Text;

namespace RMJ.Comum.NotificationPattern
{
    public class NotificationResultExcepetion
    {
        private readonly Exception ex;

        public NotificationResultExcepetion(Exception ex)
        {
            this.ex = ex;
        }

        public string PreMessage { get; set; }

        private string MessageError
        {
            get
            {
                string str = "";
                if (!string.IsNullOrEmpty(PreMessage))
                    str = PreMessage + " : ";

                str += ex.InnerException != null ? ex.InnerException.Message : ex.Message;

                return str;
            }
        }

        public NotificationResult Result => new NotificationResult().Add(new NotificationResult().Add(MessageError));
    }
}

