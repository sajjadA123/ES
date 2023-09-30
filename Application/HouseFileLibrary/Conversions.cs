namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Runtime.InteropServices;

    public static class Conversions
    {
        public static decimal AnnualFuelUtilizationEfficiency2SteadyStateEfficiency(ushort energySource, ushort equipmentType, ushort furnaceOrBoiler, decimal value)
        {
            decimal num2 = Math.Max(Math.Min(value, 100.0M), 0.0M);
            decimal num3 = num2;
            if ((energySource > 1) && (energySource < 5))
            {
                energySource = (ushort) (energySource - 2);
                equipmentType = (ushort) (equipmentType - 1);
                equipmentType = Math.Max(Math.Min(equipmentType,(ushort) 5), (ushort)0);
                furnaceOrBoiler = Math.Max(Math.Min(furnaceOrBoiler, (ushort)1), (ushort)0);
                decimal num = GetSteadyStateConstant(energySource, equipmentType, furnaceOrBoiler, 1);
                num2 = (GetSteadyStateConstant(energySource, equipmentType, furnaceOrBoiler, 0) * num2) + num;
                if (num2 < num3)
                {
                    num2 = num3;
                }
                num2 = Math.Max(Math.Min(num2, 100.0M), 0.0M);
            }
            return num2;
        }

        public static decimal BritishThermalUnitPerHourToKiloWatts(decimal btuhr) => 
            ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.I_2_M, btuhr);

        public static decimal CelciusToFahrenheit(decimal degreesCelcius) => 
            ConvertUnits(eConversionType.UNIT_C_2_F, eUnitType.M_2_I, degreesCelcius);

        public static double CentiCubicFeetToCubicMetersOfNaturalGas(double ccf) => 
            (ccf * 26.8392) / 9.47817;

        public static double CentiCubicFeetToGigaJoulesOfNaturalGas(double ccf) => 
            ccf / 9.47817;

        public static decimal CoefficientOfPerformance2HeatingSeasonalPerformanceFactor(decimal value)
        {
            decimal num = new decimal(0x178, 0, 0, false, 3);
            decimal num2 = new decimal(780, 0, 0, false, 3);
            return Math.Max(Math.Min((decimal) ((Math.Max(Math.Min(value, 20.0M), 0.3M) - num2) / num), (decimal) 20.0M), 0.3M);
        }

        public static decimal CoefficientOfPerformance2SeasonalEnergyEfficiencyRatio(decimal value)
        {
            decimal num = new decimal(0x73, 0, 0, false, 3);
            decimal num2 = new decimal(0x594, 0, 0, false, 3);
            return Math.Max(Math.Min((decimal) ((Math.Max(Math.Min(value, 30.0M), 0.3M) - num2) / num), (decimal) 30.0M), 0.3M);
        }

        public static decimal ConvertUnits(eConversionType type, eUnitType units, decimal value)
        {
            decimal num = value * ((decimal) GetFactor(type, units));
            if (type == eConversionType.UNIT_C_2_F)
            {
                if ((units == eUnitType.M_2_I) || (units == eUnitType.M_2_U))
                {
                    num = (value * 1.8M) + 32M;
                }
                else if ((units == eUnitType.U_2_M) || (units == eUnitType.I_2_M))
                {
                    num = (value - 32M) / 1.8M;
                }
            }
            return num;
        }

        public static double ConvertUnits(eConversionType type, eUnitType units, double value)
        {
            double num = value * GetFactor(type, units);
            if (type == eConversionType.UNIT_C_2_F)
            {
                if ((units == eUnitType.M_2_I) || (units == eUnitType.M_2_U))
                {
                    num = (value * 1.8) + 32.0;
                }
                else if ((units == eUnitType.U_2_M) || (units == eUnitType.I_2_M))
                {
                    num = (value - 32.0) / 1.8;
                }
            }
            return num;
        }

        public static int ConvertUnits(eConversionType type, eUnitType units, int value) => 
            (int) ConvertUnits(type, units, (double) value);

        public static double CordsToGigaJoulesOfWood(double cord) => 
            cord / 0.04167;

        public static double CordsToTonneOfWood(double cord) => 
            cord * 1.71955;

        public static double CubicMetersToGigaJoulesOfNaturalGas(double m3) => 
            m3 / 26.8392;

        public static decimal FahrenheitToCelcius(decimal degreesFahrenheit) => 
            ConvertUnits(eConversionType.UNIT_C_2_F, eUnitType.I_2_M, degreesFahrenheit);

        public static double GallonsImperialToGigaJoulesOfOil(double gal) => 
            gal / 5.70991;

        public static double GallonsImperialToGigaJoulesOfPropane(double gal) => 
            gal / 8.59254;

        public static double GallonsImperialToLitre(double gal) => 
            gal * 4.54609;

        public static double GallonsUSToGigaJoulesOfOil(double gal) => 
            gal / 6.85735;

        public static double GallonsUSToGigaJoulesOfPropane(double gal) => 
            gal / 10.3192;

        public static double GallonsUSToLitre(double gal) => 
            gal * 3.785412;

        public static eUnitType GetEUnitType(unit_classes currentUnits, unit_classes desiredUnits)
        {
            switch (desiredUnits)
            {
                case unit_classes.METRIC_UNITS:
                    return ((currentUnits == unit_classes.US_UNITS) ? eUnitType.U_2_M : eUnitType.I_2_M);

                case unit_classes.IMP_UNITS:
                    return ((currentUnits == unit_classes.METRIC_UNITS) ? eUnitType.M_2_I : eUnitType.U_2_I);

                case unit_classes.US_UNITS:
                    return ((currentUnits == unit_classes.METRIC_UNITS) ? eUnitType.M_2_U : eUnitType.I_2_U);
            }
            return eUnitType.M_2_U;
        }

        public static double GetFactor(eConversionType type, eUnitType units)
        {
            switch (units)
            {
                case eUnitType.M_2_I:
                case eUnitType.M_2_U:
                    switch (type)
                    {
                        case eConversionType.UNIT_RSI_2_R:
                            return 5.678263;

                        case eConversionType.UNIT_MM_2_IN:
                            return 0.03937008;

                        case eConversionType.UNIT_RSIMM_2_RIN:
                            return 144.228;

                        case eConversionType.UNIT_M_2_FT:
                            return 3.28084;

                        case eConversionType.UNIT_M2_2_FT2:
                            return 10.76391;

                        case eConversionType.UNIT_M3_2_FT3:
                            return 35.31467;

                        case eConversionType.UNIT_CM2_2_IN2:
                            return 0.155;

                        case eConversionType.UNIT_W_2_BTUHR:
                            return 3.412141;

                        case eConversionType.UNIT_KW_2_BTUHR:
                            return 3412.141;

                        case eConversionType.UNIT_MJDAY_2_BTUHR:
                            return 39.4924;

                        case eConversionType.UNIT_MJM2DAY_2_BTUFT2HR:
                            return 3.66892;

                        case eConversionType.UNIT_L_2_GAL:
                            return ((units == eUnitType.M_2_I) ? 0.2199692 : 0.264172);

                        case eConversionType.UNIT_LSEC_2_CFM:
                            return 2.11888;

                        case eConversionType.UNIT_C_2_F:
                            return 1.8;

                        case eConversionType.UNIT_KWH_2_MBTU:
                            return 0.0034121999999999998;

                        case eConversionType.UNIT_GJ_2_MBTU:
                            return 0.947817;

                        case eConversionType.UNIT_MJ_2_BTU:
                            return 947.817;

                        case eConversionType.UNIT_PERCC_2_PERCF:
                            return 0.55555555555555558;

                        case eConversionType.UNIT_KGS_2_LBMMIN:
                            return 132.3;

                        case eConversionType.UNIT_LS_2_GPM:
                            return ((units == eUnitType.M_2_I) ? 13.19815 : 15.85032);

                        case eConversionType.UNIT_WC_2_BTUHRF:
                            return 0.52798310454065478;

                        case eConversionType.UNIT_MCF_2_M3:
                            return 0.03531;

                        case eConversionType.UNIT_KGPM3_2_LBMPFT3:
                            return 0.062427960841;

                        case eConversionType.UNIT_KJPKGC_2_BTUPLBMF:
                            return 0.2388459;

                        case eConversionType.UNIT_UVALUE:
                            return 0.17611019426187197;

                        default:
                            break;
                    }
                    break;

                case eUnitType.I_2_M:
                case eUnitType.U_2_M:
                    switch (type)
                    {
                        case eConversionType.UNIT_RSI_2_R:
                            return 0.17611019426187197;

                        case eConversionType.UNIT_MM_2_IN:
                            return 25.4;

                        case eConversionType.UNIT_RSIMM_2_RIN:
                            return 0.00693347;

                        case eConversionType.UNIT_M_2_FT:
                            return 0.30479999024640031;

                        case eConversionType.UNIT_M2_2_FT2:
                            return 0.09290304;

                        case eConversionType.UNIT_M3_2_FT3:
                            return 0.028316847;

                        case eConversionType.UNIT_CM2_2_IN2:
                            return 6.4516;

                        case eConversionType.UNIT_W_2_BTUHR:
                            return 0.29307112455200413;

                        case eConversionType.UNIT_KW_2_BTUHR:
                            return 0.00029307112455200413;

                        case eConversionType.UNIT_MJDAY_2_BTUHR:
                            return 0.0253213;

                        case eConversionType.UNIT_MJM2DAY_2_BTUFT2HR:
                            return 0.272557;

                        case eConversionType.UNIT_L_2_GAL:
                            return ((units == eUnitType.I_2_M) ? 4.54609 : 3.785412);

                        case eConversionType.UNIT_LSEC_2_CFM:
                            return 0.47194744393264371;

                        case eConversionType.UNIT_C_2_F:
                            return 0.555556;

                        case eConversionType.UNIT_KWH_2_MBTU:
                            return 293.06605708926793;

                        case eConversionType.UNIT_GJ_2_MBTU:
                            return 1.055056;

                        case eConversionType.UNIT_MJ_2_BTU:
                            return 0.001055056;

                        case eConversionType.UNIT_PERCC_2_PERCF:
                            return 1.8;

                        case eConversionType.UNIT_KGS_2_LBMMIN:
                            return 0.0075585789871504151;

                        case eConversionType.UNIT_LS_2_GPM:
                            return (1.0 / ((units == eUnitType.I_2_M) ? 13.19815 : 15.85032));

                        case eConversionType.UNIT_WC_2_BTUHRF:
                            return 1.894;

                        case eConversionType.UNIT_MCF_2_M3:
                            return 28.316847;

                        case eConversionType.UNIT_KGPM3_2_LBMPFT3:
                            return 16.018463306;

                        case eConversionType.UNIT_KJPKGC_2_BTUPLBMF:
                            return 4.1868;

                        case eConversionType.UNIT_UVALUE:
                            return 5.678263;

                        default:
                            break;
                    }
                    break;

                case eUnitType.I_2_U:
                    return (((type == eConversionType.UNIT_L_2_GAL) || (type == eConversionType.UNIT_LS_2_GPM)) ? 1.20095 : 1.0);

                case eUnitType.U_2_I:
                    return (((type == eConversionType.UNIT_L_2_GAL) || (type == eConversionType.UNIT_LS_2_GPM)) ? 0.832674132978059 : 1.0);

                default:
                    break;
            }
            return 0.0;
        }

        private static decimal GetSteadyStateConstant(ushort energySource, ushort equipmentType, ushort furnaceOrBoiler, ushort constantIndex)
        {
            decimal[,,,] decimalArray1 = new decimal[,,,] { { { { 1.000M, 0.0M }, { 0.758M, 21.00M } }, { { 0.548M, 38.31M }, { 0.863M, 12.07M } }, { { 1.000M, 0.0M }, { 1.000M, 0.0M } }, { { 0.548M, 38.31M }, { 0.863M, 12.07M } }, { { 0.703M, 29.63M }, { 0.863M, 12.07M } }, { { 1.000M, 0.0M }, { 1.000M, 0.0M } } }, { { { 0.402M, 50.77M }, { 0.866M, 12.46M } }, { { 0.402M, 50.77M }, { 1.000M, 0.0M } }, { { 1.000M, 0.0M }, { 0.402M, 50.77M } }, { { 0.402M, 50.77M }, { 0.402M, 50.77M } }, { { 0.402M, 50.77M }, { 0.402M, 50.77M } }, { { 0.402M, 50.77M }, { 1.000M, 0.0M } } }, { { { 1.000M, 0.0M }, { 0.732M, 23.16M } }, { { 0.547M, 38.43M }, { 0.870M, 11.51M } }, { { 1.000M, 0.0M }, { 1.000M, 0.0M } }, { { 0.547M, 38.43M }, { 0.870M, 11.51M } }, { { 0.719M, 28.26M }, { 0.870M, 11.51M } }, { { 1.000M, 0.0M }, { 1.000M, 0.0M } } } };
            return decimalArray1[energySource, equipmentType, furnaceOrBoiler, constantIndex];
        }

        public static double GigaJoulesToCubicMetersOfNaturalGas(double gJ) => 
            gJ * 26.8392;

        public static double GigaJoulesToGallonsImperialOfOil(double gJ) => 
            gJ * 5.709918;

        public static double GigaJoulesToGallonsImperialOfPropane(double gJ) => 
            gJ * 8.592549;

        public static double GigaJoulesToGallonsUSOfOil(double gJ) => 
            gJ * 6.857325;

        public static double GigaJoulesToGallonsUSOfPropane(double gJ) => 
            gJ * 10.31922;

        public static decimal GigaJoulesToKiloWattHours(decimal gJ) => 
            gJ * 277.778M;

        public static double GigaJoulesToKiloWattHours(double gJ) => 
            (double) GigaJoulesToKiloWattHours((decimal) gJ);

        public static double GigaJoulesToLitresOfOil(double gJ) => 
            gJ * 25.9578;

        public static double GigaJoulesToLitresOfPropane(double gJ) => 
            gJ * 39.0625;

        public static double GigaJoulesToThousandCubicFeetOfNaturalGas(double gJ) => 
            gJ * 0.947817;

        public static double GigaJoulesToTonneOfWood(double gJ, short energySource = 5, bool heating = true)
        {
            double num = gJ * 0.0716538;
            if (heating)
            {
                switch (energySource)
                {
                    case 6:
                        num *= 0.786785;
                        break;

                    case 7:
                        num *= 1.29787;
                        break;

                    case 8:
                        num *= 0.704848;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (energySource)
                {
                    case 8:
                        num *= 0.786785;
                        break;

                    case 9:
                        num *= 1.29787;
                        break;

                    case 10:
                        num *= 0.704848;
                        break;

                    default:
                        break;
                }
            }
            return num;
        }

        public static decimal GreenHouseEmissionFactor(DhwEnergySources energySource) => 
            (energySource != DhwEnergySources.Oil) ? ((energySource != DhwEnergySources.Propane) ? 0.00035826M : 0.001547859M) : 0.002762888M;

        public static decimal HeatingSeasonalPerformanceFactor2CoefficientOfPerformance(decimal value)
        {
            decimal num = new decimal(780, 0, 0, false, 3);
            return Math.Max(Math.Min((decimal) ((0.376M * Math.Max(Math.Min(value, 20.0M), 0.3M)) + num), (decimal) 20.0M), 0.3M);
        }

        public static decimal KiloWattHoursToGigaJoules(decimal kWHr) => 
            kWHr / 277.778M;

        public static double KiloWattHoursToGigaJoules(double kWHr) => 
            (double) KiloWattHoursToGigaJoules((decimal) kWHr);

        public static decimal KiloWattsToBritishThermalUnitPerHour(decimal kw) => 
            ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.M_2_I, kw);

        public static double LitresToGallonsImperial(double l) => 
            l / 4.54609;

        public static double LitresToGallonsUS(double l) => 
            l / 3.785412;

        public static double LitresToGigaJoulesOfOil(double l) => 
            l / 25.9578;

        public static double LitresToGigaJoulesOfPropane(double l) => 
            l / 39.0625;

        public static double MegaJoulesToGigaJoules(double mJ) => 
            mJ / 1000.0;

        public static decimal RSItoR(decimal rsi) => 
            ConvertUnits(eConversionType.UNIT_RSI_2_R, eUnitType.M_2_U, rsi);

        public static double RSItoR(double rsi) => 
            (double) RSItoR((decimal) rsi);

        public static decimal RtoRSI(decimal r) => 
            ConvertUnits(eConversionType.UNIT_RSI_2_R, eUnitType.U_2_M, r);

        public static double RtoRSI(double r) => 
            (double) RtoRSI((decimal) r);

        public static decimal SeasonalEnergyEfficiencyRatio2CoefficentOfPerformance(decimal value)
        {
            decimal num = Math.Max(Math.Min(value, 30.0M), 0.3M);
            decimal num2 = new decimal(0x594, 0, 0, false, 3);
            return Math.Max(Math.Min((decimal) ((0.115M * num) + num2), (decimal) 30.0M), 0.3M);
        }

        public static double SquareCentimetersToSquareMeters(double cm2) => 
            cm2 * 0.0001;

        public static decimal SquareFeetToSquareMeters(decimal f2) => 
            ConvertUnits(eConversionType.UNIT_M2_2_FT2, eUnitType.I_2_M, f2);

        public static double SquareFeetToSquareMeters(double f2) => 
            (double) SquareFeetToSquareMeters((decimal) f2);

        public static double SquareMetersToSquareCentimeters(double m2) => 
            m2 * 10000.0;

        public static decimal SquareMetersToSquareFeet(decimal m2) => 
            ConvertUnits(eConversionType.UNIT_M2_2_FT2, eUnitType.M_2_I, m2);

        public static double SquareMetersToSquareFeet(double m2) => 
            (double) SquareMetersToSquareFeet((decimal) m2);

        public static decimal SteadyStateEfficiency2AnnualFuelUtilizationEfficiency(ushort energySource, ushort equipmentType, ushort furnaceOrBoiler, decimal value)
        {
            decimal num3 = Math.Max(Math.Min(value, 100.0M), 0.0M);
            decimal num4 = num3;
            if ((energySource > 1) && (energySource < 5))
            {
                energySource = (ushort) (energySource - 2);
                equipmentType = (ushort) (equipmentType - 1);
                equipmentType = Math.Max(Math.Min(equipmentType, (ushort)5), (ushort)0);
                furnaceOrBoiler = Math.Max(Math.Min(furnaceOrBoiler, (ushort)1), (ushort)0);
                decimal num = GetSteadyStateConstant(energySource, equipmentType, furnaceOrBoiler, 0);
                num3 = (num3 - GetSteadyStateConstant(energySource, equipmentType, furnaceOrBoiler, 1)) / num;
                if (num3 > num4)
                {
                    num3 = num4;
                }
                num3 = Math.Max(Math.Min(num3, 100.0M), 0.0M);
            }
            return num3;
        }

        public static double ThousandCubicFeetToCubicMetersOfNaturalGas(double mcf) => 
            (mcf * 26.8392) / 0.947817;

        public static double ThousandCubicFeetToGigaJoulesOfNaturalGas(double mcf) => 
            mcf / 0.947817;

        public static double TonneToGigaJoulesOfWood(double t, short energySource = 5, bool heating = true)
        {
            double num = t / 0.0716538;
            if (heating)
            {
                switch (energySource)
                {
                    case 6:
                        num /= 0.786785;
                        break;

                    case 7:
                        num /= 1.29787;
                        break;

                    case 8:
                        num /= 0.704848;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (energySource)
                {
                    case 8:
                        num /= 0.786785;
                        break;

                    case 9:
                        num /= 1.29787;
                        break;

                    case 10:
                        num /= 0.704848;
                        break;

                    default:
                        break;
                }
            }
            return num;
        }

        public static double TonneToTonOfWood(double ton) => 
            ton / 0.90719;

        public static double TonToGigaJoulesOfWood(double ton) => 
            ton / 0.0789846;

        public static double TonToTonneOfWood(double ton) => 
            ton * 0.90719;

        public static double WattsToMegaJoulesPerDay(double w) => 
            w * 86.4;
    }
}

