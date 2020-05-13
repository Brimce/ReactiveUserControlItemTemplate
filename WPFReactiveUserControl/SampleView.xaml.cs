using System.Reactive.Disposables;
using ReactiveUI;

namespace $rootnamespace$.$fileinputname$
{
    /// <summary>
    /// Logique d'interaction pour SampleView.xaml
    /// </summary>
    public partial class $safeitemrootname$
    {
        public $safeitemrootname$()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, vm => vm.Title, view => view.TextBlockTitle.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}
