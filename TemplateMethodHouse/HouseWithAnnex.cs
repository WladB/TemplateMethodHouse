using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodHouse
{
    public class HouseWithAnnex : AbstractHouse
    {
        protected override void RequiredBuildFrontWall()
        {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("FrontWallWithWindows"), 250, 190, 250, 190);
        }
        protected override void HookBuildAnnex() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Annex"), 250, 190, 250, 190);
        }
    }
}
