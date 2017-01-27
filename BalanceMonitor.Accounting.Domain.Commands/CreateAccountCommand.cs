﻿using BalanceMonitor.Accounting.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BalanceMonitor.Accounting.Domain.Commands
{
  public class CreateAccountCommand : WindowsIdentityCommand
  {
    public CreateAccountCommand(Guid id, string name, IEnumerable<Money> openingBalance)
    {
      this.Identifier = id;
      this.Name = name;
      this.Created = DateTime.Now;
      this.OpeningBalance = openingBalance.ToList();
    }

    public CreateAccountCommand(Guid id, string name)
      : this(id, name, new List<Money>())
    { }

    public Guid Identifier { get; private set; }

    public string Name { get; private set; }

    public DateTime Created { get; private set; }

    public IEnumerable<Money> OpeningBalance { get; set; }
  }
}
