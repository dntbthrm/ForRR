using System.Collections.ObjectModel;
using System.ComponentModel;
using ForRR.DataModel;
using ReactiveUI;

namespace ForRR.ViewModels
{

    public class UserMessageViewModel: ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<MessageModel> _messageList = new ObservableCollection<MessageModel>();
        private string _inputVal;
        
        public ObservableCollection<MessageModel> MessageList
        {
            get => _messageList;
            set => this.RaiseAndSetIfChanged(ref _messageList, value);
        }

        public string InputVal
        {
            get => _inputVal;
            set => this.RaiseAndSetIfChanged(ref _inputVal, value);
        }

        public void Send()
        {
            var message = new MessageModel();
            message.MessageText = InputVal;
            MessageList.Add(message);
        }
        public UserMessageViewModel()
        {}
    }
}