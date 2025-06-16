using System.Globalization;

namespace MauiMCTMinusBug;

public partial class MainPage : ContentPage
{
	CultureInfo ar_AR = new CultureInfo("ar-AR");
	CultureInfo en_US = new CultureInfo("en-US");

	public CultureInfo CurrentCulture
	{
		get => CultureInfo.CurrentCulture;
		set
		{
			CultureInfo.CurrentCulture = value;
			OnPropertyChanged(nameof(CurrentCulture));
		}
	}

	public MainPage()
	{
		CurrentCulture = en_US;
		BindingContext = this;
		InitializeComponent();
	}

	void OnChangeCulture(object sender, EventArgs e)
	{
		CurrentCulture = (CurrentCulture.Name != ar_AR.Name) ? ar_AR : en_US;
	}
}
