using System.Windows;

namespace WpfApp
{
    internal class Dependency : IDependency
    {
        public void DependentCall()
        {
            MessageBox.Show("Dependent call!");
        }
    }

    public interface IDependency
    {
        public void DependentCall();
    }
}
