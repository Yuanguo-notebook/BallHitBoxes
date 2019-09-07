using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {
	Texture2D tex;
	void Start(){
		tex = Texture2D.whiteTexture;
	}
	public void generate(int row, int col){
		
		float width = 2.5f;
		float xStart = -col * width / 2f + width;
		float yStart = width / 2f +3;

		for (int i = 0; i < col; i++) {
			for (int j = 0; j < row; j++) {
				GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);

				box.transform.position = new Vector3 (xStart + i * width / 2f, yStart + j * width / 2f, width);
				box.AddComponent<Rigidbody> ();
				box.AddComponent<BoxCollider> ();

				Renderer rend = box.GetComponent<Renderer> ();
				rend.material.mainTexture = tex;
			}
		}
	}
}
