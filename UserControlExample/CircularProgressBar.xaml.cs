using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControlExample
{
    /// <summary>
    /// Логика взаимодействия для CircularProgressBar.xaml
    /// </summary>
    public partial class CircularProgressBar : UserControl
    {
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof(Value),
                typeof(double),
                typeof(CircularProgressBar),
                new PropertyMetadata(0.0, OnValueChanged));

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(
                nameof(Maximum),
                typeof(double),
                typeof(CircularProgressBar),
                new PropertyMetadata(100.0, OnValueChanged));

        public static readonly DependencyProperty IsLargeArcProperty =
            DependencyProperty.Register(
                nameof(IsLargeArc),
                typeof(bool),
                typeof(CircularProgressBar),
                new PropertyMetadata(false, OnValueChanged));

        // Read-only Dependency Properties
        private static readonly DependencyPropertyKey ProgressPointPropertyKey =
            DependencyProperty.RegisterReadOnly(
                nameof(ProgressPoint),
                typeof(Point),
                typeof(CircularProgressBar),
                new PropertyMetadata(new Point(50, 95)));

        public static readonly DependencyProperty ProgressPointProperty = ProgressPointPropertyKey.DependencyProperty;

        private static readonly DependencyPropertyKey PercentageTextPropertyKey =
            DependencyProperty.RegisterReadOnly(
                nameof(PercentageText),
                typeof(string),
                typeof(CircularProgressBar),
                new PropertyMetadata("0%"));

        public static readonly DependencyProperty PercentageTextProperty = PercentageTextPropertyKey.DependencyProperty;

        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public double Maximum
        {
            get => (double)GetValue(MaximumProperty);
            set => SetValue(MaximumProperty, value);
        }

        public bool IsLargeArc
        {
            get => (bool)GetValue(IsLargeArcProperty);
            set => SetValue(IsLargeArcProperty, value);
        }

        public Point ProgressPoint
        {
            get => (Point)GetValue(ProgressPointProperty);
            private set => SetValue(ProgressPointPropertyKey, value);
        }

        public string PercentageText
        {
            get => (string)GetValue(PercentageTextProperty);
            private set => SetValue(PercentageTextPropertyKey, value);
        }

        public CircularProgressBar()
        {
            InitializeComponent();
            UpdateProgress();
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var progressBar = (CircularProgressBar)d;
            progressBar.UpdateProgress();
        }

        private void UpdateProgress()
        {
            // Ограничиваем значения
            if (Value < 0) Value = 0;
            if (Value > Maximum) Value = Maximum;
            if (Maximum <= 0) Maximum = 100;

            // Вычисляем прогресс
            double angle = 90 + Value * 360 / 100;
            double radians = angle * Math.PI / 180.0;
            double centerX = 50;
            double centerY = 50;
            double radius = 45;
            double x = centerX + radius * Math.Cos(radians);
            double y = centerY + radius * Math.Sin(radians);
            
            if(Value == Maximum)
                ProgressPoint = new Point(x+1, y);
            else
                ProgressPoint = new Point(x, y);
            if (Value > 50)
                IsLargeArc = true;
            else
                IsLargeArc = false;
            double percentage = Maximum == 0 ? 0 : (Value / Maximum);
            PercentageText = $"{(percentage * 100):F0}%";
        }
    }
}

