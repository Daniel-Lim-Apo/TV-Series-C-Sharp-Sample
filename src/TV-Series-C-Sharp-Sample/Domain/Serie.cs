using System;
using TV_Series_C_Sharp_Sample.Enum;

namespace TV_Series_C_Sharp_Sample.Domain{
    public class Serie:BaseEntity{
        
        private int categoryNumber;
        private string title;
        private string description;
        private int year;
        private bool excluded = false;

        public Serie()
        {

        }

        public Serie(int _id, int _categoryNumber, string _title, string _description, int _year)
        {
            this.id = _id;
            this.categoryNumber = _categoryNumber;
            this.title = _title;
            this.description = _description;
            this.year = _year;
            this.excluded = false;
        }

        public override string ToString(){ 
            string myReturn;
            myReturn = "Category: " + this.categoryNumber + Environment.NewLine;
            myReturn += "Title: " + this.title + Environment.NewLine;
            myReturn += "Description: " + this.description + Environment.NewLine;
            myReturn += "Year: " + this.year + Environment.NewLine;
            if (this.excluded)
                {
                    myReturn += "Status: EXCLUDED";
                }

            return myReturn;
        }

        public int GetId() => this.id;
        
        public int GetCategoryNumber() => this.categoryNumber;
        
        public string GetTitle() => this.title;
        
        public string GetDescription() => this.description;

        public bool GetExcluded() => this.excluded;

    }
}