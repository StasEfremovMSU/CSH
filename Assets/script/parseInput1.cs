using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class parseInput1 {

	public static string[]  s;

	public static void ChangeData () {
		string d = input.get_data();
		// Два места замены
		//s[2] = Change (s[2], 11, d);
		//s[3] = Change (s[3], 10, d);
		s[2] = "ydate_ini='"+ d + "',";
		s[3] = "ydate_bd='"+ d + "',";
	}

	public static void ChangePath  () {
		s[69] = "yin_cat='" + input.path_to_input + "', ";
		s[70] = "ylm_cat='" + input.path_to_input + "', ";
	}


	public static void ChangePower  () {
		s[9] = "nprocx=" + input.power1 + ", nprocy=" + input.power2  + ",";
	}

	static string Change (string file, int i, string mynew) {
		for (int j = i; j < (i + mynew.Length); j++) {
			int t = j - i ;
			file.ToCharArray()[j] = mynew.ToCharArray() [t];
		}
		return file;
	}

	public static void ini ()
	{
		s = new string[90];

		s[1]= "&CONTRL";
		s[2] = "ydate_ini='2019012400',";
		s[3] = "ydate_bd='2019012400',";
		s[4] = "hstart=00, hstop=03, hincbound=3, !";
		s[5] = "linitial=.TRUE.,";
		s[6] = "lboundaries =.TRUE., ";
		s[7] = "yinput_model='ICON',";
		s[8] = "ltime_mean=.TRUE., luvcor=.TRUE.,";
		s[9] = "nprocx=1, nprocy=20,";
		s[10] = "lreorder=.FALSE.,";
		s[11] = "lmulti_layer_in=.TRUE., lmulti_layer_lm=.TRUE.,";
		s[12] = "lprog_qi=.TRUE.,";
		s[13] = "lprog_rho_snow=.TRUE.,";
		s[14] = "lforest=.TRUE.,";
		s[15] = "itype_ndvi=0,";
		s[16] = "lprog_qr_qs=.TRUE.,";
		s[17] = "lvertwind_bd=.TRUE.,";
		s[18] = "lroutine=.TRUE.,";
		s[19] = "lfilter_pp=.TRUE.,";
		s[20] = "lbalance_pp=.TRUE., ";
		s[21] = "eps_filter=0.1, ";
		s[22] = "lfilter_oro=.TRUE., ";
		s[23] = "ilow_pass_oro=4, ilow_pass_xso=5, ";
		s[24] = "rxso_mask=625.0, ";
		s[25] = "idbg_level=2, ";
		s[26] = "llake=.TRUE.,  ";
		s[27] = "lseaice=.TRUE., ";
		s[28] = "lsso=.TRUE., ";
		s[29] = "lcheck_uuidOfHGrid=.FALSE., ";
		s[30] = "/ ";

		s[31] = "&GRID_IN ";
		s[32] = "ni_gme = 384, ";
		s[33] = "i3e_gme = 60, ";
		s[34] = "kcontrol_fi = 15, ";
		s[35] = "ke_soil_in=7, ";

		s[36] = "!------- new ICON parameters -------------- ";
		s[37] = "yicon_grid_cat = '/RHM-GPFS/users/oper/opercosmo/COSMO/extpar/ICON' ";
		s[38] = "yicon_grid_lfn = 'icon_grid_ENA_R03B07.nc' ";
		s[39] = "ke_in_tot = 90 ";
		s[40] = "nlevskip  = 20 ";
		s[41] = "nrootdiv_icon = 3 ";
		s[42] = "nbisect_icon = 7 ";
		s[43] = "!------------------------------------------ ";
		s[44] = "/ ";

		s[45] = "&LMGRID ";
		s[46] = "startlat_tot=-1.0,  startlon_tot=-33.0, ";
		s[47] = "pollat=25.0,            pollon=-90.0, ";
		s[48] = "dlon=0.06,           dlat=0.06, ";
		s[49] = "ielm_tot=280,     jelm_tot=220, ";
		s[50] = "kelm_tot=40, ";
		s[51] = "ke_soil_lm=7, ";
		s[52] = "ivctype=2, irefatm=2, ";
		s[53] = "/ "; 
		s[54] = "&DATABASE ";
		s[55] = "/ ";

		s[56] = "&DATA ";
		s[56] = "nprocess_ini = 02, nprocess_bd = 02, ";
		s[57] = "ncenter = 04, ";
		s[58] = "nl_soil_in=2, nl_soil_lm=2, ";
		s[59] = "ie_ext=284, je_ext=224, ";
		s[60] = "l_ke_in_gds=.t., ";
		s[61] = "ylmext_form_read='ncdf', ";
		s[62] = "ylmext_cat='/RHM-GPFS/users/cosmo/mnikitin/COSMO/INPUT/NWR/', ";
		s[63] = "ylmext_lfn='lmboden.nc', ";
		s[64] = "yinext_cat='/RHM-GPFS/users/oper/opercosmo/COSMO/extpar/ICON/2015012006', ";
		s[65] = "yinext_lfn=\"icon_extpar_ENA_R03B07_20141202.nc\", ";
		s[66] = "yin_hhl='icon_hhl_ENA_R03B07.g2' ";
		s[67] = "ybitmap_cat='', ";
		s[68] = "ybitmap_lfn=\"bitmp113\", ";
		s[69] = "yin_cat='/RHM-GPFS/users/cosmo/mnikitin/sefremov/Ravil/INPUT/NWR/2019012400', ";
		s[70] = "ylm_cat='/RHM-GPFS/users/cosmo/mnikitin/sefremov/Ravil/INPUT/NWR/2019012400', ";

		s[71] = "yinext_form_read ='ncdf' ";
		s[72] = "	yin_form_read='apix', ";
		s[73] = "ytunit_out='d', ";
		s[74] = "!!ylm_form_write='grb1', ";

		s[75] = "/ ";

		s[76] = "&PRICTR ";
		s[77] = "igp_tot = 36, 40, 48, 44, 48, 85, 77 ";
		s[78] = "jgp_tot = 30, 94, 38, 26, 26, 96, 12 ";
		s[79] = "lchkin=.TRUE., lchkout=.TRUE., ";
		s[80] = "lprps=.FALSE., ";
		s[81] = "	/ ";


	}
}
