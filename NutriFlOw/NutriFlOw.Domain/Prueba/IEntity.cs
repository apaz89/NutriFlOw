﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFlOw.Domain.Prueba
{
    public interface IEntity
    {
        long Id { get; set; }

        bool IsArchived { get; set; }
    }
}
