using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab9
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //przeniesione do klasy StudentList//ObservableCollection<Student> students = new ObservableCollection<Student>(); //typ wbudowany podobony do Listy
            //StudentList.ItemsSource = students;
            this.DataContext = new StudentView();


            //listBox
            var view = new StudentView();
            this.DataContext = view;
            ListBox.ItemsSource = view.List.students;
            //ponizej ten sam kod tylko ze ten nie korzysta juz  z przygotowanych danych w klasie tylko robi je na nowo
            //ListBox.ItemsSource = new ObservableCollection<Student>()
            //    {
            //        new Student
            //        {
            //            Id = 1,
            //            Name = "Mark",
            //            LastName = "Kowalski",
            //            Entlisting = new DateTime(2000, 1, 1)
            //        },
            //        new Student
            //        {
            //            Id = 1,
            //            Name = "John",
            //            LastName = "Kwiatkowski",
            //            Entlisting = new DateTime(2002, 1, 2)
            //        },
            //        new Student
            //        {
            //            Id = 1,
            //            Name = "Peter",
            //            LastName = "Nowak",
            //            Entlisting = new DateTime(2003, 3, 3)
            //        }
            //    };

            //LIST VIEW jest listboxem ale ma takze view ale pozwala towrzyc dodatkowo szablon w jakim info ma sie wyswietlic te kontrolki przeznaczone sa do bindowania



            ////bindowanie w stackpanelu (zakomentowany stackanel)
            ////StudentList.DataContext = students //Wpisuje tylko jednego wiec zrobimy to inaczej
            //var wrapPanel = StudentList.Children.OfType<WrapPanel>(); //ofType to zabezpiecznie (polega chyba na tym że typ ma być wrap panel
            //foreach (var item in students)
            //{
            //    var test = new TextBox();
            //    Binding binding = new Binding("Text"); //przyjmuje nazwe propertisa który ma zbindowac
            //    binding.Source = item.Name;
            //    test.SetBinding(TextBox.TextProperty, binding); // wklasie textbox jest statyczne pole textproperty i to ma tam cały zestawik zaleznie od tego co potrzebuje np dateProperty (o ile dobrze zrozumiałem)
            //    //ta składnia wyżej dodaje bindowanie ręcznie
            //    //ponizej dodawanie z konstruktora bindowania (do dokonczenia)  
            //    StudentList.Children.Add(new WrapPanel
            //    {
            //        DataContext = item,
            //        Children = {
            //            new TextBox()
            //            {

            //            }
            //        }
            //    });

            //}

            //bindowanie pojedyńczego elementu 
            //Student stud = new Student
            //{
            //    Id = 1,
            //    Name = "Mark",
            //    LastName = "Kowalski",
            //    Entlisting = new DateTime(2000, 1, 1)
            //};
            //this.DataContext = stud;
        }
    }
}
