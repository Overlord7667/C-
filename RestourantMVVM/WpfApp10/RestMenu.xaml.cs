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
using WpfApp10.Model;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для RestMenu.xaml
    /// </summary>
    public partial class RestMenu : Window
    {
        public RestMenu()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Category category = new Category() { Name = "Десерты" };
        //    UserContext context = new UserContext();
        //    context.Categories.Add(category);
        //    context.SaveChanges();

        //    Model.Menu menu = new Model.Menu()
        //    {
        //        category = category,
        //        Name = "Суши",
        //        Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSpaNcm6YVrAlRKoG8x5U5D6qF2mNodRs24-A&usqp=CAU",
        //        Price = 50
        //    };
        //    context.RestourantMenu.Add(menu);
        //    context.SaveChanges();
        //}
    }
}
