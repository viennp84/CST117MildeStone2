using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone2
{
    class User
    {
        public User() { }
        public User(int userId, string username,string password,string createOn,string lastLogin)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.createOn = createOn;
            this.lastLogin = lastLogin;
        }
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string createOn { get; set; }
        public string lastLogin { get; set; }
    }
}
