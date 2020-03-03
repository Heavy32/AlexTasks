namespace Logger
{
    public class Cucumber
    {
        public string color { get; set; }
        public int length { get; set; }
        public float weight { get; set; }
        public bool isTasty { get; set; }
        public Cucumber(string color, int length, float weight, bool isTasty)
        {
            this.color = color;
            this.length = length;
            this.weight = weight;
            this.isTasty = isTasty;
        }

    }
}