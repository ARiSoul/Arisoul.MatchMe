using Maui.Models;

namespace Maui.ViewModels;

public partial class ProfileViewModel : BaseViewModel
{
    private ObservableCollection<Profile> _profileCollection;

    public ObservableCollection<Profile> profile
    {
        get { return _profileCollection; }
        set { _profileCollection = value; }
    }

    public ProfileViewModel()
    {
        _profileCollection = new ObservableCollection<Profile>();
        _profileCollection.Add(new Profile { Description = "Music", BgColor = Color.FromArgb("#ffeefa") });
        _profileCollection.Add(new Profile { Description = "Photo", BgColor = Color.FromArgb("#eaefff") });
        _profileCollection.Add(new Profile { Description = "Art History", BgColor = Color.FromArgb("#fef1e8") });
        _profileCollection.Add(new Profile { Description = "Design", BgColor = Color.FromArgb("#eaefff") });
        _profileCollection.Add(new Profile { Description = "Art Filma", BgColor = Color.FromArgb("#fef1e8") });
        _profileCollection.Add(new Profile { Description = "Dancing", BgColor = Color.FromArgb("#ffeefa") });

    }
}
