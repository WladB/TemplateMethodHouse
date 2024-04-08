using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodHouse
{
   public class SimpleHouse : AbstractHouse
    {
        protected override void RequiredBuildFrontWall()
        {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("FrontWall"), 250, 190, 250, 190);
        }
    }
}
