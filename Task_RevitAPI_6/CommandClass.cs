using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Microsoft.SqlServer.Server;

namespace Task_RevitAPI_6
{
    [Transaction(TransactionMode.Manual)]
    public class CommandClass : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Application app = uiapp.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            try
            {
                IList<Reference> pickedRefs = uidoc.Selection.PickObjects(ObjectType.Element, "Выберите 2 стены");
                if (pickedRefs.Count == 2)
                {
                    Wall wall1 = doc.GetElement(pickedRefs.First()) as Wall;
                    Wall wall2 = doc.GetElement(pickedRefs.Last()) as Wall;
                    if (wall1 != null && wall2 != null)
                    {
                        XYZ vector1 = GetNormalWall(wall1);
                        XYZ vector2 = GetNormalWall(wall2);
                        if (IsParallel(vector1, vector2))
                        {
                            XYZ mid1 = GetMidPoint(wall1);
                            XYZ mid2 = GetMidPoint(wall2);
                            XYZ vectorBetween = mid2 - mid1;
                            double distance = vectorBetween.DotProduct(vector1);
                            double distanceMM = UnitUtils.ConvertFromInternalUnits(distance, DisplayUnitType.DUT_MILLIMETERS);
                            TaskDialog.Show("Результат", $"Расстояние между стенами: {distanceMM:F2} мм");
                        }
                        else
                        {
                            TaskDialog.Show("Ошибка", "Выбранные стены не параллельны.Вычисление невозможно");
                        }
                    }
                    else
                    {
                        TaskDialog.Show("Ошибка", "Выберите именно стены");
                    }

                }
                else
                {
                    TaskDialog.Show("Ошибка", "Элементов должно быть 2шт");
                }
            }
            catch
            {
                TaskDialog.Show("Ошибка", "Не выбрано ни одной стены");
            }
            return Result.Succeeded;
        }
        public XYZ GetNormalWall(Wall wall) 
        { 
            LocationCurve location = wall.Location as LocationCurve;
            Curve curve = location.Curve;
            XYZ wallDirection = (curve.GetEndPoint(1) - curve.GetEndPoint(0)).Normalize();
            XYZ up = XYZ.BasisZ;
            return wallDirection.CrossProduct(up).Normalize();
        }
        public bool IsParallel(XYZ a,XYZ b,double tolerance = 0.001)
        {
            return Math.Abs(Math.Abs(a.DotProduct(b)) - 1) < tolerance;
        }
        public XYZ GetMidPoint(Wall wall)
        {
            LocationCurve location = wall.Location as LocationCurve;
            Curve curve = location.Curve;
            return (curve.GetEndPoint(0) + curve.GetEndPoint(1)) / 2;
        }
    }
}
