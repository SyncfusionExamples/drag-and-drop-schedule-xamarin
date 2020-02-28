using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class Meeting : INotifyPropertyChanged
    {
        private string eventname;
        private DateTime from;
        private DateTime to;
        private bool isAllDay;
        private Color color;

        public string EventName
        {
            get { return eventname; }
            set
            {
                eventname = value;
                this.RaisePropertyChanged("EventName");
            }
        }

        public DateTime From
        {
            get { return from; }
            set
            {
                from = value;
                this.RaisePropertyChanged("From");
            }
        }

        public DateTime To
        {
            get { return to; }
            set
            {
                to = value;
                this.RaisePropertyChanged("To");
            }
        }

        public bool IsAllDay
        {
            get { return isAllDay; }
            set
            {
                isAllDay = value;
                this.RaisePropertyChanged("IsAllDay");
            }
        }

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                this.RaisePropertyChanged("Color");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String property)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
