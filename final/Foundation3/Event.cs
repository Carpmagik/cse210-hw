using System;

class Event
{

    private string _Eventtitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _Eventtitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_Eventtitle}\nDate: {_date}";
    }  

    public string GetStandardDetails()
    {
        return $"Title: {_Eventtitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time} \nAddress: {_address}";
    }
}