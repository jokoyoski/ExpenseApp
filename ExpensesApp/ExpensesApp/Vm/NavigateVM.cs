using ExpensesApp.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesApp.Vm
{
  public   class NavigateVM
    {
        public ExpensesAdd expensesAdd { get; set; }
      
        public NavigateVM()
        {
            expensesAdd = new ExpensesAdd(this);
           

        }
    }
}
