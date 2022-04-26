using System.Collections.Generic;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Windowing.Desktop;
using System;
using OpenTK.Mathematics;
using LearnOpenTK.Common;

namespace newproject
{
    internal class Karakter
    {
        public Karakter()
        {

        }

        List<Asset3d> objectList = new List<Asset3d>();
        Asset3d tangan;
        Asset3d tangan1;
        Asset3d muka;
        Asset3d matakiri;
        Asset3d matakanan;
        Asset3d topi;
        Asset3d topi2;
        public void OnLoad(int X, int Y)
        {
            muka = new Asset3d(new Vector3(1f, 0.9725f, 0.1686f));
            var kepala = new Asset3d(new Vector3(1f, 0.9725f, 0.1686f));
            var penutupatas = new Asset3d(new Vector3(1f, 0.9725f, 0.1686f));
            var penutupbawah = new Asset3d(new Vector3(1f, 0.9725f, 0.1686f));
            matakiri = new Asset3d(new Vector3(0, 0, 0));
            matakanan = new Asset3d(new Vector3(0, 0, 0));
            var leher = new Asset3d(new Vector3(1f, 0.9725f, 0.1686f));
            var badan = new Asset3d(new Vector3(0f, 0.8431f, 0.9471f));
            var kakikiri = new Asset3d(new Vector3(0f, 0f, 0.502f));
            var kakikiri1 = new Asset3d(new Vector3(0f, 0f, 0.502f));
            var kakikiri2 = new Asset3d(new Vector3(0f, 0f, 0.502f));
            var kakikanan = new Asset3d(new Vector3(0f, 0f, 0.502f));
            var kakikanan1 = new Asset3d(new Vector3(0f, 0f, 0.502f));
            var kakikanan2 = new Asset3d(new Vector3(0f, 0f, 0.502f));
            var antarakaki = new Asset3d(new Vector3(0f, 0f, 0.502f));

            topi = new Asset3d(new Vector3(0f, 0f, 0f));
            topi2 = new Asset3d(new Vector3(0f, 0f, 0f));

            var dasi = new Asset3d(new Vector3(0f, 0f, 0f));
            var kantong1 = new Asset3d(new Vector3(0.5922f, 0.3843f, 0.0863f));
            var kantong2 = new Asset3d(new Vector3(0.5922f, 0.3843f, 0.0863f));
            var sabuk = new Asset3d(new Vector3(0.5922f, 0.3843f, 0.0863f));
            var sabuk2 = new Asset3d(new Vector3(1f, 0.8431f, 0f));

            tangan = new Asset3d(new Vector3(0f, 0.8431f, 0.9471f));
            tangan1 = new Asset3d(new Vector3(0f, 0.8431f, 0.9471f));

            topi.createEllipsoid(0f, 0.08f, 0f, 0.1f, 0.1f, 0.1f, 50, 50);
            topi2.createEllipsoid(0f, 0.086f, 0.056f, 0.1f, 0.015f, 0.1f,50,50);


            matakiri.createEllipsoid(-0.04f, 0.03f, 0.09f, 0.02f, 0.02f, 0.02f, 50, 50);
            matakanan.createEllipsoid(0.04f, 0.03f, 0.09f, 0.02f, 0.02f, 0.02f, 50, 50);
            kepala.createTorus(0f, 0.09f, 0f, 0.05f, 0.03f, 50, 50);
            penutupatas.createEllipsoid(0f, 0.07f, 0f, 0.1f, 0.01f, 0.1f, 50, 50);
            penutupbawah.createEllipsoid(0f, -0.07f, 0f, 0.1f, 0.01f, 0.1f, 50, 50);
            muka.createCylinder(0f, 0f, 0f, 0.1f, 0.05f, 0.1f, 500, 500);
            leher.createCylinder(0f, -0.07f, 0f, 0.05f, 0.025f, 0.06f, 500, 500);
            badan.createBalok(0f, -0.24f, 0f, 0.25f, 0.27f);

            tangan.createBalok(-0.166f, -0.27f, 0f, 0.08f, 0.3f);
            tangan1.createBalok(0.166f, -0.27f, 0f, 0.08f, 0.3f);

            dasi.createBalok2(0f, -0.21f, 0.11f, 0.05f, 0.2f, 0.05f);
            kantong1.createBalok2(0.13f, -0.4f, 0.07f, 0.05f, 0.07f, 0.05f);
            kantong2.createBalok2(-0.13f, -0.4f, 0.065f, 0.05f, 0.07f, 0.05f);
            sabuk2.createBalok2(0f, -0.4f, 0.11f, 0.07f, 0.07f, 0.05f);


            sabuk.createBalok(0f, -0.38f, 0f, 0.24f, 0.05f);
            kakikiri.createBalok(-0.07f, -0.53f, 0.08f, 0.08f, 0.25f);
            kakikiri1.createBalok(-0.07f, -0.53f, 0f, 0.08f, 0.25f);
            kakikiri2.createBalok(-0.07f, -0.53f, -0.08f, 0.08f, 0.25f);

            kakikanan.createBalok(0.07f, -0.53f, 0.08f, 0.08f, 0.25f);
            kakikanan1.createBalok(0.07f, -0.53f, 0f, 0.08f, 0.25f);
            kakikanan2.createBalok(0.07f, -0.53f, -0.08f, 0.08f, 0.25f);

            antarakaki.createBalok(0f, -0.435f, 0f, 0.06f, 0.24f);
            antarakaki.rotate(new Vector3(0f, -0.435f, 0f), new Vector3(1.0f, 0.0f, 0.0f), 90);

            objectList.Add(matakiri);
            objectList.Add(matakanan);
            objectList.Add(penutupatas);
            objectList.Add(penutupbawah);
            objectList.Add(muka);
            //objectList.Add(kepala);
            objectList.Add(leher);
            objectList.Add(badan);
            objectList.Add(kakikiri);
            objectList.Add(kakikiri1);
            objectList.Add(kakikiri2);
            objectList.Add(kakikanan);
            objectList.Add(kakikanan1);
            objectList.Add(kakikanan2);
            objectList.Add(antarakaki);
            objectList.Add(tangan);
            objectList.Add(tangan1);


            objectList.Add(topi);
            objectList.Add(topi2);

            objectList.Add(kantong1);
            objectList.Add(kantong2);
            objectList.Add(dasi);
            objectList.Add(sabuk);
            objectList.Add(sabuk2);

            

            foreach (Asset3d i in objectList)
            {
                i.load(X, Y);
            }
        }

