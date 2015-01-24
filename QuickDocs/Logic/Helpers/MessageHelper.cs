using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickDocs.Logic
{
    public class MessageHelper
    {
        private static Dictionary<MessageCode, String> _errors;

        static MessageHelper()
        {
            _errors = new Dictionary<MessageCode, string>();
            _errors.Add(MessageCode.LoginIsExist, "Логин занят");
            _errors.Add(MessageCode.LoginSymbolQuantity, "Минимум 6 символов");
            _errors.Add(MessageCode.PasswordSymbolQuantity, "Минимум 6 символов");
            _errors.Add(MessageCode.InternalError, "Внутренняя ошибка");
            _errors.Add(MessageCode.OK, "OK");
        }

        public static String GetErrorDescription(MessageCode code)
        {
            try
            {
                return _errors[code];
            }
            catch (Exception)
            {
                return "Ошибка словаря";
            }

            
        }
    }

    public enum MessageCode
    {
        LoginSymbolQuantity,
        LoginIsExist,
        InternalError,
        PasswordSymbolQuantity,
        OK
    }

    
}