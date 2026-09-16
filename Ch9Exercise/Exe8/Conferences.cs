using System;
using System.Collections.Generic;
using System.Text;

class Conference : IComparable<Conference>
{
    private string groupName;
    private string startDate;
    private int attendees;

    public Conference(string groupName, string startDate, int attendees)
    {
        this.groupName = groupName;
        this.startDate = startDate;
        this.attendees = attendees;
    }

    public string GroupName
    {
        get { return groupName; }
        set { groupName = value; }
    }

    public string StartDate
    {
        get { return startDate; }
        set { startDate = value; }
    }

    public int Attendees
    {
        get { return attendees; }
        set { attendees = value; }
    }
    public int CompareTo(Conference other)
    {
        return this.attendees.CompareTo(other.attendees);

    }
    public override string ToString()
    {
        return string.Format("{0,-20} {1,-15} {2,10}", groupName, startDate, attendees);
    }

}
