﻿using System;
using System.Windows.Input;

namespace Sledilec.Odjemalec.Stroj
{
    public class RelayCommand : ICommand
    {
        private readonly Func<bool> canExecute;
        private readonly Action execute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute) : this(execute, null)
        {
        }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            this.execute = execute;
            if (canExecute != null)
            {
                this.canExecute = new Func<bool>(canExecute);
            }
        }

        public virtual bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            return canExecute();
        }

        public virtual void Execute(object parameter)
        {
            execute();
        }

        public void RaiseCanExecuteChanged()
        {
            EventHandler canExecuteChanged = this.CanExecuteChanged;
            if (canExecuteChanged != null)
            {
                canExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
