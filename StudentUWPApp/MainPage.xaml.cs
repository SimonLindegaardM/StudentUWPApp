using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentUWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Student simon = new Student("simon",13);
            Student bob = new Student("bob",34);
            Student per = new Student("per",302);
            Student søren = new Student("søren",420);
            Student torben = new Student("torben",666);

            OC_list_Students.Add(simon);
            OC_list_Students.Add(bob);
            OC_list_Students.Add(per);
            OC_list_Students.Add(søren);
            OC_list_Students.Add(torben);
        }
        ObservableCollection<Student> OC_list_Students = new ObservableCollection<Student>();
    }
}
