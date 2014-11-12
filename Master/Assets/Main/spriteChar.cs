using UnityEngine;
using System.Collections;

public class spriteChar : MonoBehaviour {
	// 指定のスプライト番号でスプライトを動的に変更する
	public void SetChar(int idx) {
		string name = "Suuji_" + idx;
		SpriteRenderer sr = GetComponent<SpriteRenderer>();
		Sprite[] sprites = Resources.LoadAll<Sprite>("Suuji");
		Sprite sp = System.Array.Find<Sprite>(sprites, (sprite) => sprite.name.Equals(name));
		sr.sprite = sp;
	}
}