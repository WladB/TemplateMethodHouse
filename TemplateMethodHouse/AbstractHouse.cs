using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodHouse
{
  public abstract class AbstractHouse
    {
        public static Graphics g;
        public void TemplateMethod()
        {
            this.BuildSideWallB();
            this.RequiredBuildFrontWall();
            this.BuildRoofB();
            this.HookBuildAnnex();
            this.HookBuildTwoDoor();
            this.HookBuildOneDoor();
        }

        protected void BuildSideWallB()
        {
            g.Clear(Color.WhiteSmoke);
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Side wall"), 250, 190, 250, 190);
        }

        protected void BuildRoofB()
        {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Roof"), 250, 190, 250, 190);
        }

        protected abstract void RequiredBuildFrontWall();

        protected virtual void HookBuildAnnex() { }
        protected virtual void HookBuildOneDoor() { }
        protected virtual void HookBuildTwoDoor() { }
    }
}
