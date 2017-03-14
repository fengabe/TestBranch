using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace RevitTest
{
    class RevitTest
    {
        public void TestLevel()
        {

            Level level= new Level();
            level.get_Parameter(BuiltInParameter.LEVEL_IS_BUILDING_STORY);

            Element element = new Element();
            element.Name;
            element.Id;
            element.LevelId;
            level.Name;
            level.Elevation
        }
    }
}
