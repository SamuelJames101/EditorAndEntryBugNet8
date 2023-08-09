namespace BindingToEditor;

public partial class MainPage : ContentPage
{
	MainPageViewModel vm;

    public MainPage()
	{
		InitializeComponent();

		this.BindingContext = this.vm = new MainPageViewModel();

		this.vm.ChangeFromCodeBehind += () =>
		{
            myEditor.Text = "new text";
        };
	}

}


