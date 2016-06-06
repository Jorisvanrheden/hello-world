using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {

	public GUIStyle style;

	private string word = "Hallo schatje, alles goed? 我想要你親我";
	private string write = "";

	void Start(){
		StartCoroutine ("test", 0);
	}


	void OnGUI(){
		GUI.TextArea (new Rect (100, 100, 100, 100), write, style);
	}

	IEnumerator test(int i){
		if (i < word.Length) {
			write += word [i];
			yield return new WaitForSeconds(0.05f);
			StartCoroutine("test", i+1);
		}
		yield break;
	}
}
