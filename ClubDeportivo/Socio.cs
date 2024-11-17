using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class Socio
    {
        private string name;
        private string lastname;
        private string document;
        private string birthday;
        private string gender;
        private string email;

        public Socio(string name, string lastname, string document, string birthday, string gender, string email)
        {
            this.name = name;
            this.lastname = lastname;
            this.document = document;
            this.birthday = birthday;
            this.gender = gender;
            this.email = email;
        }

        public string getSocio()
        {
            return document;
        }

        public override string ToString()
        {
            return "Nombre: " + name + " Apellido: " + lastname;
        }
    }
}
