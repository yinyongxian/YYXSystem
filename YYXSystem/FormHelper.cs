using System.Windows.Forms;

namespace YYXSystem
{
    public static class FormHelper<T>
        where T:Form,new()
    {
        public static void Show()
        {
            using (var form = new T())
            {
                form.Show();
            }
        }

        public static void ShowDialog()
        {
            using (var form = new T())
            {
                form.ShowDialog();
            }
        }
    }
}
