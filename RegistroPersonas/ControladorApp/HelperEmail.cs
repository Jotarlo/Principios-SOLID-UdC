using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ControladorApp
{
    public class HelperEmail
    {
        public  bool EnviarCorreo(String asunto, String mensaje, String destino)
        {
            using (var client = new HttpClient())
            {
                var data = string.Format("asunto={0}&contenido={1}&destino={2}&hash=admin12345", asunto, mensaje, destino);
                var request = WebRequest.Create("http://enviar-correo.jal-software.com/api/SendEmailService?" + data);
                request.Method = "GET";
                using (var requestResponse = (HttpWebResponse)request.GetResponse())
                {
                    using (var reader = new StreamReader(requestResponse.GetResponseStream(), Encoding.UTF8))
                    {
                        /*JavaScriptSerializer js = new JavaScriptSerializer();
                        var objText = reader.ReadToEnd();

                        if (objText.Contains("OK"))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }*/
                        return true;
                    }
                }
            }
        }


    }
}
