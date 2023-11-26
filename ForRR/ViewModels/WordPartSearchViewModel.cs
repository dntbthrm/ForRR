using System.Collections.Generic;
using System.ComponentModel;
using ReactiveUI;

namespace ForRR.ViewModels
{

    public class WordPartSearchViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public List<string> Words = new List<string> { "енот", "енотик", "помогите", "пожалуйста", "пельмени", "Траляля", "труляля", "хихихиха", "хачапури"};
        private string _textToSearch;
        private List<string> _foundList = new List<string>();
        
        public string TextToSearch
        {
            get => _textToSearch;
            set => this.RaiseAndSetIfChanged(ref _textToSearch, value);
        }

        public List<string> FoundList
        {
            get => _foundList;
            set => this.RaiseAndSetIfChanged(ref _foundList, value);
        }

        public void FindWords()
        {
            List<string> filteredWords = new List<string>();
            
            foreach (string word in Words)
            {
                if (word.ToLower().StartsWith(TextToSearch.ToLower()) && TextToSearch != "")
                {
                    filteredWords.Add(word);
                }
            }

            FoundList = filteredWords;
        }
        public WordPartSearchViewModel(){}
    }
}