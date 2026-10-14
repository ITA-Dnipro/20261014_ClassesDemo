using System;
using System.Collections.Generic;
using System.Text;

namespace _20261014_ClassesDemo
{
    public class Point2D
    {
        #region --==##   Data  ##==--

        private int _x;
        private int _y;

        #endregion

        //public Point2D()
        //{
        //    _x = 0;
        //    _y = 0;
        //}

        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point2D(int coord)
            : this(coord, coord)
        {
            //_x = coord;
            //_y = coord;
        }

        #region Methods: Getter/Setters

        //public int GetX()
        //{
        //    return _x;
        //}

        public bool IsValidCoord(int coord)
        {
            return coord >= 0;
        }

        //public void SetX(int x)
        //{
        //    // validation
        //    if (!IsValidCoord(x))
        //    {
        //        return;
        //    }

        //    _x = x;
        //}

        //public int GetY()
        //{
        //    return _y;
        //}

        //public void SetY(int y)
        //{
        //    // validation
        //    if (!IsValidCoord(y))
        //    {
        //        return;
        //    }

        //    _y = y;
        //}

        #endregion

        #region --==   Properties  ===---

        public int X
        {
            get 
            { 
                return _x; 
            }
            set 
            {
                // validation
                if (!IsValidCoord(value))
                {
                    return;
                }

                _x = value; 
            }
        }

        public int Y
        {
            get 
            { 
                return _y; 
            }
            set 
            {
                // validation
                if (!IsValidCoord(value))
                {
                    return;
                }

                _y = value; 
            }
        }


        #endregion
    }
}
