using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Core.Contracts.Entities.calculate
{
    public class WallPoints
    {
        private double _x, _y;
        public WallPoints(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public double X
        {
            get { return Math.Round(_x,1); }
            set
            {
                _x =Math.Round( value,1);
            }
        }
        public double Y
        {
            get { return Math.Round(_y,1); }
            set { _y =Math.Round( value,1); }
        }
    }
    public class CalculateInput : StrongEntityDTO
    {

        public double Meter { get; set; }//Input From User
        public double Angle { get; set; }//Input From User
        public double Tickness { get; set; }//Input From User
        public bool EndKnot { get; set; }//Input From User


        public double EnterAngle { get; set; }//declare in Runtime
        public double EnterAngleRound { get { return Math.Round(EnterAngle, 1); } }
        public bool CommonWall { get; set; }//declare in Runtime
        public  WallPoints WallPoints1 { get; set; }//declare in Runtime
        public  WallPoints WallPoints2
        {
            get
            {
                double x=Math.Round( WallPoints1.X+(Meter*Math.Cos(ExitAngle1Round)),0);
                double y= Math.Round( WallPoints1.Y+(Meter*Math.Sin(ExitAngle1Round)),0);
                return new WallPoints(x,y);   
            }
        }
        public double AngleRadian { get { return ES.Core.Module.Extensions.ToRadians(Angle); } }
        public double AngleRadianRound { get { return Math.Round(AngleRadian, 1); } }
        public double EnterAngleRadian { get { return ES.Core.Module.Extensions.ToRadians(EnterAngle); } }
        public double EnterAngleRadianRound { get { return Math.Round(EnterAngleRadian, 1); } }
        public double ExitAngle1 { get { return (EnterAngleRadian + ES.Core.Module.Extensions.ToRadians(180)- AngleRadian); } }
        public double ExitAngle1Round { get { return Math.Round(ExitAngle1, 1); } }
        public double ExitAngle2 { get { return EnterAngleRadian + ES.Core.Module.Extensions.ToRadians(180) - (AngleRadian / 2); } }
        public double ExitAngle2Round { get { return Math.Round(ExitAngle2, 1); } }
        public int Knot1 { get; set; }//declare in Runtime
        public int Knot2 { get { return EndKnot ? Knot1 : Knot1 + 1; } }

        public double SinAngleRadianTickness { get { return Tickness / Math.Sin(AngleRadian / 2); } }
        public double SinAngleRadianTicknessRound { get { return Math.Round(SinAngleRadianTickness, 1); } }
        public double TanAngleRadianTickness { get { return Tickness / Math.Tan(AngleRadian / 2); } }
        public double TanAngleRadianTicknessRound { get { return Math.Round(TanAngleRadianTickness, 1); } }
        public WallPoints EnterWallPoint1
        {
            get
            {
                double x = (SinAngleRadianTicknessRound * Math.Round( Math.Cos(ExitAngle2Round),1));
                double y = (SinAngleRadianTicknessRound * Math.Round(Math.Sin(ExitAngle2Round),1));
                return new WallPoints(x, y);
            }
        }
        public WallPoints EnterWallPoint2
        {
            get
            {
                double x = WallPoints1.X + EnterWallPoint1.X;
                double y =  WallPoints1.Y + EnterWallPoint1.Y;
                return new WallPoints(x, y);
            }
        }
    }
    public class CalculateInputSearch : BaseSearch
    {

    }
}
