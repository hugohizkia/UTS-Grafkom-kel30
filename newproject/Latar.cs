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
    internal class Latar
    {
        public Latar()
        {

        }

        List<Asset3d> objectList = new List<Asset3d>();
        Asset3d baling;
        Asset3d baling1;
        Asset3d pintu;
        Asset3d pintu2;

        void gedung()
        {
            pintu = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            pintu2 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            pintu.createBalok2(-0.3f, -0.2f, -0.73f, 0.6f, 1f, 0.05f);
            pintu2.createBalok2(0.3f, -0.2f, -0.73f, 0.6f, 1f, 0.05f);
            objectList.Add(pintu);
            objectList.Add(pintu2);

            var papan = new Asset3d(new Vector3(0.4667f, 0.4667f, 0.4667f));
            papan.createBalok2(1f, -0.705f, -1.4f, 6f, 0.1f, 4f);
            objectList.Add(papan);

            var kiri = new Asset3d(new Vector3(1f, 1f, 1f));
            var kanan = new Asset3d(new Vector3(1f, 1f, 1f));
            var atas = new Asset3d(new Vector3(0f, 0f, 0.2078f));
            var belakang = new Asset3d(new Vector3(0f, 0f, 0.2078f));
            var belakangdlm = new Asset3d(new Vector3(0.949f, 0.8745f, 0.7373f));
            var depankiri = new Asset3d(new Vector3(0f, 0f, 0.2078f));
            var depankanan = new Asset3d(new Vector3(0f, 0f, 0.2078f));
            var depantengah = new Asset3d(new Vector3(0f, 0f, 0.2078f));


            kiri.createBalok2(-1.25f, 0.84f, -1.5f, 0.1f, 3f, 1.5f);
            kanan.createBalok2(1.25f, 0.84f, -1.5f, 0.1f, 3f, 1.5f);
            atas.createBalok2(0.0f, 2.3f, -1.5f, 2.5f, 0.1f, 1.5f);
            belakang.createBalok2(0.0f, 0.84f, -2.2f, 2.5f, 3f, 0.1f);
            belakangdlm.createBalok2(0.0f, 0.84f, -2.1f, 2.5f, 3f, 0.1f);
            depankiri.createBalok2(-0.9f, 0.84f, -0.8f, 0.625f, 3f, 0.1f);
            depankanan.createBalok2(0.9f, 0.84f, -0.8f, 0.625f, 3f, 0.1f);
            depantengah.createBalok2(0f, 1.3f, -0.8f, 1.2f, 2f, 0.1f);

            objectList.Add(kiri);
            objectList.Add(kanan);
            objectList.Add(atas);
            objectList.Add(belakang);
            objectList.Add(belakangdlm);
            objectList.Add(depankiri);
            objectList.Add(depankanan);
            objectList.Add(depantengah);

            var meja = new Asset3d(new Vector3(0.3216f, .20780f, 0.1922f));
            meja.createBalok2(0f, -0.47f, -1.85f, 0.1f, 0.37f, 0.65f);
            var meja1 = new Asset3d(new Vector3(0.3216f, .20780f, 0.1922f));
            meja1.createBalok2(0.6f, -0.47f, -1.4f, 1.3f, 0.37f, 0.25f);
            var sofa = new Asset3d(new Vector3(1f, 0.498f, 0f));
            sofa.createBalok2(-1f, -0.58f, -1.45f, 0.3f, 0.15f, 1f);
            var senderan = new Asset3d(new Vector3(1f, 0.498f, 0f));
            senderan.createBalok2(-1.15f, -0.45f, -1.45f, 0.05f, 0.4f, 1f);

            objectList.Add(meja);
            objectList.Add(meja1);
            objectList.Add(sofa);
            objectList.Add(senderan);

            var tempatheli = new Asset3d(new Vector3(1f, 0.9412f, 0f));
            tempatheli.createTorus(0f, 2.35f, -1.5f, 0.55f, 0.01f, 50, 50);
            objectList.Add(tempatheli);
            var h1 = new Asset3d(new Vector3(1f, 1f, 1f));
            h1.createBalok2(-0.2f, 2.35f, -1.5f, 0.1f, 0.01f, 0.7f);
            objectList.Add(h1);
            var h2 = new Asset3d(new Vector3(1f, 1f, 1f));
            h2.createBalok2(0f, 2.35f, -1.5f, 0.3f, 0.01f, 0.1f);
            objectList.Add(h2);
            var h3 = new Asset3d(new Vector3(1f, 1f, 1f));
            h3.createBalok2(0.2f, 2.35f, -1.5f, 0.1f, 0.01f, 0.7f);
            objectList.Add(h3);


            var p1 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var p2 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var p3 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var p4 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));

            var o1 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var o2 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var o3 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var o4 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));

            var l1 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var l2 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));

            var i1 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));

            var c1 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var c2 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var c3 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));

            var e1 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var e2 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var e3 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));
            var e4 = new Asset3d(new Vector3(1f, 0.9804f, 0.9804f));


            p1.createBalok2(-1f, 1.5f, -0.73f, 0.05f, 0.5f, 0.05f);
            p2.createBalok2(-0.86f, 1.725f, -0.73f, 0.3f, 0.05f, 0.05f);
            p3.createBalok2(-0.86f, 1.5f, -0.73f, 0.3f, 0.05f, 0.05f);
            p4.createBalok2(-0.72f, 1.62f, -0.73f, 0.05f, 0.23f, 0.05f);

            o1.createBalok2(-0.55f, 1.5f, -0.73f, 0.05f, 0.5f, 0.05f);
            o2.createBalok2(-0.3f, 1.5f, -0.73f, 0.05f, 0.5f, 0.05f);
            o3.createBalok2(-0.42f, 1.725f, -0.73f, 0.25f, 0.05f, 0.05f);
            o4.createBalok2(-0.42f, 1.27f, -0.73f, 0.25f, 0.05f, 0.05f);

            l1.createBalok2(-0.11f, 1.5f, -0.73f, 0.05f, 0.5f, 0.05f);
            l2.createBalok2(-0.03f, 1.27f, -0.73f, 0.2f, 0.05f, 0.05f);

            i1.createBalok2(0.25f, 1.5f, -0.73f, 0.06f, 0.5f, 0.05f);

            c1.createBalok2(0.47f, 1.5f, -0.73f, 0.05f, 0.5f, 0.05f);
            c2.createBalok2(0.55f, 1.27f, -0.73f, 0.2f, 0.05f, 0.05f);
            c3.createBalok2(0.55f, 1.72f, -0.73f, 0.2f, 0.05f, 0.05f);

            e1.createBalok2(0.88f, 1.5f, -0.73f, 0.05f, 0.5f, 0.05f);
            e2.createBalok2(1f, 1.27f, -0.73f, 0.2f, 0.05f, 0.05f);
            e3.createBalok2(1f, 1.5f, -0.73f, 0.2f, 0.05f, 0.05f);
            e4.createBalok2(1f, 1.72f, -0.73f, 0.2f, 0.05f, 0.05f);

            objectList.Add(p1);
            objectList.Add(p2);
            objectList.Add(p3);
            objectList.Add(p4);

            objectList.Add(o1);
            objectList.Add(o2);
            objectList.Add(o3);
            objectList.Add(o4);

            objectList.Add(l1);
            objectList.Add(l2);

            objectList.Add(i1);

            objectList.Add(c1);
            objectList.Add(c2);
            objectList.Add(c3);

            objectList.Add(e1);
            objectList.Add(e2);
            objectList.Add(e3);
            objectList.Add(e4);
        }

        void penjara()
        {
            var tembokatas = new Asset3d(new Vector3(1f, 1f, 1f));
            tembokatas.createBalok2(2.3f, 0.54f, -1.5f, 2f, 0.1f, 1.5f);
            objectList.Add(tembokatas);

            var tembokkanan = new Asset3d(new Vector3(1f, 1f, 1f));
            tembokkanan.createBalok2(3.3f, -0.035f, -1.5f, 0.1f, 1.25f, 1.5f);
            objectList.Add(tembokkanan);

            var jeruji1 = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji1.createCylinder(2.5f, -0.07f, -1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji1);

            var jeruji2 = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji2.createCylinder(2.25f, -0.07f, -1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji2);

            var jeruji3 = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji3.createCylinder(2.25f, -0.07f, -1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji3);

            var jeruji4 = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji4.createCylinder(2f, -0.07f, -1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji4);

            var jeruji5 = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji5.createCylinder(1.75f, -0.07f, -1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji5);

            var jeruji6 = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji6.createCylinder(1.5f, -0.07f, -1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji6);

            var jeruji7 = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji7.createCylinder(2.75f, -0.07f, -1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji7);

            var jeruji8 = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji8.createCylinder(3f, -0.07f, -1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji8);
            var jeruji1b = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji1b.createCylinder(2.5f, -0.07f, -2.1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji1b);

            var jeruji2b = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji2b.createCylinder(2.25f, -0.07f, -2.1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji2b);

            var jeruji3b = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji3b.createCylinder(2.25f, -0.07f, -2.1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji3b);

            var jeruji4b = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji4b.createCylinder(2f, -0.07f, -2.1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji4b);

            var jeruji5b = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji5b.createCylinder(1.75f, -0.07f, -2.1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji5b);

            var jeruji6b = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji6b.createCylinder(1.5f, -0.07f, -2.1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji6b);

            var jeruji7b = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji7b.createCylinder(2.75f, -0.07f, -2.1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji7b);

            var jeruji8b = new Asset3d(new Vector3(0.8157f, 0.8235f, 0.8196f));
            jeruji8b.createCylinder(3f, -0.07f, -2.1f, 0.05f, 0.4f, 0.05f, 50, 50);
            objectList.Add(jeruji8b);
        }

        void createHelicopter()
        {
            baling = new Asset3d(new Vector3(1f, 1f, 1f));
            baling1 = new Asset3d(new Vector3(1f, 1f, 1f));
            var tegak = new Asset3d(new Vector3(1f, 1f, 1f));
            var body = new Asset3d(new Vector3(0.5f, 0.5f, 0.5f));
            var kaki1 = new Asset3d(new Vector3(0f, 0f, 0f));
            var kaki2 = new Asset3d(new Vector3(0f, 0f, 0f));
            var ekor = new Asset3d(new Vector3(0.5f, 0.5f, 0.5f));
            var ekor2 = new Asset3d(new Vector3(0.5f, 0.5f, 0.5f));
            var ekor3 = new Asset3d(new Vector3(0.5f, 0.5f, 0.5f));


            baling.createBalok2(0f, 3.4f, 0f, 0.05f, 0.05f, 0.8f); //BALING2 MUTER
            baling1.createBalok2(0f, 3.4f, 0f, 0.8f, 0.05f, 0.05f); 
            tegak.createBalok2(0f, 3.3f, 0f, 0.05f, 0.2f, 0.05f); //BALING2 TEGAK
            body.createEllipsoid(0f, 3.1f, -0.15f, 0.25f, 0.2f, 0.55f, 500, 500); //BADAN HELI
            kaki1.createBalok2(0.2f, 2.85f, -0.2f, 0.05f, 0.05f, 0.8f); //KAKI KIRI
            kaki2.createBalok2(-0.2f, 2.85f, -0.2f, 0.05f, 0.05f, 0.8f); //KAKI KANAN
            ekor.createBalok2(0f, 3.15f, -0.59f, 0.1f, 0.13f, 0.8f);
            ekor2.createBalok2(0f, 3.24f, -0.99f, 0.15f, 0.3f, 0.07f);
            ekor3.createBalok2(0f, 3.24f, -0.99f, 0.7f, 0.05f, 0.1f);

            objectList.Add(baling);
            objectList.Add(baling1);
            objectList.Add(tegak);
            objectList.Add(body);
            objectList.Add(kaki1);
            objectList.Add(kaki2);
            objectList.Add(ekor);
            objectList.Add(ekor2);
            objectList.Add(ekor3);

            
        }

        public void OnLoad(int X, int Y)
        {
            createHelicopter();
            gedung();
            penjara();

            foreach (Asset3d i in objectList)
            {
                i.load(X, Y);
            }


        }

        int hit = 0;
        float d1 = -0.001f;
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
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);
                }
            }

            if (baling != null)
            {
                baling.rotate(new Vector3(0f, 0.0f, 0f), new Vector3(0.0f, 1.0f, 0.0f), 540 * time);
                baling1.rotate(new Vector3(0f, 0.0f, 0f), new Vector3(0.0f, 1.0f, 0.0f), 540 * time);
            }
            
            if (pintu != null)
            {
                pintu.translate(d1, 0f, 0f);
                pintu2.translate(d1 * -1, 0f, 0f);
                hit++;

                if (hit >= 500)
                {
                    d1 = d1 * -1;
                    hit = 0;
                }
            }
        }
    }
}
