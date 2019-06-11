﻿using AspNetCoreApi.Dal.Entities;
using System.Collections.Generic;

namespace AspNetCoreApi.Dal.Core.Contracts
{
    public interface IGeneralDataRepository
    {
        IEnumerable<Countries> GetCountries();
    }
}
