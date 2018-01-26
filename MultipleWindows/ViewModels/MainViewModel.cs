using MultipleWindows.Models;
using System;
using System.Collections.Generic;

namespace MultipleWindows.ViewModels
{
    public class MainViewModel
    {
        private DataManager dm;

        public Person CurrentPerson { get; set; }
        public List<Person> PersonGallery { get; set; } 

        public MainViewModel()
        {
            // Instantiate DataManager, i.e. the Model layer of MVVM
            dm = new DataManager();

            // Populate MainViewModel properties
            CurrentPerson = dm.ImportantPerson;
            PersonGallery = dm.ImportantPersons;
        }

        public void AddNewPerson()
        {
            PersonGallery.Add(new Person() { FirstName = "New", LastName = "Person" });
        }
    }
}