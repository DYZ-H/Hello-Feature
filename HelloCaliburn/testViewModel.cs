using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Runtime.InteropServices;
using System.ComponentModel.Composition;
using HelloCaliburn;

namespace HelloCaliburn
{
    class testViewModel:Conductor<object>.Collection.OneActive
    {
        
        private readonly IWindowManager _WindowManager ;
        private int _d=3;
        object aa;
        object aa1;
        public int D
        {
            get { return _d; }
            set { _d = value; NotifyOfPropertyChange(); }
        }
        [ImportingConstructor]
        public testViewModel(IWindowManager wm)
        {
            _WindowManager = wm;
        }
        public void Show()
        {
         aa =  ActivateItemAsync(new testSonViewModel());
        }
        public void ac()
        {
            ActivateItemAsync(IoC.Get<testSonViewModel>());
        }
        public void Show2()
        {
            aa1 = ActivateItemAsync(new ViewModels.AViewModel());
        }
        public void Close()
        {
            DeactivateItemAsync(ActiveItem, true);
           // DeactivateItemAsync(aa1, true);
        }
        
        public void Open()
        {
            _WindowManager.ShowWindowAsync( IoC.GetInstance(typeof(ViewModels.PeopleViewModel),null), "test1", null);
        }
    }
}
