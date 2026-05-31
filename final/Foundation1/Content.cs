public abstract class Content
{
    protected string _title;
    protected string _author;

    public Content(string title, string author)
    {
        _title = title;
        _author = author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public abstract void DisplayInfo();
}