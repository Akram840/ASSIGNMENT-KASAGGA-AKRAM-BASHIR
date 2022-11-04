namespace ASSIGNMENT
{
    internal class Program
    {
        public delegate void StudentDetails<L>(L inpi);

        private static string name;
        private static int id;
        private string studtAddress;

        public string getAddress()
        {
            return studtAddress;
        }

        public void setAddress(string SAddress)
        {
            studtAddress = SAddress;

        }


        public static void getStudentName(string Nname)
        {
            name = Nname;
            Console.WriteLine("Name: " + Nname);

        }

        public static void getStudentId(int Id)
        {
            id = Id;
            Console.WriteLine("ID:" + Id);
        }


        public void storeDic()
        {


            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, id.ToString());
            d.Add(2, name);
            d.Add(3, studtAddress);

            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> i in d)
            {

                Console.WriteLine(" " + i.Value);
            }
        }

        static void Main(string[] args)
        {
            StudentDetails<string> h = new StudentDetails<string>(getStudentName);
            h.Invoke("Akram Bb");
            StudentDetails<int> id = new StudentDetails<int>(getStudentId);
            id.Invoke(456);

            // invoking Student Details from Dictionary
            Program objP = new Program();
            objP.setAddress("Kampala");
            objP.storeDic();


        }
    }
}