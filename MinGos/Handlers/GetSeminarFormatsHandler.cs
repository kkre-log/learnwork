using MinGos.BusinessLayer;
namespace MinGos.Handlers
{
    [ApiHandler("/Seminars/GetSeminarFormats", "MONITOR", "default")]
    public class GetSeminarFormatsHandler : ApiHandlerBase
    {
        public override  object Handle()
        {
            return new
            {
                data = new
                {
                    row = new[]
                    {
                      new
                      {
                        formatCode = "1",
                        formatName = "Очный"
                      },
                      new
                      {
                        formatCode = "2",
                        formatName = "Онлайн"
                      }
                    }
                }
            };
        }
    }
}