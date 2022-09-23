using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace HelloCaliburn.ViewModels
{
    class FeatureViewModel
    {
        public FeatureViewModel(string title, string description, Type viewModel)
        {
            ViewModel = viewModel;
            Title = title;
            Description = description;
            MessageBox.Show("新建Feature");
        }

        public string Title { get; }

        public string Description { get; }

        public Type ViewModel { get; }
    }
}
