﻿using ELibraryProject.ViewModels;
using ELibraryProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ELibraryProject.Commands.HomePageCommands
{
    public class ShowUsersCommand : ICommand
    {
        public MainWindowViewModel MainWindowViewModel { get; set; }

        public ShowUsersCommand(MainWindowViewModel MainWindowViewModel)
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
            MainWindowViewModel.Grid.Children.Add(new UserView());
        }
    }
}
