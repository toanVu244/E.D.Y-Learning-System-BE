﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.D.Y_Repository.Interfaces
{
 public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User> getUserbyEmailAndPass(string email, string pass);

        public Task<User> getLastUser();
    }
}
