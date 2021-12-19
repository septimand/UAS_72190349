using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public interface IEnrollService
    {
        Task<IEnumerable<Enrollment>> GetById(int id);
    }
}