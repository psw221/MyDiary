using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Model.Login
{
    public class LoginResult
    {
        public string success { get; set; }
        public string message { get; set; }
        public string errors { get; set; }
        public string data { get; set; }
    }
}
