namespace Maui.Models;

public class Profile
{
    private string _description;
    private Color _bgColor;

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public Color BgColor
    {
        get { return _bgColor; }
        set { _bgColor = value; }
    }
}
