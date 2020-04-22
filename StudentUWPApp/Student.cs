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
        private int _mobilnr;
        public Student(string Navn, int StudentID, int MobilNr )
        {
            _navn = Navn;
            _studentid = StudentID;
            _mobilnr = MobilNr;
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
        public int MobilNr
        {
            get { return _mobilnr; }
            set
            {
                _mobilnr = value;
                this.OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
