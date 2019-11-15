using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class errpanel : MonoBehaviour {
	public Text x;

	// Use this for initialization
	public void PutOk () {
		gameObject.SetActive (false);
	}

	public void SetError (string a)
	{
		x.text += a;
		x.text += "\n";
	}

	public void NULLError ()
	{
		x.text = "";
	}


}
