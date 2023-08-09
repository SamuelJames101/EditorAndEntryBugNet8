using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BindingToEditor;

public class MainPageViewModel : INotifyPropertyChanged
{
	private string myText;

	public MainPageViewModel()
	{
		this.ChangeTextCommand = new Command(ChangeText);
	}

	public Action ChangeFromCodeBehind { get; set; }

	public ICommand ChangeTextCommand { get; set; }


    public string MyText
	{
		get => this.myText;
		set
		{
			this.myText = value;
			this.OnPropertyChanged();
		}
	}

	public void ChangeText()
	{
		this.MyText = "New text";
        //this.ChangeFromCodeBehind.Invoke();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

