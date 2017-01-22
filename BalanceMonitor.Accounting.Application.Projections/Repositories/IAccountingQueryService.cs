﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceMonitor.Accounting.Application.Projections.Repositories
{
  public interface IAccountingQueryService : IAccountAuditRepository, IAccountDailyBalanceRepository
  {

  }
}