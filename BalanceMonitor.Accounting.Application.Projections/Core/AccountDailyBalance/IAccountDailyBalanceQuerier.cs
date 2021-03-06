﻿using System;
using System.Collections.Generic;

namespace BalanceMonitor.Accounting.Application.Projections
{
  public interface IAccountDailyBalanceQuerier
  {
    IEnumerable<AccountDailyBalance> GetAccountBalanceOn(DateTime date);

    IEnumerable<AccountDailyBalance> GetAccountBalanceOn(Guid accId, DateTime date);
  }
}
