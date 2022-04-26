﻿using System.Collections.Generic;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Windowing.Desktop;
using System;
using OpenTK.Mathematics;
using LearnOpenTK.Common;

namespace newproject
{
    internal class Karakter3
    {
        public Karakter3()
        {

        }

        List<Asset3d> objectList = new List<Asset3d>();
        double _time;
        Asset3d lenganL;
        Asset3d lenganR;

        public void OnLoad(int X, int Y)
        {
            var badan = new Asset3d(new Vector3(1f, 0f, 0f));
            var muka = new Asset3d(new Vector3(0.98f, 0.694f, 0.6549f));
            var rambut = new Asset3d(new Vector3(0.3922f, 0.2667f, 0.2118f));
            var hidung = new Asset3d(new Vector3(0.8588f, 0.2588f, 0.18039f));
            var mataL = new Asset3d(new Vector3(0.0f, 0.0f, 0.0f));
            var mataR = new Asset3d(new Vector3(0.0f, 0.0f, 0.0f));
            var bibir = new Asset3d(new Vector3(0.0f, 0.0f, 0.0f));
            var kakiL = new Asset3d(new Vector3(0.0549f, 0.2901f, 0.9294f));
            var kakiR = new Asset3d(new Vector3(0.0549f, 0.2901f, 0.9294f));
            var sepatuL = new Asset3d(new Vector3(0.0f, 0.0f, 0.0f));
            var sepatuR = new Asset3d(new Vector3(0.0f, 0.0f, 0.0f));
            lenganL = new Asset3d(new Vector3(0.0549f, 0.2901f, 0.9294f));
            lenganR = new Asset3d(new Vector3(0.0549f, 0.2901f, 0.9294f));
            var pundakL = new Asset3d(new Vector3(0.0549f, 0.2901f, 0.9294f));
            var pundakR = new Asset3d(new Vector3(0.0549f, 0.2901f, 0.9294f));
            var tanganL = new Asset3d(new Vector3(0.98f, 0.694f, 0.6549f));
            var tanganR = new Asset3d(new Vector3(0.98f, 0.694f, 0.6549f));




            pundakL.createMuka(0.04f, 0.04f, 0.04f, -0.215f, -0.298f, -0.5f, 72, 24);
            pundakR.createMuka(0.04f, 0.04f, 0.04f, 0.215f, -0.298f, -0.5f, 72, 24);
            tanganL.createMuka(0.04f, 0.04f, 0.04f, -0.215f, -0.68f, -0.5f, 72, 24);
            tanganR.createMuka(0.04f, 0.04f, 0.04f, 0.215f, -0.68f, -0.5f, 72, 24);
            lenganL.createLeg(0.04f, 0.04f, 0.4f, -0.215f, -0.5f, -0.5f);
            lenganR.createLeg(0.04f, 0.04f, 0.4f, 0.215f, -0.5f, -0.5f);
            sepatuL.createBalok(-0.1f, -1.25f, -0.5f, 0.15f, 0.07f);
            sepatuR.createBalok(0.1f, -1.25f, -0.5f, 0.15f, 0.07f);
            kakiL.createLeg(0.06f, 0.06f, 0.5f, -0.1f, -1f, -0.5f);
            kakiR.createLeg(0.06f, 0.06f, 0.5f, 0.1f, -1f, -0.5f);
            badan.createBalok(0.0f, -0.5f, -0.5f, 0.35f, 0.5f);
            muka.createMuka(0.25f, 0.25f, 0.25f, 0, 0, -0.5f, 72, 24);
            rambut.createRambut(0.27f, 0.27f, 0.27f, 0, 0.05f, -0.5f, 72, 24);
            mataL.createMata(0.045f, 0.02f, 0.03f, -0.09f, 0.01f, -0.28f, 72, 24);
            mataR.createMata(0.045f, 0.02f, 0.03f, 0.09f, 0.01f, -0.28f, 72, 24);
            hidung.createHidung(0.03f, 0.05f, 0.03f, 0, -0.05f, -0.25f, 72, 24);
            bibir.createMata(0.15f, 0.01f, 0.07f, 0.0f, -0.12f, -0.34f, 72, 24);

            badan.scale2(0.5f);
            rambut.scale2(0.5f);
            muka.scale2(0.5f);
            hidung.scale2(0.5f);
            mataL.scale2(0.5f);
            mataR.scale2(0.5f);
            bibir.scale2(0.5f);
            kakiL.scale2(0.5f);
            kakiR.scale2(0.5f);
            sepatuL.scale2(0.5f);
            sepatuR.scale2(0.5f);
            lenganL.scale2(0.5f);
            lenganR.scale2(0.5f);
            pundakL.scale2(0.5f);
            pundakR.scale2(0.5f);
            tanganL.scale2(0.5f);
            tanganR.scale2(0.5f);

            objectList.Add(badan);
            objectList.Add(rambut);
            objectList.Add(muka);
            objectList.Add(hidung);
            objectList.Add(mataL);
            objectList.Add(mataR);
            objectList.Add(bibir);
            objectList.Add(kakiL);
            objectList.Add(kakiR);
            objectList.Add(sepatuL);
            objectList.Add(sepatuR);
            objectList.Add(lenganL);
            objectList.Add(lenganR);
            objectList.Add(pundakL);
            objectList.Add(pundakR);
            objectList.Add(tanganL);
            objectList.Add(tanganR);


            foreach (Asset3d i in objectList)
            {
                i.load(X, Y);
            }


        }

        //int ctr2 = 0;
        //float dx2 = -15f;

        public void OnRenderFrame(FrameEventArgs args, Camera camera, KeyboardState keyboardState)
        {
            float time = (float)args.Time;

            foreach (Asset3d i in objectList)
            {
                i.render(camera.GetViewMatrix(), camera.GetProjectionMatrix());
                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);
                }
            }
            foreach (Asset3d i in objectList)
            {
                i.resetEuler();
                //i.rotate(Vector3.Zero, Vector3.UnitZ, 45 * time);
                foreach (Asset3d j in i.child)
                {
                    j.rotate(Vector3.Zero, Vector3.UnitY, 720 * time);
                }
            }


            /*if (lenganL != null)
            {
                lenganL.rotate(new Vector3(-0.166f, -0.14f, 0f), new Vector3(1.0f, 0.0f, 0.0f), dx2 * time);
                lenganR.rotate(new Vector3(-0.166f, -0.14f, 0f), new Vector3(1.0f, 0.0f, 0.0f), dx2 * time);
                ctr2++;

                if (ctr2 >= 1700)
                {
                    dx2 = dx2 * -1;
                    ctr2 = 0;
                }*/
            //}
        }
    }
}
