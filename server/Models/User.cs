using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace server.Models
{
    public class User
    {
          public int Id { get; set; }
          public string Username { get; set; }
          public string PasswordHash { get; set; }
    }
}