class Program
{
    static void Main(string[] args)
    {
        JournalManage manage = new JournalManage();
        JournalApp _app = new JournalApp(manage);
        _app.Run();
    }
}