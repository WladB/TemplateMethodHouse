using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodHouse
{
    class HouseModified : AbstractHouse
    {

        protected override void RequiredBuildFrontWall()
        {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("FrontWallWithWindows"), 250, 190, 250, 190);
        }
        protected override void HookBuildOneDoor() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("OneDoor"), 250, 190, 250, 190);
        }
    }
}
