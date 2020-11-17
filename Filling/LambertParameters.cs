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
        public int LightR;
        public double T;
        public double t;
        public bool UseLight;

        public (int x, int y) CenterCoords;
        public int ReflectorH;
        public Color ReflectorColor;

        public Func<int, int, (double x, double y, double z)> Normal;    // wektor normalny
        public (double x, double y, double z) V;

        public Color GetColor(int x, int y, Color pixel)
        {
            Color result = pixel;
            if (UseLight)
            {
                (double R, double G, double B) Il = (Light.R / 255.0, Light.G / 255.0, Light.B / 255.0);
                (double R, double G, double B) Io = (pixel.R / 255.0, pixel.G / 255.0, pixel.B / 255.0);
                (int x, int y, int z) lightVector = (LightPosition.x - x, LightPosition.y - y, LightPosition.z);
                double lightVecLen = Math.Sqrt(lightVector.x * lightVector.x + lightVector.y * lightVector.y + lightVector.z * lightVector.z);
                (double x, double y, double z) L = (lightVector.x / lightVecLen, lightVector.y / lightVecLen, lightVector.z / lightVecLen);         //wersor do światła

                var n = Normal(x, y);
                double nLen = Math.Sqrt(n.x*n.x + n.y*n.y + n.z*n.z);
                (double x, double y, double z) N = (n.x / nLen, n.y / nLen, n.z / nLen);    // wersor normalny

                double cosNL = L.x * N.x + L.y * N.y + L.z * N.z;   // iloczyn skalarny wersorów
                if (double.IsNaN(cosNL))
                    cosNL = 0.0;

                (double x, double y, double z) r = (2*cosNL*N.x - L.x, 2*cosNL*N.y - L.y, 2*cosNL*N.z - L.z);
                double rLen = Math.Sqrt(r.x * r.x + r.y * r.y + r.z * r.z);
                r = (r.x / rLen, r.y / rLen, r.z / rLen);
                double cosVR = V.x * r.x + V.y * r.y + V.z * r.z;

                double R = kd * Il.R * Io.R * cosNL + ks * Il.R * Io.R * Math.Pow(cosVR, m);
                double G = kd * Il.G * Io.G * cosNL + ks * Il.G * Io.G * Math.Pow(cosVR, m);
                double B = kd * Il.B * Io.B * cosNL + ks * Il.B * Io.B * Math.Pow(cosVR, m);

                result = Color.FromArgb(Math.Max(0, Convert.ToInt32(R * 255.0)), Math.Max(0, Convert.ToInt32(G * 255.0)), Math.Max(0, Convert.ToInt32(B * 255.0)));
            }

            return ReflectorH > 0 ? AddReflector(result, x, y, result) : result;
        }

        public void MoveLight()
        {
            t += 0.1;
            LightPosition = (CenterCoords.x + Convert.ToInt32(LightR * Math.Cos((2 * Math.PI / T) * t)),
                                                CenterCoords.y + Convert.ToInt32(LightR * Math.Sin((2 * Math.PI / T) * t)),
                                                100 + Convert.ToInt32(50.0 * Math.Sin(t)));
        }

        private Color AddReflector(Color c, int x, int y, Color pixel)
        {
            (double R, double G, double B) Io = (pixel.R / 255.0, pixel.G / 255.0, pixel.B / 255.0);

            (double R, double G, double B) Il = (ReflectorColor.R / 255.0, ReflectorColor.G / 255.0, ReflectorColor.B / 255.0); // Il

            (int x, int y, int z) k = (-CenterCoords.x, -CenterCoords.y, ReflectorH);
            double KLen = Math.Sqrt((k.x * k.x) + (k.y * k.y) + (k.z * k.z));
            (double x, double y, double z) K = (k.x / KLen, k.y / KLen, k.z / KLen);    // K - wersos

            (int x, int y, int z) l = (-x, -y, ReflectorH);
            double LLen = Math.Sqrt(l.x * l.x + l.y * l.y + l.z * l.z);
            (double x, double y, double z) L = (l.x / LLen, l.y / LLen, l.z / LLen);    // L - wersor

            double cosKL = K.x * L.x + K.y * L.y + K.z * L.z;
            if (double.IsNaN(cosKL))
                cosKL = 0.0;

            (double x, double y, double z) r = (2 * cosKL * K.x - L.x, 2 * cosKL * K.y - L.y, 2 * cosKL * K.z - L.z);
            double rLen = Math.Sqrt(r.x * r.x + r.y * r.y + r.z * r.z);
            r = (r.x / rLen, r.y / rLen, r.z / rLen);
            double cosVR = V.x * r.x + V.y * r.y + V.z * r.z;


            double R = kd * Il.R * Io.R * cosKL + ks * Il.R * Io.R * Math.Pow(cosVR, 10);
            double G = kd * Il.G * Io.G * cosKL + ks * Il.G * Io.G * Math.Pow(cosVR, 10);
            double B = kd * Il.B * Io.B * cosKL + ks * Il.B * Io.B * Math.Pow(cosVR, 10);

            return Color.FromArgb(Math.Max(0, Convert.ToInt32(R * 255.0)), Math.Max(0, Convert.ToInt32(G * 255.0)), Math.Max(0, Convert.ToInt32(B * 255.0)));
        }
    }
}
