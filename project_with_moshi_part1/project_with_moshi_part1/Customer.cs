namespace project_with_moshi_part1
{
    partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;

            public Customer(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
        }

        //public Customer(int id, string name)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //}
    }
}
