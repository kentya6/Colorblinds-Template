using UnityEngine;

// 入力されたRGB画素を変換
// 各変換式の参考: http://web.archive.org/web/20081014161121/http://www.colorjack.com/labs/colormatrix/
public class ColorMap
{
    // 受け取った値をそのまま返す
    public static Color PassThrough(Color c)
    {
        return new Color(c.r, c.g, c.b);
    }
    
    public static Color Deuteranomaly(Color c)
    {
        return new Color();
    }

    public static Color Deuteranopia(Color c)
    {
        return new Color();
    }

    public static Color Protanomaly(Color c)
    {
        return new Color();
    }

    // TODO: 最初はこれを実装してみてください
    public static Color Protanopia(Color c)
    {
        return new Color();
    }

    public static Color Tritanomaly(Color c)
    {
        return new Color();
    }

    public static Color Tritanopia(Color c)
    {
        return new Color();
    }

    public static Color Achromatomaly(Color c)
    {
        return new Color();
    }

    public static Color Achromatopsia(Color c)
    {
        return new Color();
    }
}