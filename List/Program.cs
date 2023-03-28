namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Equipment> list = new List<Equipment>();

            Console.WriteLine("Capacity of the list: " + list.Capacity);
            Console.WriteLine("Length of the list: " + list.Count + "\n");

            list.Add(new Equipment() { Owner = "John", EquipmentName = "headlamp" });
            list.Add(new Equipment() { Owner = "Mary", EquipmentName = "headlamp" });
            list.Add(new Equipment() { Owner = "Joe", EquipmentName = "socks" });
            list.Add(new Equipment() { Owner = "Joe", EquipmentName = "blanket" });
            list.Add(new Equipment() { Owner = "Chris", EquipmentName = "raincoat" });
            list.Add(new Equipment() { Owner = "Mary", EquipmentName = "knife" });
            //list.Add(new Equipment() { Owner = "Ellen", EquipmentName = "knife" });

            Console.WriteLine("Capacity of the list: " + list.Capacity);
            Console.WriteLine("Length of the list: " + list.Count + "\n");

            list.TrimExcess();

            Console.WriteLine("Capacity of the list: " + list.Capacity);
            Console.WriteLine("Length of the list: " + list.Count + "\n");

            list.RemoveAt(3);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            Equipment equipment = new Equipment();
            equipment.Owner = "Sam";
            equipment.EquipmentName = "gourd";

            list.Insert(2, equipment);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            list.Remove(equipment);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            list.Clear();
            //list.Capacity = 0;
            list.TrimExcess();

            Console.WriteLine("Capacity of the list: " + list.Capacity);
            Console.WriteLine("Length of the list: " + list.Count + "\n");
        }
    }
}