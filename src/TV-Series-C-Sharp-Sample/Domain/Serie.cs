using System;
using TV_Series_C_Sharp_Sample.Enum;

namespace TV_Series_C_Sharp_Sample.Domain{
    public class Serie:BaseEntity{
        
        private Category category;
        private string title;
        private string description;
        private int year;
        private bool excluded = false;

        public Serie()
        {

        }

        public Serie(Category _category, string _title, string _description, int _year)
        {
            this.category = _category;
            this.title = _title;
            this.description = _description;
            this.year = _year;
            this.excluded = false;
        }

        public override string ToString(){ 
            string myReturn;
            myReturn = "Category: " + this.category + Environment.NewLine;
            myReturn += "Title: " + this.title + Environment.NewLine;
            myReturn += "Description: " + this.description + Environment.NewLine;
            myReturn += "Year: " + this.year + Environment.NewLine;
            if (this.excluded)
                {
                    myReturn += "Status: EXCLUDED";
                }

            return myReturn;
        }

        public int GetById() => this.id;
        public Category GetCategory() => this.category;
        
        public string GetTitle() => this.title;
        
        public string GetDescription() => this.description;

        public bool GetExcluded() => this.excluded;

    }
}