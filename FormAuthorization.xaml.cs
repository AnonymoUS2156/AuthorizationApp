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
using System.Windows.Shapes;
using WpfApp3.Data;
namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для FormAuthorization.xaml
    /// </summary>
    public partial class FormAuthorization : Window
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }
        public static Users Enter_Users;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Enter_Users = null;
            Model1 model = new Model1();
            Enter_Users = model.Users.FirstOrDefault(x => x.Login == TextBoxLogin.Text && x.Password == TextBoxPassword.Text);
            if (Enter_Users != null) 
            {
                switch (Enter_Users.RoleID)
                {case 1:   
                    FormManager formManager = new FormManager();
                    formManager.ShowDialog();
                    break;
                case 2:
                    FormSeller formSeller = new FormSeller();
                    formSeller.ShowDialog();
                        break;
                case 3:
                        FormDirector formDirector = new FormDirector();
                        formDirector.ShowDialog();
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }
        }

     
    }
}
