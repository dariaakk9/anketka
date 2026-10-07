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

namespace anketka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student person = new Student();

        public MainWindow()
        {
            InitializeComponent();

            cbCourse.Items.Add("1");
            cbCourse.Items.Add("2");
            cbCourse.Items.Add("3");
            cbCourse.Items.Add("4");
            cbCourse.Items.Add("5");
            this.DataContext = person;
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Сохранен студент: \n{person.FIO}\n{person.Group} группа \n{person.Age} лет\n{person.Course} курс");
        }
    }
}