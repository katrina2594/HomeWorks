using System;
using System.Globalization;
using System.Windows.Data;
using Task_Revit_API_10.Models;

namespace Task_Revit_API_10.ViewModels
{
    internal class PlantTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is PlantType type)
            {
                switch (type)
                {
                    case PlantType.Tree:
                        return "Дерево";
                    case PlantType.Bush:
                        return "Куст";
                    default:
                        return value != null ? value.ToString() : string.Empty;
                }
            }

            return value != null ? value.ToString() : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string str)
            {
                switch (str)
                {
                    case "Дерево":
                        return PlantType.Tree;
                    case "Куст":
                        return PlantType.Bush;
                    default:
                        throw new ArgumentException(string.Format("Неизвестный тип мебели: {0}", str));
                }
            }

            throw new ArgumentException("Некорректное значение для конвертации");
        }
    }
}
