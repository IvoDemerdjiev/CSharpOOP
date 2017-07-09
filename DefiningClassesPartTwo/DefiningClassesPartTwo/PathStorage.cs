namespace DefiningClassesPartTwo
{
    using System.IO;

    public class PathStorage
    {
        public static void SavePath(Path path, string pathFinder)
        {
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathFinder + ".txt"))
            {
                for (int i = 0; i <path.PointList.Count ; i++)
                {
                    sw.WriteLine(path.PointList[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream==false)
                {
                    string PointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(PointTxt);
                    path.AddPoints(nextPoint);
                }
            }
            return path;
        }
    }
}
