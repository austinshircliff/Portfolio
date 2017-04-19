using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class GroundPackage
    {
        public int _originzipcode;//variable for origin zip
        public int _destinationzipcode;//variable for destination zip
        public double _length;// variable for length
        public double _width;//variable for width
        public double _height;//variable for height
        public double _weight;//variable for weight
        public const int MinZip = 00000;//constant for the min zip allowed
        public const int MaxZip = 99999;//constant for the max zip allowed

        public GroundPackage(int oz, int dz, double l, double wid, double h, double wht)//constructor
        {
            _originzipcode = oz;//set the variable equal to the constructor parameter
           _destinationzipcode = dz;//set the variable equal to the constructor parameter
           _length = l;//set the variable equal to the constructor parameter
           _width = wid;//set the variable equal to the constructor parameter
           _height = h;//set the variable equal to the constructor parameter
           _weight = wht;//set the variable equal to the constructor parameter

        }
        public int OriginZip
        {
            get
            {
                return _originzipcode;//gets thee _originzipcode
            }
            set
                //precondition:00000 < X <99999
                //postcondition: sets the value equal to the entry
            {
                if ((value >= MinZip) && (value <= MaxZip))//sets the zip if it meets the if statement
                    _originzipcode = value;
            }
        }
            public int DestinationZip//declaration
            {
                get
                { 
                    return _destinationzipcode;//gets destinationzip
                }
                set
                {
                    //precondition:00000 < X <99999
                    //postcondition: sets the value equal to the entry
                    if ((value >= MinZip) && (value <= MaxZip))//sets the zip if it meets the if statement
                        _destinationzipcode = value;
                }
            }
                public double Length//declaration
                {
                    get
                    {
                        return _length;//gets length
                    }
                    set
                    {
                        //precondition: x > 0
                        //postcondition: sets _lenth equal to value
                        if (value > 0)
                            _length = value;
                    }
                }
        public double Width//declaration
        {
            get
            {
                return _width;//gets width
            }
            set
            {
                //precondition:X > 0
                //postcondition:sets width to value
                if (value > 0)//sets value if it meets the if statement
                    _width = value;
            }
        }
        public double Height//declaration
        {
            get
            {
                return _height;// gets height
            }
            set
            {
                //precondition:X > 0
                //postcondition:sets width to value
                if (value > 0)//sets value if it meets the if statement
                    _height = value;
            }
        }
        public double Weight
        {
            get
            {
                return _weight;//gets weight
            }
            set
            {
                //precondition:X > 0
                //postcondition:sets width to value
                if (value > 0)//sets value if it meets the if statement
                    _weight = value;
            }
        }
        public int ZoneDistance//declaration
        {
            get
            {
                return Math.Abs(OriginZip/10000) - (DestinationZip/10000);//returns the absolute value of original zip/10000 - destinationzip/10000
            }
        }
        public double CalcCost()//CalcCost method returning a double
        {
            double cost;//cost variable declared
            return cost = .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight);//returns the output of this formula
        }

        public override string ToString()//ToString Method
        {
            string answer;
            answer = String.Format("Origin Zipcode: {0} Destination Zipcode: {1} Length: {2} Width: {3} Height: {4} Weight: {5}",
                OriginZip, DestinationZip, Length, Width, Height, Weight);
            return answer;//displays what the data is and the data in a messagebox

            
        }

    }
}
