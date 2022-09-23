using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using System.Windows.Controls;


namespace HelloCaliburn.ViewModels
{
    class FrameViewModel:Screen
    {
        private readonly SimpleContainer container;
        private INavigationService navigationService;

        public FrameViewModel(SimpleContainer container)
        {
            this.container = container;
            //System.Windows.MessageBox.Show("开始注册");
        }

        public void RegisterFrame(Frame frame)
        {
            navigationService = new FrameAdapter(frame);

            container.Instance(navigationService);

            navigationService.NavigateToViewModel(typeof(MenuViewModel));
        }
    }
}
