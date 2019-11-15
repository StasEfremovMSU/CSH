using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static  class myfile  {
	public static string load () {
		try
		{
			using (StreamReader  reader1 = File.OpenText("F:\\INPUT1.txt"))
			{
				string s = reader1.ReadToEnd(); 	return  s;
			}
		}
		catch
		{
			Debug.Log ("Не могу загрузить input1");  	return null;
		}
	}


	public static void save (string x) {
		try
		{
			using (StreamWriter  writer1 = File.CreateText ("F:\\INPUT1.txt"))
			{
				writer1.WriteLine(x);
			}
		}
		catch
		{
			Debug.Log ("Не могу сохранить input1");
		}
	}
}
