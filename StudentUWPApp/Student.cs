using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentUWPApp
{
    public class Student : INotifyPropertyChanged
    {
        private string _navn;
        public Student(string Navn)
        {
            _navn = Navn;
        }
        public string Navn
        {
            get { return _navn; }
            set
            {
                _navn = value;
                this.OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
