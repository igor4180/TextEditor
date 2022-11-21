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

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void main_mi_create_Click(object sender, RoutedEventArgs e)
        {
            rtb_editor.Document.Blocks.Clear();
            //TextRange textRange = new TextRange(paragraph.ContentStart, paragraph.ContentEnd);
            Paragraph paragraph = new Paragraph(new Run("я новый документ"));
            rtb_editor.Document.Blocks.Add(paragraph);
            
        }
        private void main_mi_open_Click(object sender, RoutedEventArgs e)
        {

        }


        private void main_mi_save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void main_mi_saveAs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
