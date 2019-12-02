﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformApplications
{
    public class ErrorTypes
    {
        public string[] GetErrorCodes = new string[]
        {
            "NP_Top",
            "NP_Middle",
            "NP_Bottom1",
            "NP_Bottom2",
            "NP_Last Page",
            "MP_Top",
            "MP_Middle",
            "MP_Bottom1",
            "MP_Bottom2",
            "MP_Last Page",
            "TP_Top",
            "TP_Middle",
            "TP_Bottom1",
            "TP_Bottom2",
            "TP_Last Page",
            "PJ_S1_Z1",
            "PJ_S1_Z2",
            "PJ_S1_Z3",
            "PJ_S1_Z4",
            "PJ_S1_Z5",
            "PS_S1_Z1",
            "PS_S1_Z2",
            "PS_S1_Z3",
            "PS_S1_Z4",
            "PS_S1_Z5",
            "PJ_S2_Z1",
            "PJ_S2_Z2",
            "PJ_S2_Z3",
            "PJ_S2_Z4",
            "PJ_S2_Z5",
            "PS_S2_Z1",
            "PS_S2_Z2",
            "PS_S2_Z3",
            "PS_S2_Z4",
            "PS_S2_Z5",
            "Paper Sailing",
            "Paper Stuck in Funnel",
            "Bull Dozing",
            "Paper Disorder",
            "Paper Suck Back",
            "Paper not Fully Eject",
            "Paper Curl",
            "Paper Rolled Up",
            "Messy Output",
            "Fallen Sheet",
            "Paper Tear_S1_Left",
            "Paper Tear_S1_Center",
            "Paper Tear_S1_Right",
            "Paper Tear_S2_Left",
            "Paper Tear_S2_Center",
            "Paper Tear_S2_Right",
            "Paper Dent_S1_Left",
            "Paper Dent_S1_Center",
            "Paper Dent_S1_Right",
            "Paper Dent_S2_Left",
            "Paper Dent_S2_Center",
            "Paper Dent_S2_Right",
            "Peeling_S1",
            "Peeling_S2",
            "Vertical Scratch_S1",
            "Vertical Scratch_S2",
            "Horizontal Scratch_S1",
            "Horizontal Scratch_S2",
            "Vertical Folding Line_S1",
            "Vertical Folding Line_S2",
            "Horizontal Folding Line_S1",
            "Horizontal Folding Line_S2",
            "Corner Folding Right_S1",
            "Corner Folding Right_S2",
            "Corner Folding Left_S1",
            "Corner Folding Left_S2",
            "Paper Crumpled",
            "Crease Line_S1",
            "Crease Line_S2",
            "Roller Mark_S1",
            "Roller Mark_S2",
            "Pick Tire Mark",
            "Carriage Smear Minor_S1",
            "Carriage Smear Moderate_S1",
            "Carriage Smear Severe_S1",
            "Carriage Smear Minor_S2",
            "Carriage Smear Moderate_S2",
            "Carriage Smear Severe_S2",
            "Ink Smear Minor_S1",
            "Ink Smear Moderate_S1",
            "Ink Smear Severe_S1",
            "Ink Smear Minor_S2",
            "Ink Smear Moderate_S2",
            "Ink Smear Severe_S2",
            "Back of Page Rib Smear_S1",
            "Back of Page Rib Smear_S2",
            "Ink Transfer_S1",
            "Ink Transfer_S2",
            "Ink Stain_TOF",
            "Ink Stain_BOF",
            "Ink Stain_Minor_S1",
            "Ink Stain_Moderate_S1",
            "Ink Stain_Severe_S1",
            "Ink Stain_Minor_S2",
            "Ink Stain_Moderate_S2",
            "Ink Stain_Severe_S2",
            "Ink Smudge_S1",
            "Ink Smudge_S2",
            "Starwheel Damage_S1",
            "Starwheel Damage_S2",
            "Envelope Dent",
            "Envelope Flap",
            "Carriage Smear",
            "Edge Catch (Left)_S1",
            "Edge Catch (Left)_S2",
            "Edge Catch (Right)_S1",
            "Edge Catch (Right)_S2",
            "Head Strike_S1",
            "Head Strike_S2",
            "Paper Too Long",
            "Paper Too Short",
            "Margin Shift_Up_S1",
            "Margin Shift_Down_S1",
            "Margin Shift_Left_S1",
            "Margin Shift_Right_S1",
            "Margin Shift_Up_S2",
            "Margin Shift_Down_S2",
            "Margin Shift_Left_S2",
            "Margin Shift_Right_S2",
            "Obvious Skew_S1_Top",
            "Obvious Skew_S1_Middle",
            "Obvious Skew_S1_Bottom1",
            "Obvious Skew_S1_Bottom2",
            "Obvious Skew_S2_Top",
            "Obvious Skew_S2_Middle",
            "Obvious Skew_S2_Bottom1",
            "Obvious Skew_S2_Bottom2",
            "TOF_A>B_S1 (TOP)",
            "TOF_B>A_S1 (TOP)",
            "SOF_A>C_S1 (TOP)",
            "SOF_C>A_S1 (TOP)",
            "TOF+SOF_A>B + C>A_S1 (TOP)",
            "TOF+SOF_B>A + A>C_S1 (TOP)",
            "FEED SKEW_C>D_S1 (TOP)",
            "FEED SKEW_D>C_S1 (TOP)",
            "TOF_A>B_S1 (MIDDLE)",
            "TOF_B>A_S1 (MIDDLE)",
            "SOF_A>C_S1 (MIDDLE)",
            "SOF_C>A_S1 (MIDDLE)",
            "TOF+SOF_A>B + C>A_S1 (MIDDLE)",
            "TOF+SOF_B>A + A>C_S1 (MIDDLE)",
            "FEED SKEW_C>D_S1 (MIDDLE)",
            "FEED SKEW_D>C_S1 (MIDDLE)",
            "TOF_A>B_S1 (BOTTOM1)",
            "TOF_B>A_S1 (BOTTOM1)",
            "SOF_A>C_S1 (BOTTOM1)",
            "SOF_C>A_S1 (BOTTOM1)",
            "TOF+SOF_A>B + C>A_S1 (BOTTOM1)",
            "TOF+SOF_B>A + A>C_S1 (BOTTOM1)",
            "FEED SKEW_C>D_S1 (BOTTOM1)",
            "FEED SKEW_D>C_S1 (BOTTOM1)",
            "TOF_A>B_S1 (BOTTOM2)",
            "TOF_B>A_S1 (BOTTOM2)",
            "SOF_A>C_S1 (BOTTOM2)",
            "SOF_C>A_S1 (BOTTOM2)",
            "TOF+SOF_A>B + C>A_S1 (BOTTOM2)",
            "TOF+SOF_B>A + A>C_S1 (BOTTOM2)",
            "FEED SKEW_C>D_S1 (BOTTOM2)",
            "FEED SKEW_D>C_S1 (BOTTOM2)",
            "TOF_A>B_S2 (TOP)",
            "TOF_B>A_S2 (TOP)",
            "SOF_A>C_S2 (TOP)",
            "SOF_C>A_S2 (TOP)",
            "TOF+SOF_A>B + C>A_S2 (TOP)",
            "TOF+SOF_B>A + A>C_S2 (TOP)",
            "FEED SKEW_C>D_S2 (TOP)",
            "FEED SKEW_D>C_S2 (TOP)",
            "TOF_A>B_S2 (MIDDLE)",
            "TOF_B>A_S2 (MIDDLE)",
            "SOF_A>C_S2 (MIDDLE)",
            "SOF_C>A_S2 (MIDDLE)",
            "TOF+SOF_A>B + C>A_S2 (MIDDLE)",
            "TOF+SOF_B>A + A>C_S2 (MIDDLE)",
            "FEED SKEW_C>D_S2 (MIDDLE)",
            "FEED SKEW_D>C_S2 (MIDDLE)",
            "TOF_A>B_S2 (BOTTOM1)",
            "TOF_B>A_S2 (BOTTOM1)",
            "SOF_A>C_S2 (BOTTOM1)",
            "SOF_C>A_S2 (BOTTOM1)",
            "TOF+SOF_A>B + C>A_S2 (BOTTOM1)",
            "TOF+SOF_B>A + A>C_S2 (BOTTOM1)",
            "FEED SKEW_C>D_S2 (BOTTOM1)",
            "FEED SKEW_D>C_S2 (BOTTOM1)",
            "TOF_A>B_S2 (BOTTOM2)",
            "TOF_B>A_S2 (BOTTOM2)",
            "SOF_A>C_S2 (BOTTOM2)",
            "SOF_C>A_S2 (BOTTOM2)",
            "TOF+SOF_A>B + C>A_S2 (BOTTOM2)",
            "TOF+SOF_B>A + A>C_S2 (BOTTOM2)",
            "FEED SKEW_C>D_S2 (BOTTOM2)",
            "FEED SKEW_D>C_S2 (BOTTOM2)",
            "Blank Page Eject - Low Speed",
            "Blank Page Eject - High Speed",
            "Carriage Stall_S1_Left",
            "Carriage Stall_S1_Center",
            "Carriage Stall_S1_Right",
            "Carriage Stall_S2_Left",
            "Carriage Stall_S2_Center",
            "Carriage Stall_S2_Right",
            "PHA Issue",
            "Ink Supply Failure",
            "FW Assert (FWA)",
            "General Printer Error (GPE)",
            "Printer Hang",
            "False Paper Jam",
            "False Out of Paper",
            "Abnormal Noise",
            "Error Page (Corrupted Printout)",
            "Print on Platen - No Pick",
            "Print on Platen - Paper Stall before pinchroller",
            "Incompleted Printout",
            "Vertical Color Line S1",
            "Vertical Color Line S2",
            "Auto Shut Down",
            "Fail To Detect Pen",
            "Hands Off",
            "Start/Stop Defect",
            "Others",
            "Plunge Through",
            "Horizontal Banding_S1",
            "Horizontal Banding_S2",
            "Vertical Banding_S1",
            "Vertical Banding_S2",
            "Light SBB_S1",
            "Light SBB_S2",
            "Dark SBB_S1",
            "Dark SBB_S2",
            "Pen Starvation_S1",
            "Pen Starvation_S2",
            "Ink Drops_S1",
            "Ink Drops_S2",
            "Ink Redeposit_S1",
            "Ink Redeposit_S2",
            "Ink Mixing_S1",
            "Ink Mixing_S2",
            "Massive Nozzle Out_S1",
            "Massive Nozzle Out_S2",
            "Nozzle Out_Minor_S1",
            "Nozzle Out_Moderate_S1",
            "Nozzle Out_Severe_S1",
            "Nozzle Out_Minor_S2",
            "Nozzle Out_Moderate_S2",
            "Nozzle Out_Severe_S2",
            "Misaligned Print_S1",
            "Misaligned Print_S2",
            "Bidi Misalignment_S1",
            "Bidi Misalignment_S2",
            "Worms PQ_S1",
            "Worms PQ_S2",
            "MOFTE_S1",
            "MOFTE_S2",
            "BOFTE_S1",
            "BOFTE_S2",
            "SEPTE_S1",
            "SEPTE_S2",
            "Hue Shift_S1",
            "Hue Shift_S2",
            "Bleeding_S1",
            "Bleeding_S2",
            "Mottling_S1",
            "Mottling_S2",
            "Fuzzy Text_S1",
            "Fuzzy Text_S2",
            "Corrupted Print",
            "Unexpected Print",
            "Start of Swath",
            "Blurred Print",
            "Color Missing",
            "Wrong Color",
            "Half Die Color Missing",
            "Ghost Army",
            "Missing Print",
            "TOF Misprint",
            "BOF Misprint",
            "Aerosol Overspray",
            "Color Fringement_S1",
            "Color Fringement_S2",
            "Random Character",
            "Missing Bottom Line_S1",
            "Missing Bottom Line_S2",
            "Faded Guideline_S1",
            "Faded Guideline_S2",
            "Faded Horizontal Short Line_S1",
            "Faded Horizontal Short Line_S2",
            "Abnormal Decap_S1",
            "Abnormal Decap_S2",
            "EC 71023B",
            "FWA 0x1bc39595",
            "FWA 0xb84ae702",
            "FWA 0x01259595",
            "EC 7102ED"
        };
    }
}