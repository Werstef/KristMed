﻿using KristMedv2.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KristMedv2.ApplicationLogic.Abstractions
{
    public interface IAdminRepository: IRepository<Admin>
    {
        public Admin GetAdminByUserId(Guid userId);
    }
}
