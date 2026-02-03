using Autodesk.Revit.DB;


namespace Task_RevitAPI_9.Abstractions
{
    public interface ISectionService
    {
        bool CreateSection(FamilyInstance familyInstance, double widthOffsetMm, double depthOffsetMm, double heightOffsetMm, string sectionName);
    }
}
