namespace DefiningClassesPartTwo
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pointList;

        public Path()
        {
            this.pointList = new List<Point3D>();
        }

        public List<Point3D> PointList { get; set; }

        public void AddPoints(Point3D point)
        {
           this.pointList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pointList.Remove(point);
        }
    }
}
