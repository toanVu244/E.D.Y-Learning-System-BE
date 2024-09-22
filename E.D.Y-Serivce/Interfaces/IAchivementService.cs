﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace E.D.Y_Serivce.Interfaces
{
    public interface IAchivementService
    {
        public Task<List<Achivement>> GetAllAchivementAsync();
        public Task<Achivement> GetAchivementByIdAsync(int id);
        public Task<bool> CreateAchivementAsync(Achivement Achivement);
        public Task<bool> UpdateAchivementAsync(Achivement Achivement);
        public Task<bool> DeleteAchivementAsync(int id);
    }
}
