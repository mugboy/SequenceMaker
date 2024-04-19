using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SequenceMaker;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        int n0 = int.Parse(txt_n0.Text);
        int A = int.Parse(txt_A.Text);
        int B = int.Parse(txt_B.Text);

        List<int> n = [n0];

        foreach (int i in Enumerable.Range(1, 10))
        {
            n.Add(A * n[i - 1] + B);
        }
        
        resultTextBlock.Text = string.Join(", ", n);
    }
}