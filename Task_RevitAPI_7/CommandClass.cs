using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace Task_RevitAPI_7
{
    [Transaction(TransactionMode.Manual)]
    public class CommandClass : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            try
            {
                var reference = uidoc.Selection.PickObject(ObjectType.Element, new Filter(), "Выберите системное семейство");
                var elem = doc.GetElement(reference);
                Options opt = new Options();
                var solids = elem.get_Geometry(opt)
                    .Where(e => e is Solid)
                    .OfType<Solid>()
                    .Where(s => s.Volume > 0.0001)
                    .ToList();
                var sumVolume = UnitUtils.ConvertFromInternalUnits(solids.Sum(s => s.Volume), DisplayUnitType.DUT_CUBIC_METERS);
                var sumSurfaceArea = UnitUtils.ConvertFromInternalUnits(solids.Sum(s => s.SurfaceArea), DisplayUnitType.DUT_SQUARE_METERS);
                int facesCount = solids.Sum(s => s.Faces.Size);
                int sumEdges = solids.Sum(s => s.Edges.Size);
                double sumEdgesLength = 0;
                foreach (Solid s in solids)
                {
                    foreach (Edge edge in s.Edges)
                    {
                        Curve curve = edge.AsCurve();
                        double length = curve.Length;
                        sumEdgesLength += length;
                    }
                }
                sumEdgesLength = UnitUtils.ConvertFromInternalUnits(sumEdgesLength, DisplayUnitType.DUT_MILLIMETERS);
                TaskDialog.Show("Статистика", $"Суммарный объем всех Solid-ов: {sumVolume:F2} м3" +
                    $"\nСуммарная площадь поверхностей всех Solid-ов: {sumSurfaceArea:F2} м2" +
                    $"\nКоличество граней: {facesCount} штук" +
                    $"\nКоличество ребер: {sumEdges} штук" +
                    $"\nСуммарная длина ребер {sumEdgesLength:F2} мм");
            }
            catch
            {
                TaskDialog.Show("Ошибка", "Не выбран ни один элемент");
            }
            return Result.Succeeded;
             
        }
    }
}
