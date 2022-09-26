public class Program
{
    [System.STAThreadAttribute()]
    public static void Main()
    {
        using (new UI.App())
        {
            MiniColorPicker.App app = new MiniColorPicker.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}