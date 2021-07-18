using System;

namespace TV_Series_C_Sharp_Sample.Class{
    public class Serie : BaseEntity {
    
        private Category category;
        private string title;
        private string description;
        private bool excluded;
        
        public Serie(){

        }

        public Serie(int _id, Category _category, string _title, string _description, bool _excluded)
        {
            this.id = _id;
            this.category = _category;
            this.title = _title;
            this.description = _description;
            this.excluded = _excluded;
            
        }

        public void Insert(Serie serie)
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(){
            return this.category;
        }

        public string GetTitle(){
            return this.title;
        }

        public string GetDescription(){
            return this.description;
        }

        public bool getExcluded(){
            return this.excluded;
        }



    }
}