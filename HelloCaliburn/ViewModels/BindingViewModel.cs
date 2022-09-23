using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using System.Windows;

namespace HelloCaliburn.ViewModels
{
    class BindingViewModel:Screen
    {
        //private ActivityBaseViewModel selectedActivity;

        public BindingViewModel()
        {
            //Activities = new BindableCollection<ActivityBaseViewModel>
            //{
            //    new MessageActivityViewModel(Lipsum.Get()),
            //    new PhotoActivityViewModel(Lipsum.Get()),
            //    new MessageActivityViewModel(Lipsum.Get()),
            //    new PhotoActivityViewModel(Lipsum.Get())
            //};

            MessageBox.Show("123");
        }

        //public BindableCollection<ActivityBaseViewModel> Activities { get; }

        //public ActivityBaseViewModel SelectedActivity
        //{
        //    get { return selectedActivity; }
        //    set { Set(ref selectedActivity, value); }
        //}
    }
}

