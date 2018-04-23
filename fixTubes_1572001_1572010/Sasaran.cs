using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing;

namespace fixTubes_1572001_1572010
{
    public class Sasaran
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        Matrix4 model, model2, model3, modelView, view, model4;
        float angle2 = 0;
        public Sasaran(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
            Animasi();
            createSasaran();
        }
        public void createSasaran()
        {
            GL.Begin(PrimitiveType.Quads);

            //depan
            GL.Color3(Color.Red);
            GL.Vertex3(new Vector3(-0.2f, 0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, 0.2f, 0.2f));

            //belakang
            GL.Color3(Color.Orange);
            GL.Vertex3(new Vector3(0.2f, 0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, 0.2f, -0.2f));

            //kiri
            GL.Color3(Color.Green);
            GL.Vertex3(new Vector3(-0.2f, 0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, 0.2f, 0.2f));

            //kanan
            GL.Color3(Color.Blue);
            GL.Vertex3(new Vector3(0.2f, 0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, 0.2f, -0.2f));

            //atas
            GL.Color3(Color.Purple);
            GL.Vertex3(new Vector3(-0.2f, 0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, 0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, 0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, 0.2f, -0.2f));

            //bawah
            GL.Color3(Color.Yellow);
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));

            GL.End();
        }
        public void Animasi()
        {
            Matrix4 projection, view;
            projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, 600 / 600, 0.1f, 100);
            view = Matrix4.LookAt(
                new Vector3(0, 0, 3),
                new Vector3(0, 0, 0),
                new Vector3(0, 1, 0));
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            model = Matrix4.CreateTranslation(new Vector3(X, Y, Z));
            model2 = Matrix4.CreateScale(0.2f);
            //angle2 += 1f;
            model3 = Matrix4.CreateRotationY(angle2);
            modelView = Matrix4.Mult(view, model);
            modelView = Matrix4.Mult(model3, modelView);
            modelView = Matrix4.Mult(model2, modelView);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);
        }

    }
}
