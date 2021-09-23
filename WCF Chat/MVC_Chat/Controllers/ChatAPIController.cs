using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Chat.Controllers
{
    public class ChatAPIController : ApiController
    {
        public static ServiceReferenceChat.ServiceClient myService = new ServiceReferenceChat.ServiceClient();
        // GET: api/ChatAPI
        public IEnumerable<ServiceReferenceChat.Chat> Get()
        {
            return myService.GetAllChat().AsEnumerable();
        }

        // GET: api/ChatAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ChatAPI
        public void Post(ServiceReferenceChat.Chat chat)
        {
            myService.SendChat(chat.Content, chat.UserName);
        }

        // PUT: api/ChatAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ChatAPI/5
        public void Delete(int id)
        {
        }
    }
}
