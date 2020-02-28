using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class ScheduleBehavior : Behavior<ContentPage>
    {
        SfSchedule schedule;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            schedule = bindable.FindByName<SfSchedule>("schedule");
            schedule.AppointmentDrop += ScheduleOnAppointmentDrop;
        }

        private void ScheduleOnAppointmentDrop(object sender, AppointmentDropEventArgs e)
        {
            var dropTime = e.DropTime;
            e.DropTime = new DateTime(dropTime.Year, dropTime.Month, dropTime.Day, dropTime.Hour, 0, 0);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            schedule.AppointmentDrop -= ScheduleOnAppointmentDrop;
            schedule = null;
        }
    }
}
