using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public struct LambertParameters
    {
        public double kd;       // współczynnik rozproszenia
        public double ks;       // współczynnik zwierciadlany
        public int m;           // współczynnik zwierciedlenie
        public Color Light;
        public (int x, int y, int z) LightPosition;
        public (double x, double y, double z) N;    // wektor normalny
        public (double x, double y, double z) V;

        public Color GetColor(int x, int y, Color pixel)
        {
            (double R, double G, double B) Il = (Light.R / 255.0, Light.G / 255.0, Light.B / 255.0);
            (double R, double G, double B) Io = (pixel.R / 255.0, pixel.G / 255.0, pixel.B / 255.0);

            (int x, int y, int z) lightVector = (LightPosition.x - x, LightPosition.y - y, LightPosition.z);
            double lightVecLen = Math.Sqrt(lightVector.x * lightVector.x + lightVector.y * lightVector.y + lightVector.z * lightVector.z);
            (double x, double y, double z) L = (lightVector.x / lightVecLen, lightVector.y / lightVecLen, lightVector.z / lightVecLen);         //wersor do światła

            double cosNL = L.x * N.x + L.y * N.y + L.z * N.z;   // iloczyn skalarny wersorów
            if (double.IsNaN(cosNL))
                cosNL = 0.0;

            (double x, double y, double z) r = (2*cosNL*N.x - L.x, 2*cosNL*N.y - L.y, 2*cosNL*N.z - L.z);
            double cosVR = V.x*r.x + V.y*r.y + V.z*r.z;

            double R = kd * Il.R * Io.R * cosNL + ks * Il.R * Io.R * Math.Pow(cosVR, m);
            double G = kd * Il.G * Io.G * cosNL + ks * Il.G * Io.G * Math.Pow(cosVR, m);
            double B = kd * Il.B * Io.B * cosNL + ks * Il.B * Io.B * Math.Pow(cosVR, m);

            return Color.FromArgb(Convert.ToInt32(R * 255.0), Convert.ToInt32(G * 255.0), Convert.ToInt32(B * 255.0));
        }
    }
}
