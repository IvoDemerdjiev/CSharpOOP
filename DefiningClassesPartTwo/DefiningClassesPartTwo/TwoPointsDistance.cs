namespace DefiningClassesPartTwo
{
    using System;

    public static class TwoPointsDistance
    {
        public static double Distance(Point3D a, Point3D b)
        {
            var AbsolutX = Math.Abs(a.X + b.X);
            var AbsolutY = Math.Abs(a.Y + b.Y);
            var AbsolutZ = Math.Abs(a.Z + b.Z);

            var DistanceXY = (AbsolutX * AbsolutX) + (AbsolutY * AbsolutY);

            var Distance = Math.Sqrt(DistanceXY + (AbsolutZ * AbsolutZ));

            return Distance;
        }
    }
}
