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

namespace Enigma_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool initialState = true;
        string defaultMessage = "Your Message will appear here";
        public MainWindow()
        {
            InitializeComponent();
            InitializeEventHandlers();
            if (initialState)
                output.Content = defaultMessage;

        }

        private void InitializeEventHandlers()
        {
            // Attach key down and key up event handlers to the window.
            KeyDown += Window_KeyDown;
            KeyUp += Window_KeyUp;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Change the background color of the Label when a key is pressed.
          if (e.Key == Key.A) 
            {
                a.Background = Brushes.Yellow;
            }

            else if (e.Key == Key.B)
            {
                b.Background = Brushes.Yellow;
            }
            
            else if (e.Key == Key.C)
            {
                c.Background = Brushes.Yellow;
            }
            
            else if (e.Key == Key.C)
            {
                c.Background = Brushes.Yellow;
            }


        }

        private char KeyManager(Key input)
        {
            char retVal = ' ';

            if (input == Key.Space)
                retVal = ' ';
            else
                retVal = input.ToString()[0];

            return retVal;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {

            if (initialState)
            {
                initialState = false;
                output.Content = KeyManager(e.Key);
            }
            else
                output.Content += KeyManager(e.Key) + "";
            // Revert the background color when the key is released.
            /*
            if (e.Key == Key.A)
            {
                a.Background = Brushes.Transparent;
            }

            else if (e.Key == Key.B)
            {
                b.Background = Brushes.Transparent;
            }

            else if (e.Key == Key.C)
            {
                c.Background = Brushes.Transparent;
            }
            */
        }
    }
}


//using System;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Input;
//using System.Windows.Media;

//namespace WpfKeyHighlight
//{
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();
//            InitializeEventHandlers();
//        }

//        private void InitializeEventHandlers()
//        {
//            // Attach the PreviewKeyDown event handler to the window.
//            PreviewKeyDown += Window_PreviewKeyDown;
//        }

//        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
//        {
//            // Check if the pressed key is a letter or a number.
//            if (Char.IsLetterOrDigit((char)e.Key))
//            {
//                // Change the background color of the Label when a letter or number key is pressed.
//                highlightLabel.Background = Brushes.Yellow; // You can set any color you like.
//            }
//        }
//    }
//}

