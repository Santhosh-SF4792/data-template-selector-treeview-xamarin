using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using Xamarin.Forms;
namespace TemplateSelector
{
    public class FileManager : INotifyPropertyChanged
    {
        #region Fields

        private string itemName;
        private ObservableCollection<FileManager> subFiles;
        private ImageSource imageIcon;

        #endregion

        #region Constructor
        public FileManager()
        {
        }

        #endregion

        #region Properties
        public ObservableCollection<FileManager> SubFiles
        {
            get { return subFiles; }
            set
            {
                subFiles = value;
                RaisedOnPropertyChanged("SubFiles");
            }
        }

        public string ItemName
        {
            get { return itemName; }
            set
            {
                itemName = value;
                RaisedOnPropertyChanged("ItemName");
            }
        }

        public ImageSource ImageIcon
        {
            get { return imageIcon; }
            set
            {
                imageIcon = value;
                RaisedOnPropertyChanged("ImageIcon");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
