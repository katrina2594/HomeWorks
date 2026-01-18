using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Task_RevitAPI_8.Models;

namespace Task_RevitAPI_8.Services
{
    public class GeometryService
    {
        private readonly ExternalCommandData _commandData;
        public GeometryService(ExternalCommandData commandData)
        {
            _commandData = commandData;
        }
        public WallInfo GetWallInfo(Wall wall, double limit)
        {
            ElementId id = wall.GetTypeId();
            WallType walltype = _commandData.Application.ActiveUIDocument.Document.GetElement(id) as WallType;

            double currentThickness = GetDoubleParameter(walltype, BuiltInParameter.WALL_ATTR_WIDTH_PARAM, DisplayUnitType.DUT_MILLIMETERS);
            return new WallInfo()
            {
                Name = wall.get_Parameter(BuiltInParameter.ELEM_FAMILY_PARAM).AsValueString(),
                Type = walltype.Name,
                Length = GetDoubleParameter(wall, BuiltInParameter.CURVE_ELEM_LENGTH, DisplayUnitType.DUT_MILLIMETERS),
                Height = GetDoubleParameter(wall, BuiltInParameter.WALL_USER_HEIGHT_PARAM, DisplayUnitType.DUT_MILLIMETERS),
                Thickness = currentThickness,
                Volume = GetDoubleParameter(wall, BuiltInParameter.HOST_VOLUME_COMPUTED, DisplayUnitType.DUT_CUBIC_METERS),
                Area = GetDoubleParameter(wall, BuiltInParameter.HOST_AREA_COMPUTED, DisplayUnitType.DUT_SQUARE_METERS),
                IsCorrect = currentThickness <= limit
            };
        }

        private double GetDoubleParameter(Element e, BuiltInParameter p, DisplayUnitType d)
        {
            Parameter parameter = e.get_Parameter(p);
            return Math.Round(UnitUtils.ConvertFromInternalUnits(parameter.AsDouble(), d), 2);
        }
    }
}
