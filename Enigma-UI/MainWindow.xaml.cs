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

        private bool shiftKeyPressed = false;
        private bool uppercaseEnabled = false;
        private bool capsLockEnabled = false;
        private bool capsLockKeyPressed = false;


        private void InitializeEventHandlers()
        {            
            KeyDown += Window_KeyDown;
            KeyUp += Window_KeyUp;
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle the Shift key
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                shiftKeyPressed = true;
                uppercaseEnabled = true; // Enable uppercase mode when Shift is pressed
                shift.Background = Brushes.Yellow;
                return;
            }

            if (e.Key == Key.CapsLock)
            {
                capsLockKeyPressed = true;
                capsLockEnabled = !capsLockEnabled;
                // Update your Shift Lock label text or appearance here
                shiftlock.Content = capsLockEnabled ? "Caps Lock" : "Shift Lock";
                shiftlock.Background = Brushes.Yellow;
                return;
            }

            if (uppercaseEnabled)
            {
                char character = KeyManager(e.Key);
                character = char.ToUpper(character);
                // Append the uppercase character to your output or handle it as needed.
            }

            else 
            { 
            // Change the background color of the Label when a key is pressed.
            switch (e.Key)
                {
                    case Key.A:
                        a.Background = Brushes.Yellow;
                        break;
                    case Key.B:
                        b.Background = Brushes.Yellow;
                        break;
                    case Key.C:
                        cc.Background = Brushes.Yellow;
                        break;
                    case Key.D:
                        d.Background = Brushes.Yellow;
                        break;
                    case Key.E:
                        ee.Background = Brushes.Yellow;
                        break;
                    case Key.F:
                        f.Background = Brushes.Yellow;
                        break;
                    case Key.G:
                        g.Background = Brushes.Yellow;
                        break;
                    case Key.H:
                        h.Background = Brushes.Yellow;
                        break;
                    case Key.I:
                        i.Background = Brushes.Yellow;
                        break;
                    case Key.J:
                        j.Background = Brushes.Yellow;
                        break;
                    case Key.K:
                        k.Background = Brushes.Yellow;
                        break;
                    case Key.L:
                        el.Background = Brushes.Yellow;
                        break;
                    case Key.M:
                        m.Background = Brushes.Yellow;
                        break;
                    case Key.N:
                        n.Background = Brushes.Yellow;
                        break;
                    case Key.O:
                        o.Background = Brushes.Yellow;
                        break;
                    case Key.P:
                        p.Background = Brushes.Yellow;
                        break;
                    case Key.Q:
                        q.Background = Brushes.Yellow;
                        break;
                    case Key.R:
                        r.Background = Brushes.Yellow;
                        break;
                    case Key.S:
                        s.Background = Brushes.Yellow;
                        break;
                    case Key.T:
                        t.Background = Brushes.Yellow;
                        break;
                    case Key.U:
                        u.Background = Brushes.Yellow;
                        break;
                    case Key.V:
                        v.Background = Brushes.Yellow;
                        break;
                    case Key.W:
                        w.Background = Brushes.Yellow;
                        break;
                    case Key.X:
                        x.Background = Brushes.Yellow;
                        break;
                    case Key.Y:
                        y.Background = Brushes.Yellow;
                        break;
                    case Key.Z:
                        z.Background = Brushes.Yellow;
                        break;
                        // OTHER KEYPAD
                    case Key.Space:
                        spacebar.Background = Brushes.Yellow;
                        break;


                    case Key.Back:
                        _return.Background = Brushes.Yellow;
                        break;
                }
            }
        }

        private char KeyManager(Key input)
        {
            char retVal = ' ';

            if (input == Key.Space)
                retVal = ' ';
            else if (capsLockEnabled || (shiftKeyPressed && !capsLockKeyPressed)) // Check if Caps Lock is enabled or Shift is pressed (but not Caps Lock)
                retVal = char.ToUpper(input.ToString()[0]); // Convert to uppercase
            else
                retVal = char.ToLower(input.ToString()[0]); // Convert to lowercase

            return retVal;
        }




        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                shiftKeyPressed = false;
                uppercaseEnabled = false; // Disable uppercase mode when Shift is released
                shift.Background = Brushes.Transparent;
                return;
            }

            if (e.Key == Key.CapsLock)
            {
                capsLockKeyPressed = false;
                shiftlock.Background = Brushes.Transparent;
                return;
            }

            if (e.Key == Key.Back)
            {
                if (!string.IsNullOrEmpty(output.Content.ToString()))
                {
                    output.Content = output.Content.ToString().Substring(0, output.Content.ToString().Length - 1);
                    _return.Background = Brushes.Transparent;
                }
            }
            else
            {
                if (initialState)
                {
                    initialState = false;
                    output.Content = KeyManager(e.Key);
                }
                else
                    output.Content += KeyManager(e.Key) + "";
            }

            // Revert the background color when the key is released.
            switch (e.Key)
            {              
                case Key.A:
                    a.Background = Brushes.Transparent;
                    break;
                case Key.B:
                    b.Background = Brushes.Transparent;
                    break;
                case Key.C:
                    cc.Background = Brushes.Transparent;
                    break;
                case Key.D:
                    d.Background = Brushes.Transparent;
                    break;
                case Key.E:
                    ee.Background = Brushes.Transparent;
                    break;
                case Key.F:
                    f.Background = Brushes.Transparent;
                    break;
                case Key.G:
                    g.Background = Brushes.Transparent;
                    break;
                case Key.H:
                    h.Background = Brushes.Transparent;
                    break;
                case Key.I:
                    i.Background = Brushes.Transparent;
                    break;
                case Key.J:
                    j.Background = Brushes.Transparent;
                    break;
                case Key.K:
                    k.Background = Brushes.Transparent;
                    break;
                case Key.L:
                    el.Background = Brushes.Transparent;
                    break;
                case Key.M:
                    m.Background = Brushes.Transparent;
                    break;
                case Key.N:
                    n.Background = Brushes.Transparent;
                    break;
                case Key.O:
                    o.Background = Brushes.Transparent;
                    break;
                case Key.P:
                    p.Background = Brushes.Transparent;
                    break;
                case Key.Q:
                    q.Background = Brushes.Transparent;
                    break;
                case Key.R:
                    r.Background = Brushes.Transparent;
                    break;
                case Key.S:
                    s.Background = Brushes.Transparent;
                    break;
                case Key.T:
                    t.Background = Brushes.Transparent;
                    break;
                case Key.U:
                    u.Background = Brushes.Transparent;
                    break;
                case Key.V:
                    v.Background = Brushes.Transparent;
                    break;
                case Key.W:
                    w.Background = Brushes.Transparent;
                    break;
                case Key.X:
                    x.Background = Brushes.Transparent;
                    break;
                case Key.Y:
                    y.Background = Brushes.Transparent;
                    break;
                case Key.Z:
                    z.Background = Brushes.Transparent;
                    break;
                    // OTHER KEYPAD
                case Key.Space:
                    spacebar.Background = Brushes.Transparent;
                    break;
            }
        }
    }
}

