using System.ComponentModel;
using ReactiveUI;

namespace ForRR.ViewModels
{

    public class CountWordsViewModel: ViewModelBase, INotifyPropertyChanged
    {
        private string _myText;
        private string _resultCount;

        public string MyText
        {
            get => _myText;
            set => this.RaiseAndSetIfChanged(ref _myText, value);
        }

        public string ResultCount
        {
            get => _resultCount;
            set => this.RaiseAndSetIfChanged(ref _resultCount, value);
        }

        public void CountWordsInText()
        {
            string text = MyText.Trim();
            int wordCount = 0;
            bool inWord = false;

            foreach (char c in text)
            {
                if (char.IsWhiteSpace(c) || char.IsPunctuation(c))
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }

            ResultCount = wordCount.ToString();
        }
        public CountWordsViewModel(){}
    }
}