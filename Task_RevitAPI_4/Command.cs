using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Task_RevitAPI_4
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
           UIApplication uIApplication= commandData.Application;
            Application application= uIApplication.Application;
            UIDocument uIDocument = uIApplication.ActiveUIDocument;
            Document document = uIDocument.Document;

            var walls = new FilteredElementCollector(document)
                .OfClass(typeof(Wall))
                .OfType<Wall>()
                .ToList();

            var wallsNum = walls.Count;
            if (wallsNum > 0)
            {
                var wallsOrdered = walls.OrderBy(wall => wall.get_Parameter(BuiltInParameter.CURVE_ELEM_LENGTH).AsDouble());
                var minWall = wallsOrdered.First();
                var maxWall = wallsOrdered.Last();
                var minWallLength = UnitUtils.ConvertFromInternalUnits(minWall.get_Parameter(BuiltInParameter.CURVE_ELEM_LENGTH).AsDouble(),DisplayUnitType.DUT_MILLIMETERS);
                var maxWallLength = UnitUtils.ConvertFromInternalUnits(maxWall.get_Parameter(BuiltInParameter.CURVE_ELEM_LENGTH).AsDouble(),DisplayUnitType.DUT_MILLIMETERS);
                var avaregeWallLength = UnitUtils.ConvertFromInternalUnits(walls.Average(wall => wall.get_Parameter(BuiltInParameter.CURVE_ELEM_LENGTH).AsDouble()), DisplayUnitType.DUT_MILLIMETERS);

                TaskDialog.Show("Статистика по стенам", $"Общее количество стен: {wallsNum}" +
                    $"\nСамая длинная стена: {maxWallLength:F2} мм" +
                    $"\nСамая короткая стена: {minWallLength:F2} мм" +
                    $"\nСредняя длина стен: {avaregeWallLength:F2} мм");

                using (Transaction t = new Transaction(document, "Заполнен параметр Комментарий для стен"))
                {
                    t.Start();
                    Parameter parameter1 = minWall.get_Parameter(BuiltInParameter.ALL_MODEL_INSTANCE_COMMENTS);
                    Parameter parameter2 = maxWall.get_Parameter(BuiltInParameter.ALL_MODEL_INSTANCE_COMMENTS);
                    parameter1.Set("Самая короткая стена");
                    parameter2.Set("Самая длинная стена");
                    t.Commit();
                }
            }
            else
            {
                TaskDialog.Show("Ошибка","В модели нет стен");
            }
            return Result.Succeeded;
        }
    }
}
