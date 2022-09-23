using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Windows;
namespace HelloCaliburn
{
    class testSonViewModel:Screen
    {
        private string _s;
        public string S
        {
            get { return _s; }
            set { _s = value; NotifyOfPropertyChange(); }
        }
        public void Settext()
        {
            S = "test";
        }
        protected override Task OnDeactivateAsync(bool close, CancellationToken cancellationToken)
        {
            MessageBox.Show("退出");
            return base.OnDeactivateAsync( close,  cancellationToken);
        }
    }
}
