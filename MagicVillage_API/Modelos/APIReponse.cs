using System.Net;

namespace MagicVillage_API.Modelos
{
    public class APIReponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsExitoso { get; set; }

        public List<string> ErrrMessager { get; set; }
        public object Resultado { get; set; }
    }
}