        int ctr = 0;
        int ctr1 = 0;
        float dx1 = -15f;
        int ctr2 = 0;
        float dx2 = -15f;
        
        public void OnRenderFrame(FrameEventArgs args, Camera camera, KeyboardState keyboardState)
        {
            float time = (float)args.Time;

            foreach (Asset3d i in objectList)
            {
                //Console.WriteLine(Vector3.UnitZ);
                i.render(camera.GetViewMatrix(), camera.GetProjectionMatrix());
                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);



                foreach (Asset3d j in i.child)
                {
                    //j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);
                    
                }
            }

            if (matakiri != null)
            {

                matakiri.rotate(new Vector3(0f, 0.0f, 0f), new Vector3(0.0f, 1.0f, 0.0f), dx1 * time);
                matakanan.rotate(new Vector3(0f, 0.0f, 0f), new Vector3(0.0f, 1.0f, 0.0f), dx1 * time);

                
                topi.rotate(new Vector3(0f, 0.0f, 0f), new Vector3(0.0f, 1.0f, 0.0f), dx1 * time);
                topi2.rotate(new Vector3(0f, 0.0f, 0f), new Vector3(0.0f, 1.0f, 0.0f), dx1 * time);
                ctr1++;
                ctr++;
                if(ctr == 900)
                {
                    dx1 = dx1 * -1;
                    ctr1 = 0;
                }
                else if (ctr != 900)
                {
                    if (ctr1 >= 1800)
                    {
                        dx1 = dx1 * -1;
                        ctr1 = 0;
                    }
                }  
            }


            if (tangan != null)
            {
                //tangan.createBalok(-0.166f, -0.27f, 0f, 0.08f, 0.3f);
                //tangan1.createBalok(0.166f, -0.27f, 0f, 0.08f, 0.3f);

                tangan.rotate(new Vector3(0f, -0.14f, 0f), new Vector3(1.0f, 0.0f, 0.0f), dx2 * time);
                tangan1.rotate(new Vector3(0f, -0.14f, 0f), new Vector3(1.0f, 0.0f, 0.0f), dx2 * time);
                ctr2++;

                if (ctr2 >= 1200)
                {
                    dx2 = dx2 * -1;
                    ctr2 = 0;
                }
            }
        }
    }
}
