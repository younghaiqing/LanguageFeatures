namespace LanguageFeatures
{
    public class Product
    {
        private string _name;

        public string Name
        {
            get { return _name+ProductID; }
            set { _name = value; }
        }
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}