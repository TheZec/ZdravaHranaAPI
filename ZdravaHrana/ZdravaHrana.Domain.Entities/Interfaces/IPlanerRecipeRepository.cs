﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZdravaHrana.Domain.Entities.Interfaces
{
   public interface IPlanerRecipeRepository
    {
        List<PlanerRecipe> getAllPlanerRecipe();
    }
}
