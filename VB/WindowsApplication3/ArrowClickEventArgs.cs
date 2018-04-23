using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Styles;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Painters;

namespace WindowsApplication3
{
    public class ArrowClickEventArgs : EventArgs
    {

        public ArrowClickEventArgs() { }


        //// Fields...

        private BarItemLink _Link;
        private bool _Handled;

        public bool Handled
        {
            get { return _Handled; }
            set
            {
                _Handled = value;
            }
        }


        public BarItemLink Link
        {
            get { return _Link; }
            set { _Link = value; }
        }

    }
}
