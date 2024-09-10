namespace szintfelmero_2024_kovacs_peter_12f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Feladatok
    {
        private List<Meccs> Meccsek = new();
        public Feladatok(string fileName)
        {
            try
            {
                using (StreamReader reader = new(fileName))
                {
                    string currLine;
                    while ((currLine = reader.ReadLine()) != null)
                    {
                        string[] datas = currLine.Split(' ');
                        Meccsek.Add(new(Convert.ToInt32(datas[0]), Convert.ToInt32(datas[1]), Convert.ToInt32(datas[2]), Convert.ToInt32(datas[3]), Convert.ToInt32(datas[4]), datas[5], datas[6]));
                    }

                }
            }
            catch (Exception ex)
            {
            }
        }

        public void Feladat1()
        {

        }
    }
}
