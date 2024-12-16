using Pz_19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz_19.Service
{
    interface IRequestRepository
    {
        Task<List<Request>> GetRequestsAsync();
        Task<Request> GetRequestByIdAsync(int requestId);
        Task<Request> UpdateRequestAsync(Request request);
        Task DeleteRequestAsync(int requestId);
        Task<Request> AddRequestAsync(Request request);
    }
}
