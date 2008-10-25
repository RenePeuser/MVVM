using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;
using DotNetGui.MVVMDemo.Lib.Data;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DotNetGui.MVVMDemo.PeopleList.ViewModel
{
    public class PersonListViewModel
    {
        private ObservableCollection<PersonViewModel> _people = new ObservableCollection<PersonViewModel>();
        private ICommand _editCommand;

        public PersonListViewModel(Person[] people)
        {
            foreach (Person tempPerson in people)
                _people.Add(new PersonViewModel(tempPerson));

            _editCommand = new EditCommand(this);
        }

        public ObservableCollection<PersonViewModel> People
        {
            get { return _people; }
        }

        public ICommand Edit
        {
            get { return _editCommand; }
        }

        private class EditCommand : ICommand
        {
            PersonListViewModel _listViewModel;

            public EditCommand(PersonListViewModel listViewModel)
            {
                _listViewModel = listViewModel;
            }

            #region ICommand Members

            public bool CanExecute(object parameter)
            {
                foreach (PersonViewModel model in _listViewModel.People)
                    if (model.IsSelected)
                        return true;
                return false;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                PersonViewModel selectedModel = null;

                foreach (PersonViewModel model in _listViewModel.People)
                {
                    if (model.IsSelected)
                    {
                        selectedModel = model;
                        break;
                    }
                }

                if (selectedModel != null)
                {
                    PersonEditor.PersonEditor editor = new DotNetGui.MVVMDemo.PersonEditor.PersonEditor();
                    editor.DataContext = selectedModel;
                    editor.ShowDialog();
                }
            }

            #endregion
        }
    }
}
