using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//aqui hacemos el codigo del didujo
namespace TV
{
   public class TV: GameWindow

    {

        public TV(int WIDTH , int HEIGHT, string mititulo): base(WIDTH, HEIGHT, GraphicsMode.Default, mititulo)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

       
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {

            GL.ClearColor(Color4.White);
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Begin(PrimitiveType.Lines);

            //PARTE DELANTERA
            GL.Color4(Color.Black);
            //lineas horizontales
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0.5, 0, 0);

            GL.Vertex3(0, 0.4, 0);
            GL.Vertex3(0.5, 0.4, 0);

            //lineas verticales
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0.4, 0);

            GL.Vertex3(0.5, 0, 0);
            GL.Vertex3(0.5, 0.4, 0);

            //tubo vertical 
            GL.Vertex3(0.22, 0, 0);
            GL.Vertex3(0.22, -0.05, 0);

            GL.Vertex3(0.26, 0, 0);
            GL.Vertex3(0.26, -0.05, 0);

            //soporte 
            GL.Vertex3(0.12, -0.05, 0);
            GL.Vertex3(0.36, -0.05, 0);

            GL.Vertex3(0.12, -0.06, 0);
            GL.Vertex3(0.36, -0.06, 0);

            GL.Vertex3(0.12, -0.05, 0);
            GL.Vertex3(0.12, -0.06, 0);

            GL.Vertex3(0.36, -0.05, 0);
            GL.Vertex3(0.36, -0.06, 0);

            //pantalla
            //lineas verticales
            GL.Vertex3(0.02, 0.03, 0);
            GL.Vertex3(0.02, 0.37, 0);

            GL.Vertex3(0.48, 0.03, 0);
            GL.Vertex3(0.48, 0.37, 0);

            //lineas horizontales
            GL.Vertex3(0.02, 0.03, 0);
            GL.Vertex3(0.48, 0.03, 0);

            GL.Vertex3(0.02, 0.37, 0);
            GL.Vertex3(0.48, 0.37, 0);

            //PARTE TRASERA
            //lineas horizontales
            GL.Vertex3(0, 0, -0.02);
            GL.Vertex3(0.5, 0, -0.02);

            GL.Vertex3(0, 0.4, -0.02);
            GL.Vertex3(0.5, 0.4, -0.02);

            //lineas verticales
            GL.Vertex3(0, 0, -0.02);
            GL.Vertex3(0, 0.4, -0.02);

            GL.Vertex3(0.5, 0, -0.02);
            GL.Vertex3(0.5, 0.4, -0.02);

            //tubo vertical 
            GL.Vertex3(0.22, 0, -0.02);
            GL.Vertex3(0.22, -0.05, -0.02);

            GL.Vertex3(0.26, 0, -0.02);
            GL.Vertex3(0.26, -0.05, -0.02);

            //soporte 
            GL.Vertex3(0.12, -0.05, -0.02);
            GL.Vertex3(0.36, -0.05, -0.02);

            GL.Vertex3(0.12, -0.06, -0.02);
            GL.Vertex3(0.36, -0.06, -0.02);

            GL.Vertex3(0.12, -0.05, -0.02);
            GL.Vertex3(0.12, -0.06, -0.02);

            GL.Vertex3(0.36, -0.05, -0.02);
            GL.Vertex3(0.36, -0.06, -0.02);


            //UNIENDO PARTE DELANTERA CON TRASERA 
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, -0.02);

            GL.Vertex3(0, 0.4, 0);
            GL.Vertex3(0, 0.4, -0.02);

            GL.Vertex3(0.05, 0, 0);
            GL.Vertex3(0.05, 0, -0.02);

            GL.Vertex3(0.5, 0.4, 0);
            GL.Vertex3(0.5, 0.4, -0.02);

            //soporte 
            GL.Vertex3(0.12, -0.05, -0.02);
            GL.Vertex3(0.12, -0.05, 0);

            GL.Vertex3(0.12, -0.06, 0);
            GL.Vertex3(0.12, -0.06, -0.02);

            GL.Vertex3(0.36, -0.05, 0);
            GL.Vertex3(0.36, -0.05, -0.02);

            GL.Vertex3(0.36, -0.06, 0);
            GL.Vertex3(0.36, -0.06, -0.02);

            GL.End();

        

        Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Rotate(1.0f, 0.0f, 0.1f, 0.0f);
            base.OnUpdateFrame(e);
        }


    }
}
