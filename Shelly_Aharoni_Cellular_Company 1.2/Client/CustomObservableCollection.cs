using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class CustomObservableCollection<T> : ObservableCollection<T>
    {
        public CustomObservableCollection()
      : base()
        {
        }

        public CustomObservableCollection(IEnumerable<T> collection)
          : base(collection)
        {
        }

        public CustomObservableCollection(List<T> list)
          : base(list)
        {
        }

        public void Repopulate(IEnumerable<T> collection)
        {
            this.Items.Clear();
            foreach (var item in collection)
                this.Items.Add(item);

            this.OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            this.OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            //return Items;
        }
    }
}
