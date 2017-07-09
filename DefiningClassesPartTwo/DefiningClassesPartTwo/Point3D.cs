namespace DefiningClassesPartTwo
{
    using System;
    using System.Text;

    public struct Point3D
    {
        private double x;
        private double y;
        private double z;

        private static readonly Point3D Point= new Point3D(0 ,0 ,0);

        public Point3D(double x, double y , double z)
            :this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D Point0
        {
            get
            {
                return Point;
            }
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("All Coordinates must be >= 0");
                }
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("All Coordinates must be >= 0");
                }
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("All Coordinates must be >= 0");
                }
                this.z = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0:3},{1:3},{2:3}", this.x, this.y, this.z);
        }

        public static Point3D Parse(string input)
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {

                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coordinate = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coordinate;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }

        static void Main(string[] args)
        {

        }
    }
}
