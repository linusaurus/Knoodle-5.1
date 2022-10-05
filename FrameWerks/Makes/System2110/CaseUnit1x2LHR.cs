#region Copyright (c) 2019 WeaselWare Software
/************************************************************************************
'
' Copyright  2019 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2019 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using FrameWorks;


namespace FrameWorks.Makes.System2110
{

    public class CaseUnit1x2LHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal frameReduce2X = 0.875m * 2.0m;
        const decimal gstopReduce2X = 1.59375m * 2.0m;
        const decimal screenReduce2X = 1.512m * 2.0m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal glassReduce2X = 1.9375m * 2.0m;
        const decimal gaskSashReduce = 1.9667m;
        const decimal edgeSealAdd = 0.375m;
        const decimal muntinReduce2X = 2.46875m * 2.0m;

        //static int createID;

        #endregion

        #region Constructor

        public CaseUnit1x2LHR()
        {
           
            this.ModelID = "System2110-CaseUnit1x2LHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            ComponentPart ComponentPart;
            string ComponentPartleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            #region Frame

            //////////////////////////////////////////////////////////////////////////////        

            // JmbAlumL <--
            ComponentPart = new ComponentPart(4347, "JmbAluml", this, 1, m_subAssemblyHieght);
            ComponentPart.ComponentGroupType = "Frame";
            ComponentPart.ComponentLabel = "1)MiterEnds";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // JmbAlumR -->
            ComponentPart = new ComponentPart(4347, "JmbAlumR", this, 1, m_subAssemblyHieght);
            ComponentPart.ComponentGroupType = "Frame";
            ComponentPart.ComponentLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + FrameWorks.Functions.TieBarLockCenter(this.SubAssemblyHieght);
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            ComponentPart = new ComponentPart(4347, "HeadAlum", this, 1, m_subAssemblyWidth);
            ComponentPart.ComponentGroupType = "Frame";
            ComponentPart.ComponentLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:1741";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // SillAlum ||
            ComponentPart = new ComponentPart(4347, "SillAlum", this, 1, m_subAssemblyWidth);
            ComponentPart.ComponentGroupType = "Frame";
            ComponentPart.ComponentLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:1741";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmVertL <--
            ComponentPart = new ComponentPart(4430, "ScrnFrmVertL", this, 1, m_subAssemblyHieght - screenReduce2X);
            ComponentPart.ComponentGroupType = "Screen";
            ComponentPart.ComponentLabel = "1)MiterEnds";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmVertR -->
            ComponentPart = new ComponentPart(4430, "ScrnFrmVertR", this, 1, m_subAssemblyHieght - screenReduce2X);
            ComponentPart.ComponentGroupType = "Screen";
            ComponentPart.ComponentLabel = "1)MiterEnds";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmHorzT ^^
            ComponentPart = new ComponentPart(4430, "ScrnFrmHorzT", this, 1, m_subAssemblyWidth - screenReduce2X);
            ComponentPart.ComponentGroupType = "Screen";
            ComponentPart.ComponentLabel = "1)MiterEnds";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrmHorzB ||
            ComponentPart = new ComponentPart(4430, "ScrnFrmHorzB", this, 1, m_subAssemblyWidth - screenReduce2X);
            ComponentPart.ComponentGroupType = "Screen";
            ComponentPart.ComponentLabel = "1)MiterEnds";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame

            //////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            ComponentPart = new ComponentPart(3206, "AglBrktAlum", this, 8, aluminumCrnBrk);
            ComponentPart.ComponentGroupType = "AssyHrdwrFrame";
            ComponentPart.ComponentLabel = "Angle_1.5";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            ComponentPart = new ComponentPart(1545, "PointSetScrew", this, 32, 0.0m);
            ComponentPart.ComponentGroupType = "AssyHrdwrFrame";
            ComponentPart.ComponentLabel = "1/4x20x.375";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // ScreenAssyBrace
            ComponentPart = new ComponentPart(1118, "ScreenAssyBrace", this, 4, 0.0m);
            ComponentPart.ComponentGroupType = "AssyHrdwrFrame";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // CupPoint
            ComponentPart = new ComponentPart(1537, "CupPoint", this, 8, 0.0m);
            ComponentPart.ComponentGroupType = "AssyHrdwrFrame";
            ComponentPart.ComponentLabel = "#8-32x3/16";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Handle

            //////////////////////////////////////////////////////////////////////////////

            // LongHandle
            ComponentPart = new ComponentPart(6919, "LongHandle", this, 1, 0.0m);
            ComponentPart.ComponentGroupType = "Handle";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            // HandleFolding
            //ComponentPart = new ComponentPart(2268, "HandleFolding", this, 1, 0.0m);
            //ComponentPart.ComponentGroupType = "Handle";
            //ComponentPart.ComponentLabel = "";
            //m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion B

            #region Hardware

            //////////////////////////////////////////////////////////////////////////////

            // Operator23SeriesRH
            ComponentPart = new ComponentPart(FrameWorks.Functions.OperatorSeries23(SubAssemblyWidth, "RH"), "OperatorRH", this, 1, 0.0m);
            ComponentPart.ComponentGroupType = "Hardware";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // Gasket23
            ComponentPart = new ComponentPart(2652, "Gasket23", this, 1, 0.0m);
            ComponentPart.ComponentGroupType = "Hardware";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // OperatorBacker
            //ComponentPart = new ComponentPart(5253, "OperatorBacker", this, 1, 0.0m);
            //ComponentPart.ComponentGroupType = "Hardware";
            //ComponentPart.ComponentLabel = "";
            //m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 51.9999m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;
            }

            // Truth24LockingHandle
            ComponentPart = new ComponentPart(6916, "Truth24LockingHandle", this, hardwarecount, 0m);
            ComponentPart.ComponentGroupType = "Hardware";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // Keeper
            ComponentPart = new ComponentPart(3516, "Keeper", this, hardwarecount, 0m);
            ComponentPart.ComponentGroupType = "Hardware";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            //Get the size of the tiebar ComponentPartNo--
            decimal tieBarLength = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);
            //check is sash even requires a tiebar
            if (tieBarLength != 0)
            {
                // Tie Bars
                ComponentPart = new ComponentPart(3625, "Tie Bars", this, 1, tieBarLength);
                ComponentPart.ComponentGroupType = "Hardware";
                ComponentPart.ComponentLabel = "";
                m_componentParts.Add(ComponentPart);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //FrameSeal
            decimal periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
            for (int i = 0; i < 1; i++)
            {
                periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);
                ComponentPart = new ComponentPart(2274, "FrameSeal", this, 1, periFrame);
                ComponentPart.ComponentGroupType = "Seal";
                ComponentPart.ComponentLabel = "";
                m_componentParts.Add(ComponentPart);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region Sash

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumR -->
            ComponentPart = new ComponentPart(5710, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            ComponentPart.ComponentGroupType = "Sash";
            ComponentPart.ComponentLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // StileAlumL <--
            ComponentPart = new ComponentPart(5710, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            ComponentPart.ComponentGroupType = "Sash";
            ComponentPart.ComponentLabel = labelStileL = "MiterEnds";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumT ^^
            ComponentPart = new ComponentPart(5710, "RailAlumT", this, 1, m_subAssemblyWidth - frameReduce2X);
            ComponentPart.ComponentGroupType = "Sash";
            ComponentPart.ComponentLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Right";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // RailAlumB ||
            ComponentPart = new ComponentPart(5710, "RailAlumB", this, 1, m_subAssemblyWidth - frameReduce2X);
            ComponentPart.ComponentGroupType = "Sash";
            ComponentPart.ComponentLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Right";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopL <--
            ComponentPart = new ComponentPart(5711, "AlumGlsStopL", this, 1, m_subAssemblyHieght - gstopReduce2X);
            ComponentPart.ComponentGroupType = "StopAlum";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopR -->
            ComponentPart = new ComponentPart(5711, "AlumGlsStopR", this, 1, m_subAssemblyHieght - gstopReduce2X);
            ComponentPart.ComponentGroupType = "StopAlum";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopT ^^
            ComponentPart = new ComponentPart(5711, "AlumGlsStopT", this, 1, m_subAssemblyWidth - gstopReduce2X);
            ComponentPart.ComponentGroupType = "StopAlum";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStopB ||
            ComponentPart = new ComponentPart(5711, "AlumGlsStopB", this, 1, m_subAssemblyWidth - gstopReduce2X);
            ComponentPart.ComponentGroupType = "StopAlum";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MuntinBars

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            ComponentPart = new ComponentPart(6924, "MuntinBarsInt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            ComponentPart.ComponentGroupType = "MuntinBars";
            ComponentPart.ComponentLabel = "Horz";
            ComponentPart.ComponentWidth = 1.0m;
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // MuntinBars
            ComponentPart = new ComponentPart(3736, "MuntinBarsExt", this, 1, m_subAssemblyWidth - muntinReduce2X);
            ComponentPart.ComponentGroupType = "MuntinBars";
            ComponentPart.ComponentLabel = "Horz";
            ComponentPart.ComponentWidth = 1.0m;
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrSash

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            ComponentPart = new ComponentPart(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
            ComponentPart.ComponentGroupType = "AssyHrdwrSash";
            ComponentPart.ComponentLabel = "Yellow";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // FlatHead
            ComponentPart = new ComponentPart(502, "FlatHead", this, 16, 0.0m);
            ComponentPart.ComponentGroupType = "AssyHrdwrSash";
            ComponentPart.ComponentLabel = "#8-32x3/16_UndercutHead";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            ComponentPart = new ComponentPart(2931, "AglBrktAlum", this, 4, 0.0m);
            ComponentPart.ComponentGroupType = "AssyHrdwrSash";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            ComponentPart = new ComponentPart(5190, "PointSetScrew", this, 16, 0.0m);
            ComponentPart.ComponentGroupType = "AssyHrdwrSash";
            ComponentPart.ComponentLabel = "1/4_20x1/4";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware

            //////////////////////////////////////////////////////////////////////////////

            // HingeCaseUL
            ComponentPart = new ComponentPart(996, "HingeCaseUL", this, 1, 0.0m);
            ComponentPart.ComponentGroupType = "Hardware";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // HingeCaseLL
            ComponentPart = new ComponentPart(995, "HingeCaseLL", this, 1, 0.0m);
            ComponentPart.ComponentGroupType = "Hardware";
            ComponentPart.ComponentLabel = "";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            // HingeSpacer
            for (int i = 0; i < 2; i++)
            {
                ComponentPart = new ComponentPart(219, "HingeSpacer", this, 1, 0.0m);
                ComponentPart.ComponentGroupType = "Hardware";
                ComponentPart.ComponentThick = 0.2819m;
                ComponentPart.ComponentWidth = 0.75m;
                ComponentPart.ComponentLength = 7.75m;
                ComponentPart.ComponentLabel = "";
                m_componentParts.Add(ComponentPart);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            // Glass
            ComponentPart = new ComponentPart(6883);
            ComponentPart.FunctionalName = "Glass";
            ComponentPart.ComponentGroupType = "Glass";
            ComponentPart.Qnty = 1;
            ComponentPart.ContainerAssembly = this;
            ComponentPart.ComponentWidth = (m_subAssemblyWidth - glassReduce2X);
            ComponentPart.ComponentLength = (m_subAssemblyHieght - glassReduce2X);
            ComponentPart.ComponentThick = 1.25m;
            ComponentPart.ComponentLabel = "1x2_SDL";
            m_componentParts.Add(ComponentPart);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            //SashEdgeSeal
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, m_subAssemblyWidth - edgeSealAdd);
                ComponentPart = new ComponentPart(2274, "SashEdgeSeal", this, 1, periSash);
                ComponentPart.ComponentGroupType = "Seal";
                ComponentPart.ComponentLabel = "";
                m_componentParts.Add(ComponentPart);
            }

            //////////////////////////////////////////////////////////////////////////////

            //EPDM_PreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                ComponentPart = new ComponentPart(5713, "EPDM_PreSet", this, 1, peri);
                ComponentPart.ComponentGroupType = "Seal";
                ComponentPart.ComponentLabel = "";
                m_componentParts.Add(ComponentPart);
            }

            //////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);
                ComponentPart = new ComponentPart(5714, "EPDM_Wedge", this, 1, peri);
                ComponentPart.ComponentGroupType = "Seal";
                ComponentPart.ComponentLabel = "";
                m_componentParts.Add(ComponentPart);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}