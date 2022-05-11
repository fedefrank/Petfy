﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfy.Domain.Repositories
{
    public interface IPetRepository
    {
        public List<Pet> GetAllPets();
        void AddPet(Pet pet);
    }
}
