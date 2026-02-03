using Autodesk.Revit.DB;

namespace Task_RevitAPI_9.Abstractions
{
    public interface ISelectionService
    {
        FamilyInstance PickFamilyInstance();
    }
}
