﻿using ELibraryProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.HomePageCommands
{
    public class SalesReportSectionCommand : ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public SalesReportSectionCommand(MainWindowViewModel MainWindowViewModel)
        {
            this.MainWindowViewModel = MainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainWindowViewModel.Grid.Children.Clear();
            //MainWindowViewModel.Grid.Children.Add(ne)
        }
    }
}
