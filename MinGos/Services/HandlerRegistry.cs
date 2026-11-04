using System.Reflection;
using MinGos.BusinessLayer;

namespace MinGos.Services
{
    public static class HandlerRegistry
    {
        public static Type? Find(string windowCode, string actionType, string actionCode)
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(type =>
                {
                    var sticker = type.GetCustomAttribute<ApiHandlerAttribute>();
                    return sticker != null
                      && sticker.WindowCode == windowCode
                      && sticker.ActionType == actionType
                      && sticker.ActionCode == actionCode;
                });
        }
    }
}