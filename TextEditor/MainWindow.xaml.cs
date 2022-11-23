using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

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
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() != null)
                {

                    StreamReader sr = new StreamReader(ofd.OpenFile());
                    FlowDocument fd = new FlowDocument();
                    string line;
                    if (sr != null)
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            fd.Blocks.Add(new Paragraph(new Run(line)));
                        }
                        rtb_editor.Document = fd;
                        sr.Close();
                    }
                }
            }
            catch
            {

            }
        }


        private void main_mi_save_Click(object sender, RoutedEventArgs e)
        {
            /*StreamWriter sw = new StreamWriter("document.txt", false, Encoding.UTF8);
            foreach (Paragraph block in rtb_editor.Document.Blocks)
            {
                foreach (Run r in block.Inlines)
                {
                    if (r.Text);
                }
            }
            sw.Close();*/
        }

        private void main_mi_saveAs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
