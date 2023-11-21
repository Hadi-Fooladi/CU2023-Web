using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PhoneBookWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MainController : ControllerBase
    {
        public List<Contact> GetContacts() => Global.Contacts;

        public string Add(
            string firstname,
            string lastName,
            string email,
            string phone,
            string gender)
        {
            Global.Add(new Contact
            {
                FirstName = firstname,
                LastName = lastName,
                Email = email,
                PhoneNumber = phone,
                Gender = gender
            });
            return "Success";
        }
    }
}