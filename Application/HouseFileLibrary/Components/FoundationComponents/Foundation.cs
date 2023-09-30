namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents;
    using System;
    using System.Runtime.InteropServices;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(Basement)), XmlInclude(typeof(Crawlspace)), XmlInclude(typeof(Slab)), XmlInclude(typeof(Walkout))]
    public class Foundation : Component
    {
        [XmlAttribute("isExposedSurface")]
        public bool IsExposedSurface;
        [XmlIgnore]
        public decimal? ExposedSurfacePerimeter;
        [XmlElement("Configuration")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents.Configuration Configuration = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents.Configuration();

        public Foundation()
        {
            base.Label = "Foundation";
        }

        private void GetAreaL1(decimal d1, decimal d2, decimal val_x1, decimal val_x2, out decimal expAGAreaL1, out decimal expBGAreaL1)
        {
            if (val_x1 == val_x2)
            {
                expBGAreaL1 = 0M;
                expAGAreaL1 = 0M;
            }
            else
            {
                decimal num2;
                decimal num5;
                Walkout walkout = (Walkout) this;
                decimal num6 = walkout.Measurements.L1;
                decimal num7 = walkout.Measurements.L3;
                decimal num8 = walkout.Measurements.L4;
                decimal num = d1 * (Math.Min(num7, val_x2) - Math.Min(num7, val_x1));
                decimal num4 = Math.Max(num7, val_x1);
                if (walkout.Measurements.WithSlab)
                {
                    if ((((num6 - num7) - num8) == 0M) || (val_x2 < num7))
                    {
                        num2 = 0M;
                    }
                    else
                    {
                        num5 = Math.Min(val_x2, num6 - num8);
                        num2 = (num4 <= (num6 - num8)) ? ((num5 >= num7) ? (((((d1 * ((num6 - num8) - num4)) / ((num6 - num8) - num7)) + ((d1 * ((num6 - num8) - num5)) / ((num6 - num8) - num7))) / 2M) * (num5 - num4)) : 0M) : 0M;
                    }
                }
                else if (((num6 - num7) == 0M) || (val_x2 < num7))
                {
                    num2 = 0M;
                }
                else
                {
                    num5 = val_x2;
                    num2 = (((d1 - (((d1 - d2) * (num4 - num7)) / (num6 - num7))) + (d1 - (((d1 - d2) * (num5 - num7)) / (num6 - num7)))) / 2M) * (num5 - num4);
                }
                expBGAreaL1 = num + num2;
                expAGAreaL1 = (walkout.Measurements.Height * (val_x2 - val_x1)) - expBGAreaL1;
            }
        }

        private void GetAreaL2(decimal d2, decimal d3, decimal val_x1, decimal val_x2, out decimal expAGAreaL2, out decimal expBGAreaL2)
        {
            decimal num;
            decimal num2;
            Walkout walkout = (Walkout) this;
            decimal num3 = walkout.Measurements.L2;
            if (num3 == 0M)
            {
                num2 = 0M;
                num = num2;
            }
            else
            {
                num = d2 - (((d2 - d3) * val_x1) / num3);
                num2 = d2 - (((d2 - d3) * val_x2) / num3);
            }
            expBGAreaL2 = ((num + num2) / 2M) * (val_x2 - val_x1);
            expAGAreaL2 = (walkout.Measurements.Height * (val_x2 - val_x1)) - expBGAreaL2;
        }

        private decimal GetAvailWalkoutAGAreaNS()
        {
            decimal num7;
            decimal num8;
            decimal num9;
            decimal num10;
            decimal num11;
            decimal num12;
            decimal num13;
            decimal num14;
            Walkout walkout = (Walkout) this;
            decimal num = walkout.Measurements.D1;
            decimal num2 = walkout.Measurements.D2;
            decimal num3 = walkout.Measurements.D3;
            decimal num4 = walkout.Measurements.D4;
            decimal num5 = walkout.Measurements.L1;
            decimal num6 = walkout.Measurements.L2;
            bool hasPonyWall = walkout.Wall.HasPonyWall;
            this.GetAreaL1(num, num2, 0M, num5, out num7, out num8);
            if (hasPonyWall)
            {
                this.GetAreaL1(num, num2, 0M, num5, out num9, out num10);
            }
            else
            {
                this.GetAreaL1(num4, num3, 0M, num5, out num9, out num10);
            }
            if (walkout.Measurements.WithSlab)
            {
                num12 = 0M;
                num11 = num6 * walkout.Measurements.Height;
            }
            else if (hasPonyWall)
            {
                this.GetAreaL2(num2, num2, 0M, num6, out num11, out num12);
            }
            else
            {
                this.GetAreaL2(num2, num3, 0M, num6, out num11, out num12);
            }
            if (hasPonyWall)
            {
                this.GetAreaL2(num, num, 0M, num6, out num13, out num14);
            }
            else
            {
                this.GetAreaL2(num, num4, 0M, num6, out num13, out num14);
            }
            return (((num7 + num9) + num11) + num13);
        }

        private decimal GetAvailWalkoutBGArea()
        {
            decimal num;
            decimal num2;
            decimal num3;
            decimal num4;
            decimal num5;
            decimal num6;
            decimal num7;
            decimal num8;
            Walkout walkout = (Walkout) this;
            decimal num9 = walkout.Measurements.D1;
            decimal num10 = walkout.Measurements.D2;
            decimal num11 = walkout.Measurements.D3;
            decimal num12 = walkout.Measurements.D4;
            decimal num13 = walkout.Measurements.L1;
            decimal num14 = walkout.Measurements.L2;
            bool hasPonyWall = walkout.Wall.HasPonyWall;
            this.GetAreaL1(num9, num10, 0M, num13, out num, out num2);
            if (hasPonyWall)
            {
                this.GetAreaL1(num9, num10, 0M, num13, out num3, out num4);
            }
            else
            {
                this.GetAreaL1(num12, num11, 0M, num13, out num3, out num4);
            }
            if (walkout.Measurements.WithSlab)
            {
                num6 = 0M;
                num5 = num14 * walkout.Measurements.Height;
            }
            else if (hasPonyWall)
            {
                this.GetAreaL2(num10, num10, 0M, num14, out num5, out num6);
            }
            else
            {
                this.GetAreaL2(num10, num11, 0M, num14, out num5, out num6);
            }
            if (hasPonyWall)
            {
                this.GetAreaL2(num9, num9, 0M, num14, out num7, out num8);
            }
            else
            {
                this.GetAreaL2(num9, num12, 0M, num14, out num7, out num8);
            }
            return (((num2 + num4) + num6) + num8);
        }

        private ExteriorSurfaces GetExpAreaSimpleWalkout()
        {
            decimal num;
            decimal num2;
            decimal num3;
            decimal num4;
            decimal num5;
            decimal num6;
            decimal num7;
            decimal num8;
            decimal num10;
            decimal num11;
            decimal num12;
            ExteriorSurfaces surfaces = new ExteriorSurfaces();
            Walkout walkout1 = (Walkout) this;
            decimal num13 = walkout1.Measurements.D1;
            decimal num14 = walkout1.Measurements.D2;
            decimal num15 = walkout1.Measurements.D3;
            decimal num16 = walkout1.Measurements.D4;
            decimal num17 = walkout1.Measurements.D5;
            decimal num18 = walkout1.Measurements.L1;
            decimal num19 = walkout1.Measurements.L4;
            bool hasPonyWall = walkout1.Wall.HasPonyWall;
            bool withSlab = walkout1.Measurements.WithSlab;
            decimal num20 = walkout1.Locations.L1_1.X1;
            decimal num21 = walkout1.Locations.L1_1.X2;
            decimal num22 = walkout1.Locations.L1_2.X1;
            decimal num23 = walkout1.Locations.L1_2.X2;
            decimal num24 = walkout1.Locations.L2_1.X1;
            decimal num25 = walkout1.Locations.L2_1.X2;
            decimal num26 = walkout1.Locations.L2_2.X1;
            decimal num27 = walkout1.Locations.L2_2.X2;
            if (withSlab)
            {
                this.GetAreaL1(num13, num14, Math.Min(num18 - num19, num20), Math.Min(num18 - num19, num21), out num, out num5);
            }
            else
            {
                this.GetAreaL1(num13, num14, num20, num21, out num, out num5);
            }
            decimal num9 = !hasPonyWall ? 0M : (!withSlab ? (num - ((num21 - num20) * num17)) : (num - ((Math.Min(num18 - num19, num21) - Math.Min(num18 - num19, num20)) * num17)));
            num -= num9;
            if (!hasPonyWall)
            {
                if (withSlab)
                {
                    this.GetAreaL1(num16, num15, Math.Min(num18 - num19, num22), Math.Min(num18 - num19, num23), out num2, out num6);
                }
                else
                {
                    this.GetAreaL1(num16, num15, num22, num23, out num2, out num6);
                }
                num10 = 0M;
            }
            else if (withSlab)
            {
                this.GetAreaL1(num13, num14, Math.Min(num18 - num19, num22), Math.Min(num18 - num19, num23), out num2, out num6);
                num10 = num2 - ((Math.Min(num18 - num19, num23) - Math.Min(num18 - num19, num22)) * num17);
            }
            else
            {
                this.GetAreaL1(num13, num14, num22, num23, out num2, out num6);
                num10 = num2 - ((num23 - num22) * num17);
            }
            num2 -= num10;
            if (withSlab)
            {
                num7 = 0M;
                num3 = 0M;
                num11 = 0M;
            }
            else if (hasPonyWall)
            {
                this.GetAreaL2(num14, num14, num24, num25, out num3, out num7);
                num11 = num3 - ((num25 - num24) * num17);
            }
            else
            {
                this.GetAreaL2(num14, num15, num24, num25, out num3, out num7);
                num11 = 0M;
            }
            num3 -= num11;
            if (hasPonyWall)
            {
                this.GetAreaL2(num13, num13, num26, num27, out num4, out num8);
                num12 = num4 - ((num27 - num26) * num17);
            }
            else
            {
                this.GetAreaL2(num13, num16, num26, num27, out num4, out num8);
                num12 = 0M;
            }
            num4 -= num12;
            surfaces.AboveGradeArea = ((num + num2) + num3) + num4;
            surfaces.BelowGradeArea = ((num5 + num6) + num7) + num8;
            surfaces.PonyWallArea = ((num9 + num10) + num11) + num12;
            if (!withSlab)
            {
                surfaces.SlabPerimeter = 0M;
            }
            else
            {
                surfaces.SlabPerimeter = num25 - num24;
                if (num21 > (num18 - num19))
                {
                    surfaces.SlabPerimeter = (num21 <= (num18 - num19)) ? (surfaces.SlabPerimeter + (num21 - (num18 - num19))) : (surfaces.SlabPerimeter + (num21 - num21));
                }
                if (num23 > (num18 - num19))
                {
                    surfaces.SlabPerimeter = (num22 <= (num18 - num19)) ? (surfaces.SlabPerimeter + (num23 - (num18 - num19))) : (surfaces.SlabPerimeter + (num23 - num22));
                }
            }
            return surfaces;
        }

        public ExposedSurfaces GetExtFndPortions()
        {
            ExposedSurfaces surfaces = new ExposedSurfaces();
            if (this.IsExposedSurface)
            {
                decimal num = (this.ExposedSurfacePerimeter == null) ? 0M : this.ExposedSurfacePerimeter.Value;
                if (this is Basement)
                {
                    FoundationWallMeasurements measurements = ((Basement) this).Wall.Measurements;
                    surfaces.ExteriorAboveGroundArea = num * ((measurements.Height - measurements.Depth) - measurements.PonyWallHeight);
                    surfaces.PonyWallArea = num * measurements.PonyWallHeight;
                    surfaces.ExteriorBelowGroundArea = num * measurements.Depth;
                    surfaces.WalkoutPerimeter = 0M;
                    surfaces.ExposedPerimeter = num;
                }
                else if (this is Crawlspace)
                {
                    CrawlspaceWallMeasurements measurements = ((Crawlspace) this).Wall.Measurements;
                    surfaces.ExteriorAboveGroundArea = num * (measurements.Height - measurements.Depth);
                    surfaces.PonyWallArea = 0M;
                    surfaces.ExteriorBelowGroundArea = num * measurements.Depth;
                    surfaces.WalkoutPerimeter = 0M;
                    surfaces.ExposedPerimeter = num;
                }
                else if (this is Slab)
                {
                    surfaces.ExteriorAboveGroundArea = 0M;
                    surfaces.PonyWallArea = 0M;
                    surfaces.ExteriorBelowGroundArea = 0M;
                    surfaces.WalkoutPerimeter = 0M;
                    surfaces.ExposedPerimeter = num;
                }
                else if (this is Walkout)
                {
                    ExteriorSurfaces expAreaSimpleWalkout;
                    Walkout walkout = (Walkout) this;
                    if (walkout.Locations != null)
                    {
                        expAreaSimpleWalkout = this.GetExpAreaSimpleWalkout();
                        surfaces.ExposedPerimeter = ((((((walkout.Locations.L1_1.X2 + walkout.Locations.L1_2.X2) + walkout.Locations.L2_2.X2) + walkout.Locations.L2_1.X2) - walkout.Locations.L1_1.X1) - walkout.Locations.L1_2.X1) - walkout.Locations.L2_2.X1) - walkout.Locations.L2_1.X1;
                    }
                    else
                    {
                        expAreaSimpleWalkout = walkout.ExteriorSurfaces;
                        surfaces.ExposedPerimeter = 0M;
                    }
                    surfaces.ExteriorAboveGroundArea = expAreaSimpleWalkout.AboveGradeArea;
                    surfaces.PonyWallArea = expAreaSimpleWalkout.PonyWallArea;
                    surfaces.ExteriorBelowGroundArea = expAreaSimpleWalkout.BelowGradeArea;
                    surfaces.WalkoutPerimeter = expAreaSimpleWalkout.SlabPerimeter;
                }
            }
            else
            {
                surfaces.PonyWallArea = 0M;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                if (base.HouseFile.House.FoundationAttachments != null)
                {
                    foreach (Attachment attachment in base.HouseFile.House.FoundationAttachments)
                    {
                        if (attachment.Foundation2 != null)
                        {
                            if (attachment.Foundation1.Id == base.Id)
                            {
                                num2 += attachment.Foundation1.AboveGradeArea;
                                num3 += attachment.Foundation1.BelowGradeArea;
                                num4 += attachment.Foundation1.SlabLength;
                                continue;
                            }
                            if (attachment.Foundation2.Id == base.Id)
                            {
                                num2 += attachment.Foundation2.AboveGradeArea;
                                num3 += attachment.Foundation2.BelowGradeArea;
                                num4 += attachment.Foundation2.SlabLength;
                            }
                        }
                    }
                }
                if (this is Basement)
                {
                    FoundationMeasurements measurements = ((Basement) this).Floor.Measurements;
                    num5 = !measurements.IsRectangular ? measurements.Perimeter : (2M * (measurements.Length + measurements.Width));
                    FoundationWallMeasurements measurements4 = ((Basement) this).Wall.Measurements;
                    surfaces.ExteriorAboveGroundArea = (num5 * (measurements4.Height - measurements4.Depth)) - num2;
                    surfaces.ExteriorBelowGroundArea = (num5 * measurements4.Depth) - num3;
                    surfaces.WalkoutPerimeter = 0M;
                    surfaces.ExposedPerimeter = surfaces.ExteriorBelowGroundArea / measurements4.Depth;
                }
                else if (this is Crawlspace)
                {
                    FoundationMeasurements measurements = ((Crawlspace) this).Floor.Measurements;
                    num5 = !measurements.IsRectangular ? measurements.Perimeter : (2M * (measurements.Length + measurements.Width));
                    CrawlspaceWallMeasurements measurements6 = ((Crawlspace) this).Wall.Measurements;
                    surfaces.ExteriorAboveGroundArea = (num5 * measurements6.Height) - num2;
                    surfaces.ExteriorBelowGroundArea = (num5 * measurements6.Depth) - num3;
                    surfaces.WalkoutPerimeter = 0M;
                    surfaces.ExposedPerimeter = surfaces.ExteriorAboveGroundArea / measurements6.Height;
                }
                else if (this is Slab)
                {
                    FoundationMeasurements measurements = ((Slab) this).Floor.Measurements;
                    num5 = !measurements.IsRectangular ? measurements.Perimeter : (2M * (measurements.Length + measurements.Width));
                    surfaces.ExteriorAboveGroundArea = 0M;
                    surfaces.ExteriorBelowGroundArea = 0M;
                    surfaces.WalkoutPerimeter = 0M;
                    surfaces.ExposedPerimeter = num5 - num4;
                }
                else if (this is Walkout)
                {
                    WalkoutMeasurements measurements = ((Walkout) this).Measurements;
                    decimal num6 = 0M;
                    if (measurements.WithSlab)
                    {
                        num6 = (2M * measurements.L4) + measurements.L2;
                    }
                    decimal availWalkoutAGAreaNS = this.GetAvailWalkoutAGAreaNS();
                    if (measurements.WithSlab)
                    {
                        availWalkoutAGAreaNS -= ((Walkout) this).Wall.Measurements.Height * num6;
                    }
                    surfaces.ExteriorAboveGroundArea = availWalkoutAGAreaNS - num2;
                    surfaces.ExteriorBelowGroundArea = this.GetAvailWalkoutBGArea() - num3;
                    surfaces.WalkoutPerimeter = num6 - num4;
                    surfaces.ExposedPerimeter = 0M;
                }
            }
            return surfaces;
        }

        public ExposedSurfaces UpdateSummary()
        {
            ExposedSurfaces extFndPortions = this.GetExtFndPortions();
            extFndPortions.ExteriorAboveGroundArea += extFndPortions.PonyWallArea;
            if(this!=null)
            {
                if (this.GetType().Equals(typeof(Walkout)))
                {
                    extFndPortions.ExteriorAboveGroundArea += extFndPortions.WalkoutPerimeter * ((Walkout)this).Measurements.Height;
                    extFndPortions.InteriorAboveGroundArea = this.GetAvailWalkoutAGAreaNS() - extFndPortions.ExteriorAboveGroundArea;
                    extFndPortions.InteriorBelowGroundArea = this.GetAvailWalkoutBGArea() - extFndPortions.ExteriorBelowGroundArea;
                }

                else if (this != null)
                {
                    decimal length;
                    decimal depth;
                    bool isRectangular = false;
                    decimal height = 0M;
                    decimal width = length = depth = height;
                    if (this is Basement)
                    {
                        isRectangular = ((Basement)this).Floor.Measurements.IsRectangular;
                        width = ((Basement)this).Floor.Measurements.Width;
                        length = ((Basement)this).Floor.Measurements.Length;
                        depth = ((Basement)this).Wall.Measurements.Depth;
                        height = ((Basement)this).Wall.Measurements.Height;
                    }
                    else if (this is Crawlspace)
                    {
                        isRectangular = ((Crawlspace)this).Floor.Measurements.IsRectangular;
                        width = ((Crawlspace)this).Floor.Measurements.Width;
                        length = ((Crawlspace)this).Floor.Measurements.Length;
                        depth = ((Crawlspace)this).Wall.Measurements.Depth;
                        height = ((Crawlspace)this).Wall.Measurements.Height;
                    }
                    else if (this is Slab)
                    {
                        isRectangular = ((Slab)this).Floor.Measurements.IsRectangular;
                        width = ((Slab)this).Floor.Measurements.Width;
                        length = ((Slab)this).Floor.Measurements.Length;
                        depth = new decimal(0x13, 0, 0, false, 1);
                        height = new decimal(0x19, 0, 0, false, 1);
                    }
                    if (isRectangular)
                    {
                        extFndPortions.InteriorAboveGroundArea = (((2M * (length + width)) * (height - depth)) - extFndPortions.ExteriorAboveGroundArea) - extFndPortions.PonyWallArea;
                        extFndPortions.InteriorBelowGroundArea = ((2M * (length + width)) * depth) - extFndPortions.ExteriorBelowGroundArea;
                    }
                    else
                    {
                        extFndPortions.InteriorAboveGroundArea = ((length * (height - depth)) - extFndPortions.ExteriorAboveGroundArea) - extFndPortions.PonyWallArea;
                        extFndPortions.InteriorBelowGroundArea = (length * depth) - extFndPortions.ExteriorBelowGroundArea;
                    }

                }
            }
            if (extFndPortions.InteriorAboveGroundArea < 0M)
            {
                extFndPortions.InteriorAboveGroundArea = 0M;
            }
            if (extFndPortions.InteriorBelowGroundArea < 0M)
            {
                extFndPortions.InteriorBelowGroundArea = 0M;
            }
            extFndPortions.ExteriorAboveGroundArea = decimal.Round(extFndPortions.ExteriorAboveGroundArea, 2);
            extFndPortions.ExteriorBelowGroundArea = decimal.Round(extFndPortions.ExteriorBelowGroundArea, 2);
            extFndPortions.InteriorAboveGroundArea = decimal.Round(extFndPortions.InteriorAboveGroundArea, 2);
            extFndPortions.InteriorBelowGroundArea = decimal.Round(extFndPortions.InteriorBelowGroundArea, 2);
            return extFndPortions;
        }

        [XmlAttribute("exposedSurfacePerimeter")]
        public string ExposedSurfacePerimeterHelper
        {
            get => 
                this.ExposedSurfacePerimeter?.ToString();
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.ExposedSurfacePerimeter = null;
                }
                else
                {
                    decimal num;
                    if (decimal.TryParse(value, out num))
                    {
                        this.ExposedSurfacePerimeter = new decimal?(num);
                    }
                    else
                    {
                        this.ExposedSurfacePerimeter = null;
                    }
                }
            }
        }

        [XmlIgnore]
        public decimal InteriorWallCoreRsiValue
        {
            get
            {
                if ((this.Configuration.Type.Length <= 1) || (!(this is Basement) && !(this is Walkout)))
                {
                    return 0M;
                }
                char ch = this.Configuration.Type.ToUpper()[1];
                return ((ch == 'B') ? 0.417M : ((ch == 'C') ? 0.116M : ((ch == 'W') ? 0.417M : 0.2665M)));
            }
        }

        [XmlIgnore]
        public decimal InteriorWallEffectiveRsiValue
        {
            get
            {
                FoundationWall wall = null;
                if (this is Basement)
                {
                    wall = ((Basement) this).Wall;
                }
                else if (this is Walkout)
                {
                    wall = ((Walkout) this).Wall;
                }
                return ((wall != null) ? wall.Construction.InteriorAddedInsulation.EffectiveRsiValue(this.InteriorWallCoreRsiValue) : 0M);
            }
        }
    }
}

