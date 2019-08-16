using UnityEngine;
using UnityEngine.UI;

public class ImageViewer : MonoBehaviour
{
    [SerializeField] private RawImage inputImage;
    // TODO: ここに出力用のRawImageも用意

    // GameObjectにアタッチしている場合、実行時に1回呼ばれる
    void Start()
    {
        // 入力テクスチャの色情報を取得
        var inputTexture = (Texture2D) inputImage.mainTexture;
        
        // TODO: inputTextureの画像サイズを代入
        var width = 0;
        var height = 0;

        // 入力テクスチャの画素情報を取得
        var inputColors = inputTexture.GetPixels();

        // 画像処理を行う
        var outputTexture = new Texture2D(width, height);
        var outputColors = new Color[width * height];
        
        // 1画素ずつ処理
        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                // TODO: 処理対象の画素の位置を算出
//                var index = ;
                
                // 画素情報を取得
//                var c = inputColors[index];
                
                // TODO: 画素を変換(出力用の配列のindexに代入)
//                _ = ColorMap.PassThrough(c);
            }
        }

        // 変換した画素をテクスチャに反映
        outputTexture.SetPixels(outputColors);
        outputTexture.Apply();

        // TODO: 出力用のRawImageに生成したテクスチャを代入
    }
}