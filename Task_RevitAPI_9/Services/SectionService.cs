using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Task_RevitAPI_9.Abstractions;

namespace Task_RevitAPI_9.Services
{
    internal class SectionService : ISectionService
    {
        private readonly ExternalCommandData _commandData;

        public SectionService(ExternalCommandData commandData) 
        {
            _commandData = commandData;
        }

        public bool CreateSection(
            FamilyInstance instance,
            double widthOffsetMm,
            double depthOffsetMm,
            double heightOffsetMm,
            string sectionName)
        {
            var doc = _commandData.Application.ActiveUIDocument.Document;
            
            var bbox = instance.get_BoundingBox(null);

            if (bbox == null) 
            {
                return false;
            }
            var center = (bbox.Min + bbox.Max) / 2;
            var size = bbox.Max - bbox.Min;

            Transform transform1 = GetTransform(center, XYZ.BasisZ, XYZ.BasisY);
            Transform transform2 = GetTransform(center, XYZ.BasisZ, XYZ.BasisX);
            Transform transform3 = GetTransform(center, XYZ.BasisY, XYZ.BasisZ);

            var widthOffset = UnitUtils.ConvertToInternalUnits(widthOffsetMm, DisplayUnitType.DUT_MILLIMETERS);
            var depthOffset = UnitUtils.ConvertToInternalUnits(depthOffsetMm, DisplayUnitType.DUT_MILLIMETERS);
            var heightOffset = UnitUtils.ConvertToInternalUnits(heightOffsetMm, DisplayUnitType.DUT_MILLIMETERS);

            var sectionBox1 = GetSectionBox(transform1,size,widthOffset,depthOffset,heightOffset);
            var sectionBox2 = GetSectionBox(transform2, size, widthOffset, depthOffset, heightOffset);
            var sectionBox3 = GetSectionBox(transform3, size, widthOffset, depthOffset, heightOffset);


            var viewType = new FilteredElementCollector(doc)
                .OfClass(typeof(ViewFamilyType))
                .OfType<ViewFamilyType>()
                .FirstOrDefault(x => x.ViewFamily == ViewFamily.Section);
            if(viewType == null)
            {
                return false;
            }

            try
            {

                using (var transaction = new Transaction(doc, "Создание разрезов"))
                {
                    transaction.Start();
                    var viewSection1 = ViewSection.CreateSection(doc, viewType.Id, sectionBox1);
                    viewSection1.Name = sectionName;

                    var viewSection2 = ViewSection.CreateSection(doc, viewType.Id, sectionBox2);
                    viewSection2.Name = sectionName+"(1)";

                    var viewSection3 = ViewSection.CreateSection(doc, viewType.Id, sectionBox3);
                    viewSection3.Name = sectionName + "(2)";

                    transaction.Commit();
                }
            }
            catch (Exception ex) 
            {
                return false;
            }

            return true;
        }
        private Transform GetTransform(XYZ origin, XYZ y, XYZ z)
        {
            Transform transform = Transform.CreateTranslation(XYZ.Zero);
            transform.Origin = origin;
            transform.BasisX = (y.CrossProduct(z)).Normalize();
            transform.BasisY = y;
            transform.BasisZ = z;
            return transform;
        }
        private BoundingBoxXYZ GetSectionBox(Transform transform, XYZ size, double widthOffset, double depthOffset, double heightOffset)
        {
            var sectionBox = new BoundingBoxXYZ();
            sectionBox.Transform = transform;
            sectionBox.Min = new XYZ(-size.X / 2 - widthOffset, -size.Z / 2 - depthOffset, -size.Y / 2 - heightOffset);
            sectionBox.Max = new XYZ(size.X / 2 + widthOffset, size.Z / 2 + depthOffset, size.Y / 2 + heightOffset);
            return sectionBox;
        }
    }
}
