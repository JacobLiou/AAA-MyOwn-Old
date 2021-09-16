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

namespace WpfMatrixRain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// As described by MSDN, DrawingVisual is a lightweight drawing class that is used to render shapes, 
        /// images, or text. This class is considered lightweight because it does not provide layout, input, focus, 
        /// or event handling, which improves its performance.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
