﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public interface IOptionRepository : IRepository<Option>
    {
        Task<bool> IsExistsAsync(int optionId);
    }
}
