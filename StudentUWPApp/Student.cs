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
        private int _studentid;
        public Student(string Navn, int StudentID )
        {
            _navn = Navn;
            _studentid = StudentID;
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
        public int StudentID
        {
            get { return _studentid; }
            set
            {
                _studentid = value;
                this.OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
