using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Madde
    {
        string durum;
        int maddesonucu;
        int maddeid;

        public string Durum
        {
            get
            {
                return durum;
            }

            set
            {
                durum = value;
            }
        }

        public int Maddesonucu
        {
            get
            {
                return maddesonucu;
            }

            set
            {
                maddesonucu = value;
            }
        }
        public int MaddeID
        {
            get
            {
                return maddeid;
            }

            set
            {
                maddeid = value;
            }
        }

    }
}
