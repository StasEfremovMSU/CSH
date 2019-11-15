using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class parseStage1  {

	public static string[]  s;

	public static void ChangePath  () {
		s[15] = s [15] = "time -p " + input.path_to_serv  +" " + input.path_to_soft;;
	}

	public static void ChangeWalltime  () {
		s[6] = "#PBS -l walltime=" + myFormat.MakeNull (input.wall_h) +":" + myFormat.MakeNull (input.wall_m) + ":00";
	}

	public static void ChangeSpellPower  () {
		string x1 = myFormat.MakeNull (input.power1);
		string x2 = myFormat.MakeNull (input.power2);
		string x3 = myFormat.MakeNull (input.power3);
		s[6] =  "#PBS -l select=" + x1 + ":ncpus=" + x2 + ":mem=" + x3 + "G:mpiprocs=20";;
	}

	public static void ini ()
	{
		s = new string[16];

		s [1] = "#!/bin/bash -x";
		s [2] = "#PBS -l ctype=xicex";
		s [3] = "#";
		s [4] = "#PBS -l select=1:ncpus=20:mem=40G:mpiprocs=20";
		s [5] = "#PBS -N CI06_NWR";
		s [6] = "#PBS -l walltime=00:10:00";
		s [7] = "#PBS -o ./";
		s [8] = "#PBS -e ./";
		s [9] = "#PBS -W umask=22";

		s [10] = "LIBGRIBAPI=/RHM-GPFS/users/oper/opercosmo/COSMO/config/grib_api/1.11.0";
		s [11] = "export GRIB_DEFINITION_PATH=$LIBGRIBAPI/definitions.edzw:$LIBGRIBAPI/definitions";
		s [11] = "export GRIB_SAMPLES_PATH=$LIBGRIBAPI/samples";
		s [12] = "export LIBDWD_BITMAP_TYPE=ASCII";

		s [13] = "cd  $PBS_O_WORKDIR ; pwd";
		s [14] = "rm  YU* OUTPUT 2>/dev/null";

		s [15] = "time -p /RHM-GPFS/software/icex/sgi/mpt-2.08/bin/mpiexec_mpt /RHM-GPFS/users/cosmo/dblinov/software/bin/x86_64/int2cm_2.02_sgi";
	}
}
