namespace MinGos.BusinessLayer
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ApiHandlerAttribute : Attribute
    {
        public string WindowCode { get; }
        public string ActionType { get; }
        public string ActionCode { get; }

        public ApiHandlerAttribute(string windowCode, string actionType, string actionCode)
        {
            WindowCode = windowCode;
            ActionType = actionType;
            ActionCode = actionCode;
        }
    }
}