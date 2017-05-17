using System.Collections.ObjectModel;

namespace PreviousDataBindingWheelIssue
{
    public class MyModel
    {
        public ObservableCollection<string> MyData { get; set; }

        public MyModel()
        {
            MyData = new ObservableCollection<string>()
            {
                "Lorem ipsum dolor", "sit amet, consectetur", "adipiscing elit. Sed",
                "Fun Item",
                "rhoncus leo convallis", "pulvinar tellus at",
                "Fun Item",
                "porta metus. Mauris", "sed mauris quis", "neque congue semper",
                "Fun Item",
                "vitae non leo", "Donec aliquet feugiat", "massa vitae luctus",
                "Fun Item",
                "Duis pharetra velit", "et lorem blandit"
            };
        }
    }
}