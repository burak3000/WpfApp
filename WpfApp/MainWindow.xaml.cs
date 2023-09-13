using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDependency _dependency;
        private readonly IAbstractFactory<ChildForm> _childFormFactory;

        public MainWindow()
        {

        }
        public MainWindow(IDependency dependency, IAbstractFactory<ChildForm> childFormFactory)
        {
            InitializeComponent();
            _dependency = dependency;
            _childFormFactory = childFormFactory;
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            _dependency.DependentCall();
            _childFormFactory.Create().Show();
        }
    }
}
