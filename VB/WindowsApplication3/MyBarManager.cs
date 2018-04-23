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
    public class MyBarManager : BarManager
    {
        public MyBarManager(IContainer cont) : base(cont) { }

        public delegate void ArrowClickEventHandler(object sender, ArrowClickEventArgs e);
        public event ArrowClickEventHandler ArrowItemClick;

        protected virtual void UpdateBarItemInfo()
        {
            foreach (BarManagerPaintStyle ps in GetController().PaintStyles)
            {
                if (ps is SkinBarManagerPaintStyle)
                {
                    foreach (BarItemInfo info in ps.ItemInfoCollection)
                    {
                        if (info.Name == "BarButtonItem")
                        {
                            ps.ItemInfoCollection.Remove(info);
                            ps.ItemInfoCollection.Add(new BarItemInfo("BarButtonItem", "Button", 0, typeof(BarButtonItem), typeof(MyBarButtonItemLink), typeof(BarButtonLinkViewInfo), new BarButtonLinkPainter(ps), true, true));
                            return;
                        }
                    }
                }
            }
        }
        protected override void OnLoaded()
        {
            base.OnLoaded();
            UpdateBarItemInfo();
        }

        internal void RaiseArrowItemClick(ArrowClickEventArgs e)
        {
            if (ArrowItemClick != null)
                ArrowItemClick(this, e);
        }
    }
}
