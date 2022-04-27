﻿using EmployeeLeaveTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeLeaveTracker.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<LeaveType> LeaveTypes { get; }
        IGenericRepository<LeaveRequest> LeaveRequests { get;  }
        IGenericRepository<LeaveAllocation> LeaveAllocations { get; }
        Task Save();
    }
}
