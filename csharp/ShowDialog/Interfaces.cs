public interface IDialog
{
    object DataContext { get; set; }
    bool? DialogResult { get; set; }    
    Window Owner { get; set; }
    void Close();
    bool? ShowDialog();
}

public interface IDialogService
{
    void Register<TViewModel, TView>()
        where TViewModel : IDialogRequestClose
        where TView : IDialog;
    bool? ShowDialog<TViewModel>(TViewModel viewModel)
        where TViewModel : IDialogRequestClose;
}

public interface IDialogRequestClose
{
    event EventHandler<DialogCloseRequestedEventArgs> CloseRequested;
}
