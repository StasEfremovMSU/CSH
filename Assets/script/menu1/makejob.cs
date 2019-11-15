using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class makejob : MonoBehaviour {

	public GameObject year;
	public GameObject month;
	public GameObject day;

	public GameObject h_start;
	public GameObject h_stop;
	public GameObject h_step;

	public GameObject time_step;
	public GameObject RAM1;
	public GameObject RAM2;
	public GameObject RAM3;


	public GameObject ErrorPanel;

	public GameObject PathText;

	public void  MakeMyJob ()
	{
		/*string x = myfile.load ();
		Debug.Log (x.Length);
		for (int i = 1; i < x.Length; i++) {
			Debug.Log (x[i] + " " + i);
		}
		myfile.save (x);*/
		if (exeption() == false) {

			// Перевести значения в структуру
			put_input_settings ();

			// Создать директорию для input
			sshcommands.my_make_folder (input.path_to_input, input.get_dat_with_hours());

			// Переместить файлы
			add_from_archive ();

			//Создать файлы INPUT
			parseInput1.ini ();
			parseInput1.ChangeData ();
			parseInput1.ChangePath ();
			sshcommands.my_save_txt (parseInput1.s,input.path_to_input );

			// Создать файлы sm_stage
			parseStage1.ini ();
			parseStage1.ChangePath ();
			parseStage1.ChangeWalltime ();
			parseStage1.ChangeSpellPower ();
			sshcommands.my_save_txt (parseStage1.s,input.path_to_input );

			// Запустить
			sshcommands.my_qsub (input.path_to_input, "cm_stage1.sh");

		} else {
			ErrorPanel.SetActive (true);
		}
	}


	void add_from_archive ()
	{
		// копировать с архива
		string arch = "/RHM-GPFS/user/grivin/DATA_ARCHIVE/" + input.year + "/" + myFormat.MakeNull(input.month) ;
		sshcommands.my_cp (arch, input.path_to_input, "igf*");
		// распаковать
		sshcommands.my_bzip_igf (input.path_to_input);
	}


	void put_input_settings()
	{
		input.Input_Area (main.Area);
		input.Input_data (year.GetComponent<Text> ().text, month.GetComponent<Text> ().text , day.GetComponent<Text> ().text);
		input.Input_h_times (h_start.GetComponent<Text> ().text, h_stop.GetComponent<Text> ().text , h_step.GetComponent<Text> ().text, time_step.GetComponent<Text> ().text); 
	}


	public void path_save_settings ()
	{
		input.Input_path (PathText.GetComponent<Text> ().text);
	}

	bool exeption()
	{
		ErrorPanel.GetComponent<errpanel> ().NULLError();

		bool x = false;

		try 
		{
			int.Parse (RAM3.GetComponent<Text> ().text);
		}
		catch {
			ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен память на каждом");
			x = true;
		}

		try 
		{
			int.Parse (RAM2.GetComponent<Text> ().text);
		}
		catch {
			ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен процессоры");
			x = true;
		}

		try 
		{
			int.Parse (RAM1.GetComponent<Text> ().text);
		}
		catch {
			ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен узлы");
			x = true;
		}


		try 
		{
			int.Parse (year.GetComponent<Text> ().text);
		}
		catch {
			ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен год");
			x = true;
		}

		try 
		{
			int.Parse (month.GetComponent<Text> ().text);

			if (int.Parse (month.GetComponent<Text> ().text) < 1) {
				x = true;
				ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен месяц");
			}

			if (int.Parse (month.GetComponent<Text> ().text) > 12) {
				x = true;
				ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен месяц");
			}

		}
		catch {
			ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен год");
			x = true;
		}


		try 
		{
			int.Parse (day.GetComponent<Text> ().text);


			if (int.Parse (day.GetComponent<Text> ().text) < 0) {
				x = true;
				ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен день");
			}

			if (int.Parse (day.GetComponent<Text> ().text) > 31) {
				x = true;
				ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен день");
			} 

		}
		catch {
			ErrorPanel.GetComponent<errpanel>().SetError("Некорректно введен день");
			x = true;
		}



		return x;
	}


	public void SetAreaNWR(bool x)
	{
		main.Area = 1;
	}

	public void SetAreaETR(bool x)
	{
		main.Area = 2;
	}
}
