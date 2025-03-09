using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations d'authentification
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// Getter de Login
        /// </summary>
        public string Login { get; }

        /// <summary>
        /// Getter de Pwd
        /// </summary>
        public string Pwd { get; }
        
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Admin(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
