# How to drag and drop appointment at the exact hour in Schedule (SfSchedule) Xamarin.Forms?
You can drag the appointment to the exact hour in Xamarin.Forms SfSchedule using the [AllowAppointmentDrag](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfSchedule.XForms~Syncfusion.SfSchedule.XForms.SfSchedule~AllowAppointmentDrag.html?) property and [AppointmentDrop](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfSchedule.XForms~Syncfusion.SfSchedule.XForms.SfSchedule~AppointmentDrop_EV.html?) event.
Enable appointment drag and drop-in schedule by setting the **AllowAppointmentDrag** property of SfSchedule to **True**.

``` xml
<schedule:SfSchedule x:Name="schedule" AllowAppointmentDrag="True"/>
```
Initialize an event handler for **AppointmentDrop** event of Schedule.

``` c#
schedule.AppointmentDrop += ScheduleOnAppointmentDrop;
```
In AppointmentDrop event handler, get the drop time of appointment using the **DropTime** property of event, round off the value to exact hour by mentioning the minute value to zero and assign the rounded off value to the DropTime property of event.
``` c#
private void ScheduleOnAppointmentDrop(object sender, AppointmentDropEventArgs e)
{
    var dropTime = e.DropTime;
    e.DropTime = new DateTime(dropTime.Year, dropTime.Month, dropTime.Day, dropTime.Hour, 0, 0);
}
```
**Output**
