namespace Problem
{
    internal class Result
    {
        internal List<int> taken_items { get; }
        internal int total_value { get; set; }
        private int total_weight { get; set; }

        public Result()
        {
            taken_items = new List<int>();
            total_value = 0;
            total_weight = 0;
        }
        public void takeItem(Item item)
        {
            taken_items.Add(item.Id);
            total_value += item.value;
            total_weight += item.weight;
        }

        public override string ToString()
        {
            //taken_items.Sort();
            string result = "";
            foreach (var item in taken_items)
            {
                result += item + " ";
            }
            return "items: " + result + System.Environment.NewLine + "total value: " + total_value + System.Environment.NewLine + "total weight: " + total_weight;
        }
    }
}