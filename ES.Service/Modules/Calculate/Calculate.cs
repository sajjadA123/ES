using ES.Core.Contracts.Entities.calculate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Service.Modules.Calculate
{
    public class Calculate
    {
        List<CalculateInput> _lstWalls;
        public Calculate(List<CalculateInput> lstWalls) 
        {
            for (int i = 0; i < lstWalls.Count; i++)
            {
                if (i == 0) lstWalls[i].EnterAngle = 0; else lstWalls[i].EnterAngle = ((ES.Core.Module.Extensions.ConvertRadiansToDegrees(lstWalls[i - 1].ExitAngle1)) % 360);
                if (i == 0) lstWalls[i].Knot1 = 1; else lstWalls[i].Knot1 = lstWalls[i - 1].Knot2;
                for (int commonWalIndex = 0; commonWalIndex < lstWalls.Count; commonWalIndex++)
                {
                    if (commonWalIndex != i)
                    {
                        if ((lstWalls[i].Knot1 == lstWalls[commonWalIndex].Knot2) && (lstWalls[i].Knot2 == lstWalls[commonWalIndex].Knot1))
                        {
                            lstWalls[i].CommonWall = true;
                            break;
                        }
                    }
                }
                if (i == 0) lstWalls[i].WallPoints1 = new WallPoints(0, 0);
                else
                {
                    for (int wallPointIndex = 0; wallPointIndex < lstWalls.Count; wallPointIndex++)
                    {
                        if (lstWalls[i].Knot1 == lstWalls[wallPointIndex].Knot2)
                        {
                            lstWalls[i].WallPoints1 = new WallPoints(lstWalls[wallPointIndex].WallPoints2.X, lstWalls[wallPointIndex].WallPoints2.Y);
                            break;
                        }
                    }
                }
            }
            _lstWalls = lstWalls;
        }
        public CalculateResponse CalcPolygon()
        {
            return new CalculateResponse()
            {
                InnerArea = PolygonAreaInner(),
                InnerPrimeter = polygonPerimeterInner(),
                OutArea = PolygonArea(),
                OutPrimeter = polygonPerimeterOut()
            };
        }

        private double PolygonArea()
        {
            double area = 0;
            foreach(CalculateInput input in _lstWalls)
            {
                area += input.Meter;
            }
            return area;
        }

        private double PolygonAreaInner()
        {
            double area = 0;
            double l=0;
            for(int i=0;i<_lstWalls.Count-1;i++)
            {
                l = Math.Pow((Math.Pow((_lstWalls[i + 1].EnterWallPoint2.Y - _lstWalls[i].EnterWallPoint2.Y), 2) + Math.Pow((_lstWalls[i + 1].EnterWallPoint2.X - _lstWalls[i].EnterWallPoint2.X), 2)), 0.5);
                area += l;
            }
            return area-_lstWalls[0].Tickness;
        }

        private  double polygonPerimeterOut( )
        {
            double[] X=new double[(_lstWalls.Count)+1];
            double[] Y=new double[(_lstWalls.Count)+1];
            int arayIndex=0;
            for (int ind = 0; ind < _lstWalls.Count; ind++)
            {
                X[ind] = _lstWalls[ind].WallPoints1.X;
                Y[ind] = _lstWalls[ind].WallPoints1.Y;
               // X[++arayIndex] = _lstWalls[ind].WallPoints2.X;
               // Y[++arayIndex] = _lstWalls[ind].WallPoints2.Y;
            }
            double area = 0.0;
            int j = _lstWalls.Count-1;
            for (int i = 0; i < _lstWalls.Count; i++)
            {
                area += ( X[j] + X[i]) * (Y[j] - Y[i]);
                j = i;
            }
            return Math.Abs(area / 2.0);
        }
        private double polygonPerimeterInner()
        {
            double[] X = new double[(_lstWalls.Count ) + 1];
            double[] Y = new double[(_lstWalls.Count) + 1];
            int arayIndex = 0;
            for (int ind = 0; ind < _lstWalls.Count; ind++)
            {
                X[ind] = _lstWalls[ind].EnterWallPoint2.X;
                Y[ind] = _lstWalls[ind].EnterWallPoint2.Y;
               // X[++arayIndex] = _lstWalls[ind].EnterWallPoint2.X;
               // Y[++arayIndex] = _lstWalls[ind].EnterWallPoint2.Y;
            }
            double area = 0.0;
            int j = _lstWalls.Count - 1;
            for (int i = 0; i < _lstWalls.Count; i++)
            {
                area += (X[j] + X[i]) * (Y[j] - Y[i]);
                j = i;
            }
            return Math.Abs(area / 2.0);
        }
    }
}
