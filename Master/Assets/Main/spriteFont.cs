using UnityEngine;
using System.Collections;

public class spriteFont : MonoBehaviour {
	
	private static string _decode = "0123456789"; // 変換用文字列テーブル
	const float FONT_SIZE = 0.48f; // フォントサイズ。フォントのスケールやカメラの設定によって要調整
	
	// Use this for initialization
	void Start () {
		// テスト用
		SetText ("5813497620");
	}
	
	// 指定の文字でスプライトフォントを作成する
	public void SetText(string text) {
		int i = 0;
		
		foreach(char c in text) {
			GameObject obj = null;
			if(i < transform.childCount) {
				// 作成済みであればそれを使う
				obj = transform.GetChild(i).gameObject;
			}
			else {
				// SpriteCharをプレハブから取得
				GameObject prefab = Resources.Load ("SpriteChar") as GameObject;
				Vector3 pos = new Vector3(i * transform.localScale.x * FONT_SIZE, 0, 0);
				obj = Instantiate(prefab) as GameObject;
				// 子に設定する
				obj.transform.parent = transform;
				obj.transform.localPosition = pos;
				obj.transform.localScale = new Vector3(1, 1, 1);
			}
			
			// 文字を対応するスプライト番号に変換する
			int idx = _decode.IndexOf(c);
			
			// SpriteCharを取得してスプライトを変更する
			spriteChar sc = obj.GetComponent<spriteChar>();
			sc.SetChar(idx);
			i++;
		}
	}
}