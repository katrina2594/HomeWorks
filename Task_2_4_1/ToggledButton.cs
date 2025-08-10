using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task_2_4_1
{
    class ToggledButton : Button
    {
        public static readonly DependencyProperty IsToggledProperty
            = DependencyProperty.Register(
                nameof(IsToggled),
                typeof(bool),
                typeof(ToggledButton),
                new FrameworkPropertyMetadata(
                false,
                FrameworkPropertyMetadataOptions.None,
                OnClickToggleChanged));

        public bool IsToggled
        {
            get { return (bool)GetValue(IsToggledProperty); }
            set { SetValue(IsToggledProperty, value); }
        }
        private static void OnClickToggleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (ToggledButton)d;
            button?.UpdateButton();
            
        }
        public ToggledButton()
        {
            Content = "OFF";
            Background = new SolidColorBrush(Colors.Red);
            Click += (sender, e) => IsToggled = !IsToggled;
        }
        private void UpdateButton()
        {
            if(IsToggled)
            {
                Content = "ON";
                Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                Content = "OFF";
                Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
