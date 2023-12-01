internal class Program
{
    public class Point
    {
        public int PointProperty = 1;
    }

    public class PointHolder
    {
        public List<Point> PointsList { get; set; } = new List<Point>();
    }

    static void Main(string[] args)
    {

        #region Set up points and pointholders lists
        // Create a list of points
        List<Point> points = new List<Point>();
        for (int i = 0; i < 10; i++)
        {
            Point p = new Point();
            points.Add(p);
        }

        // Create a list of point holders
        List<PointHolder> pointHolders = new List<PointHolder>();
        for (int i = 0; i < 3; i++)
        {
            PointHolder ph = new PointHolder();
            pointHolders.Add(ph);
        }
        #endregion



        // Iterate through point holders and continuously add points
        while (points.Count > 0)
        {
            foreach (PointHolder pointholder in pointHolders)
            {
                if (points.Count == 0)
                {
                    break; // Break if there are no more points left
                }

                // Add one point to the current point holder
                pointholder.PointsList.Add(points[0]);
                points.RemoveAt(0); // Remove the added point from the points list
            }
        }



        // Print the results

            foreach (PointHolder pointholder in pointHolders)
            {
                Console.WriteLine($"PointProperty: {pointholder.PointsList.Count()}");
            }

        
    }
}