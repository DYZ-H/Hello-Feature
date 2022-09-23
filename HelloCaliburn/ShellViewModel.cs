using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using System.Runtime.InteropServices;

namespace HelloCaliburn
{
    class ShellViewModel:Screen
    {
        [ImportingConstructor]
        public ShellViewModel(IWindowManager vm)
       {
            Mywm = vm;
            MessageBox.Show("123456");
        }
        
        readonly IWindowManager Mywm; 
        private int _a;
        private int _b;
        private int _c;
        public int A
        {
            get { return _a; }
            set { _a = value; }
        }
        public int B
        {
            get { return  _b; }
            set { _b = value; }
        }
        public int C
        {
            get { return _c; }
            set { _c = value; NotifyOfPropertyChange();NotifyOfPropertyChange(() => CanShow); }
        }
        public void Add()
            
        {
            //MessageBox.Show("123");
            C=A+B;
        }
        testSonView s = new testSonView();
        public void Show()
        {
           
        }
        public bool CanShow
        {
            get { return _c < 100; }
        }

        public void add1(int d)
        {
            C = add(100,100);
        }
        [DllImport("AccHatDll.dll",CallingConvention =CallingConvention.Cdecl)]
        private extern static int add(int a, int b);
    }
}
