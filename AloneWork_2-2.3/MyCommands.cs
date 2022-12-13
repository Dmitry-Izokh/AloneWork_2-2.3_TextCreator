using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AloneWork_2_2._3
{
    class MyCommands
    {
        public static RoutedCommand Exit{get; set;}
        public static RoutedCommand SaveAS { get; set; }

        static MyCommands()
            {
                InputGestureCollection input = new InputGestureCollection();
                input.Add(new KeyGesture(Key.Q, ModifierKeys.Control, "Ctrl+Q"));
                Exit = new RoutedCommand("Выход", typeof(MyCommands), input);

                InputGestureCollection input_1 = new InputGestureCollection();
                input_1.Add(new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S"));
                SaveAS = new RoutedCommand("Сохранить как", typeof(MyCommands), input_1);
            }

        
        
    }
}
