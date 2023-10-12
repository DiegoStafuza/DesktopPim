using DesktopPim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPim.Controller
{
    public class LoginController
    {
        private UserRepo userRepository;

        public LoginController(UserRepo userRepository)
        {
            this.userRepository = userRepository;
        }
        public bool AutenticaUsu(string email, string senha)
        {
            return userRepository.AutenticaUsu(email, senha);
        }
    }
}
