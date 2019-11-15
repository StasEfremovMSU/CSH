using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class input  {

	static int aoe_type;

	static public  int month; 
	static public int year;

	static public int wall_h; 
	static public int wall_m;

	static public int power1; 
	static public int power2; 
	static public int power3;


	static int day;
	static int h_start;
	static int h_stop;
	static int h_step;
	static int time_step;

	static string Area;

	static string path_to_person;
	static public string path_to_input;
	static public string path_to_output;
	static public string path_to_soft;
	static string path_to_archive;
	static public string path_to_serv;


	public static void create_path_input  ()
	{
		path_to_input = path_to_person + "INPUT/" + Area + "/" + input.get_data ();
	}
	public static void create_path_output  ()
	{
		path_to_output = path_to_person + "OUT/" + Area + "/" + input.get_data ();
	}

	public static string get_data ()
	{
		return year + myFormat.MakeNull(month) + myFormat.MakeNull(day);
	}
		
	public static string get_dat_with_hours ()
	{
		return get_data () + myFormat.MakeNull(h_start);
	}

	public static void Input_data (string y, string m, string d)
	{
		year = int.Parse (y);
		month = int.Parse (m);
		day = int.Parse (d);
	}

	public static void Input_h_times (string start, string stop, string step, string time_s)
	{
		h_start = int.Parse (start);
		h_stop = int.Parse (stop);
		h_step = int.Parse (step);
		time_step = int.Parse (time_s);
	}

	public static void Input_Area (int x)
	{
		switch (x)
		{
		case(1):
			Area = "NWR";
			break;
		case(2):
			Area = "ETR";
			break;
		default:
			Area = "NWR";
			break;
		}
	}

	public static void Input_path (string path_to_pers)
	{
		path_to_person = path_to_pers;
	}

}
