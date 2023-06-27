namespace DataTransferClasses.Classes
{
    public class RoomType
    {

        private int roomTypeID;
        private string name;
        private float cost;
        private string description;


        public RoomType( string name, float cost, string description)
        {
            this.name = name;
            this.cost = cost;
            this.description = description;

        }

      
        public string Name
        {
            get => name;
            set => name = value;
        }
    
        public float Cost
        {
            get => cost;
            set => cost = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }

    }
}
