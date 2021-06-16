using SQLite;

namespace Inventory.Classes
{
    class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string Place { get; set; }
    }
}
