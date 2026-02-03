using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
namespace Task_RevitAPI_9.Services
{
    internal class FamilyInstanceSelectionFilter : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            return elem is FamilyInstance;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return false;
        }
    }
}
