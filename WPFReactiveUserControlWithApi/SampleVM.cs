using System.Reactive;
using $rootnamespace$.$fileinputname$.Api;
using ReactiveUI;

namespace $rootnamespace$.$fileinputname$
{
    public class $safeitemrootname$ : ReactiveObject
    {
        public string Title { get; set; }
        public ReactiveCommand<Unit, Unit> Save { get; }
        
        public $safeitemrootname$(I$fileinputname$Api api)
        {
            Save = ReactiveCommand.CreateFromObservable<Unit, Unit>(_ => api.Save());
        }
    }
}
