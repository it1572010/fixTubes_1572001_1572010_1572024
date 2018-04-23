using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace fixTubes_1572001_1572010
{
    public class ListPeluru
    {
        public List<Peluru> listP { get; set; }
        Matrix4 model, model2, model3, modelView, view, model4;
        public float tempbebas = 0, angle=0;
        Vector3 peluruKiri;
        public ListPeluru()
        {
            listP = new List<Peluru>();
            peluruKiri = new Vector3(-0.07f, -0.85f, 0);
        }
        public void addPeluru()
        {
            //move(0.1f);
            listP.Add(new Peluru());

        }
        public void move(float x)
        {
            Matrix4 projection, view;
            projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, 600 / 600, 0.1f, 100);
            view = Matrix4.LookAt(
                new Vector3(0, 0, 3),
                new Vector3(0, 0, 0),
                new Vector3(0, 1, 0));
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            model = Matrix4.CreateTranslation(peluruKiri);
            tempbebas += 0.1f;
           // model2 = Matrix4.CreateRotationY(angle);
            model3 = Matrix4.CreateScale(0.2f);
            model4 = Matrix4.CreateTranslation(new Vector3(x, tempbebas, 0));
            modelView = Matrix4.Mult(view, model);
         //   modelView = Matrix4.Mult(model2, modelView);
            modelView = Matrix4.Mult(model3, modelView);
            modelView = Matrix4.Mult(model4, modelView);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);
            if (tempbebas > 10f)
            {
                listP.RemoveAt(0);
                tempbebas = 0;
            }
            
        }
    }
}
