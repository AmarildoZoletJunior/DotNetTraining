﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
    public class User : BaseEntidade
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
