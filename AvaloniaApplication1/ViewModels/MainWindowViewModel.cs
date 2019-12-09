using System.Linq;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        private string[] leakedItems = { };

        public string[] LeakedItems {
            get => leakedItems;
            set => this.RaiseAndSetIfChanged(ref leakedItems, value);
        }

        private bool aLot = true;

        public void RefreshList() {
            int count = aLot ? 50 : 1;
            aLot = !aLot;

            LeakedItems = Enumerable.Range(0, count)
                .Select(_ => "Test Test Test")
                .ToArray();
        }
    }
}
