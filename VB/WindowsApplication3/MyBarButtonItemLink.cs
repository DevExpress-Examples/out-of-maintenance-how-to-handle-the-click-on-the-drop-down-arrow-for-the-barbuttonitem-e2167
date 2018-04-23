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
using System.Diagnostics;

namespace WindowsApplication3
{
    public class MyBarButtonItemLink : BarButtonItemLink
    {
        public MyBarButtonItemLink(BarItemLinkReadOnlyCollection ALinks, BarItem AItem, object ALinkedObject) : base(ALinks, AItem, ALinkedObject) { }
        protected override void OnLinkAction(BarLinkAction action, object actionArgs)
        {
            if (action == BarLinkAction.PressArrow)
            {
                if (CanPressDropDownButton)
                {
                    if (BarControl != null) BarControl.Capture = false;
                    if (IsPopupVisible) HidePopupCore(true);
                    else
                    {
                        ArrowClickEventArgs e = new ArrowClickEventArgs() { Handled = false, Link = this };
                        Manager.RaiseArrowItemClick(e);
                        if(!e.Handled)
                          ShowPopup();
                        Debug.WriteLine("ArrowClick");
                    }
                }
                return;
            }
            base.OnLinkAction(action, actionArgs);
        }

        MyBarManager Manager
        {
            get { return base.Manager as MyBarManager; }
        }
    }
}