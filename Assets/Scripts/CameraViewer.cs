using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CameraViewer : MonoBehaviour
{
    private const int Width = 352;
    private const int Height = 288;
    private const int FPS = 30;
    private WebCamTexture _webcamTexture;
    
    // TODO: 入力部分の設定
    private Texture2D _inputTexture;
    private Color32[] _inputColors;
    [SerializeField] private RawImage inputImage;
    
    // TODO: 出力部分の設定

    // カメラ起動後に初期設定実行
    IEnumerator Init()
    {
        while (true)
        {
            // カメラ起動したかどうか
            if (_webcamTexture.width > 16 && _webcamTexture.height > 16)
            {
                // 入力部分の設定
                _inputColors = new Color32[_webcamTexture.width * _webcamTexture.height];
                _inputTexture = new Texture2D(_webcamTexture.width, _webcamTexture.height, TextureFormat.RGBA32, false);
                inputImage.texture = _inputTexture;
                inputImage.material.mainTexture = _inputTexture;
                
                // TODO: 出力部分の設定
                
                break;
            }

            yield return null;
        }
    }

    void Start()
    {
        var devices = WebCamTexture.devices;
        _webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        _webcamTexture.Play();

        StartCoroutine(Init());
    }

    void Update()
    {
        if (_inputColors == null)
        {
            return;
        }

        // カメラ映像の画素配列を_inputColorsに代入
        _webcamTexture.GetPixels32(_inputColors);
        // TODO: 出力用の画素配列にもコピー
        

        // TODO: webcamTextureのサイズを取得
        var width = 0;
        var height = 0;

        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                var index = x + y * _webcamTexture.width;
                Color c = _inputColors[index];
                // TODO: 画素を変換(出力用の配列のindexに代入)
//                _ = ColorMap.PassThrough(c);
            }
        }

        // カメラ入力の画素群を入力用テクスチャに反映
        _inputTexture.SetPixels32(_inputColors);
        _inputTexture.Apply();
        
        // TODO: 色変換後の画素群を出力用テクスチャに反映
    }
}