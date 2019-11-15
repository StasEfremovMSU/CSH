using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class myFormat  {
	public static string MakeNull (int i) {
		if (i > 9) {
			return i.ToString ();
		} else {
			return ("0" + i.ToString ());
		}
	}
}
