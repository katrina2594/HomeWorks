using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace Task_RevitAPI_8.Services
{
    public class SelectionService
    {
        private readonly ExternalCommandData _commandData;
        public SelectionService(ExternalCommandData commandData)
        {
            _commandData = commandData;
        }
        public Wall PickWall()
        {
            try
            {
                Reference reference = _commandData.Application.ActiveUIDocument.Selection.PickObject(ObjectType.Element, new WallFilter());
                return _commandData.Application.ActiveUIDocument.Document.GetElement(reference) as Wall;
            }
            catch 
            {
                return null;
            }


        }
    }
}
