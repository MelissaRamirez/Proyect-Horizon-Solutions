using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace ProyectoLenguajesMMDS.Data
{
    public class ImgData
    {
        public byte[] StringToByte(string img)
        {
            byte[] newBytes;

          return newBytes = Convert.FromBase64String(img);

        }


        public string ByteToString(byte[] imgByteArray)
        {

            return Convert.ToBase64String(imgByteArray);

        }
    }
}