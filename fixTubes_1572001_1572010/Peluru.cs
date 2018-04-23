using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing;

namespace fixTubes_1572001_1572010
{
    public class Peluru
    {
        public Peluru()
        {
            createPeluru();   
        }
        public void createPeluru()
        {
            //peluru
            GL.Begin(PrimitiveType.Triangles);
            //alas dasar
            GL.Color3(Color.DarkBlue);
            //titik tengah atas
            GL.Vertex3(0, 0, 0.03f);
            //kiri bawah
            GL.Vertex3(-0.04f, -0.1f, 0);
            //kanan bawah
            GL.Vertex3(0.04f, -0.1f, 0);

            //samping kiri
            GL.Color3(Color.Blue);
            //kanan bawah
            GL.Vertex3(-0.02f, -0.1f, 0.06f);
            //kiri bawah
            GL.Vertex3(-0.04f, -0.1f, 0);
            //atas tengah
            GL.Vertex3(0, 0, 0.03f);

            //samping kanan
            GL.Color3(Color.Blue);
            //kiri bawah
            GL.Vertex3(0.02f, -0.1f, 0.06f);
            //atas tengah
            GL.Vertex3(0, 0, 0.03f);
            //kanan bawah
            GL.Vertex3(0.04f, -0.1f, 0);

            //segitiga tengah penutup
            GL.Color3(Color.DarkBlue);
            //titik tengah
            GL.Vertex3(0, 0, 0.03f);
            //kiri
            GL.Vertex3(-0.02f, -0.1f, 0.06f);
            //kanan
            GL.Vertex3(0.02f, -0.1f, 0.06f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            //kiri
            GL.Color3(Color.Blue);
            //sebelah kiri atas
            GL.Vertex3(-0.04f, -0.1f, 0);
            //kanan atas
            GL.Vertex3(-0.02f, -0.1f, 0.06f);
            //kanan bawah
            GL.Vertex3(-0.03f, -0.3f, 0.07f);
            //kiri bawah
            GL.Vertex3(-0.05f, -0.3f, 0);

            //tengah
            GL.Color3(Color.DarkBlue);
            //kiri atas
            GL.Vertex3(-0.02f, -0.1f, 0.06f);
            //kanan atas
            GL.Vertex3(0.02f, -0.1f, 0.06f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.3f, 0.07f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.3f, 0.07f);

            //kanan
            GL.Color3(Color.Blue);
            //sebelah kiri atas
            GL.Vertex3(0.02f, -0.1f, 0.06f);
            //kanan atas
            GL.Vertex3(0.04f, -0.1f, 0);
            //kanan bawah
            GL.Vertex3(0.05f, -0.3f, 0);
            //kiri bawah
            GL.Vertex3(0.03f, -0.3f, 0.07f);

            //alas
            GL.Color3(Color.DarkBlue);
            //kiri bawah
            GL.Vertex3(-0.05f, -0.3f, 0);
            //kiri atas
            GL.Vertex3(-0.04f, -0.1f, 0);
            //kanan atas
            GL.Vertex3(0.04f, -0.1f, 0);
            //kanan bawah
            GL.Vertex3(0.05f, -0.3f, 0);

            GL.Color3(Color.Blue);
            GL.Vertex3(-0.05f, -0.3f, 0);
            GL.Vertex3(0.05f, -0.3f, 0);
            GL.Vertex3(0.05f, -0.3f, 0.06f);
            GL.Vertex3(-0.05f, -0.3f, 0.06f);
            GL.End();
         
        }
    }
}
