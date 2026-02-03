using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_RevitAPI_9.Abstractions;

namespace Task_RevitAPI_9.Services
{
    internal class SelectionService: ISelectionService
    {
        private readonly ExternalCommandData _commandData;
        public SelectionService(ExternalCommandData commandData)
        {
            _commandData = commandData;
        }
        public FamilyInstance PickFamilyInstance()
        {
            try
            {
                Reference reference = _commandData.Application.ActiveUIDocument.Selection.PickObject(ObjectType.Element, new 
                    FamilyInstanceSelectionFilter());
                return _commandData.Application.ActiveUIDocument.Document.GetElement(reference) as FamilyInstance;
            }
            catch
            {
                return null;
            }


        }
    }
}
