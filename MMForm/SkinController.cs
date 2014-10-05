using System;

public class SkinController
{


    private bool isBodyNull = false;
    private bool isHeadNull = false;
    private bool isHandNull = true;
    private bool isHatNull = true;
    private bool isGlassNull = true;
    private bool isBearNull = true;
    private bool isSkirtNull = true;
    private bool isShirtNull = true;
    private bool isSecondWeaponNull = true;

    public int Chead = 0;
    public int Chat = 0;
    public int Cglass = 0;
    public int CBody = 0;
    public int Cbear = 0;
    public int Cshirt = 0;
    public int Cskirt = 0;
    public int Chand = 0;
    public int CSecond = 0;
    private static int MaxHeadNumber =6;
    private static int MaxHatNumber = 9;
    private static int MaxGlassNumber = 4;
    private static int MaxBodyNumber = 0;
    private static int MaxBearNumber = 4;
    private static int MaxShirtNumber = 3;
    private static int MaxSkirtNumber = 4;
    private static int MaxHandNumber = 3;
    private static int MaxSecondWeapon = 66;


    public void LoadSkin()
    {


    }

    /// <summary>
    /// body: head: hat: glass: bear: shirt: skirt
    /// </summary>
    /// <param name="skinstring">body: head: hat: glass: bear: shirt: skirt</param>
    public void SetSkin(string skinstring)
    {
        var sL = skinstring.Split(':');
        if (sL.Length == 7)
        {
            SetSkin(int.Parse(sL[0]), int.Parse(sL[1]), int.Parse(sL[2])
                , int.Parse(sL[3]), int.Parse(sL[4]), int.Parse(sL[5]), int.Parse(sL[6]));
        }
    }

    public string GetSkin()
    {
        return string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}", CBody, Chead, Chat, Cglass, Cbear, Cshirt, Cskirt);
    }

    public void SetSkin(SkinObject skin)
    {
        SetSkin(skin.body, skin.head, skin.hat, skin.glass, skin.bear, skin.shirt, skin.skirt);
    }
    public void SetSkin(int body, int head, int hat, int glass, int bear, int shirt, int skirt)
    {
        //SetHand(hand);
        SetBody(body);
        SetHead(head);
        SetGlass(glass);
        SetHat(hat);
        SetBear(bear);
        SetShirt(shirt);
        SetSkirt(skirt);
    }
    public void SetHand(int index)
    {
        if (index == -1 && isHandNull)
        {
            Chand = index;
        }
        else if (index >= 0 && index <= MaxHandNumber)
        {
            Chand = index;
        }
    }
    public void SetBear(int index)
    {
        if (index == -1 && isBearNull)
        {
            Cbear = index;
        }
        else if (index >= 0 && index <= MaxBearNumber)
        {
            Cbear = index;
        }
    }
    public void SetGlass(int index)
    {
        if (index == -1 && isGlassNull)
        {
            Cglass = index;
        }
        else if (index >= 0 && index <= MaxGlassNumber)
        {
            Cglass = index;
        }
    }
    public void SetHat(int index)
    {
        if (index == -1 && isHatNull)
        {
            Chat = index;
        }
        else if (index >= 0 && index <= MaxHatNumber)
        {
            Chat = index;
        }
    }
    public void SetShirt(int index)
    {
        if (index == -1 && isShirtNull)
        {
            Cshirt = index;
        }
        else if (index >= 0 && index <= MaxShirtNumber)
        {
            Cshirt = index;
        }
    }
    public void SetSkirt(int index)
    {
        if (index == -1 && isSkirtNull)
        {
            Cskirt = index;
        }
        else if (index >= 0 && index <= MaxSkirtNumber)
        {
            Cskirt = index;
        }
    }
    public void SetHead(int index)
    {
        if (index == -1 && isHeadNull)
        {
            Chead = index;
        }
        else if (index >= 0 && index <= MaxHeadNumber)
        {
            Chead = index;
        }
    }
    public void SetBody(int index)
    {

        if (index == -1 && isBodyNull)
        {
            CBody = index;
        }
        else if (index >= 0 && index <= MaxBodyNumber)
        {
            CBody = index;
        }
    }
    public void SetSecondWeapon(int index)
    {

        if (index == -1 && isSecondWeaponNull)
        {
            CSecond = index;
        }
        else if (index >= 0 && index <= MaxSecondWeapon)
        {
            CSecond = index;
        }
    }

    public static string RandomSkin()
    {
        return string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}", 0, new Random().Next(0,MaxHeadNumber), new Random().Next(-1,MaxHatNumber), new Random().Next(-1,MaxGlassNumber), new Random().Next(-1,MaxBearNumber), new Random().Next(-1,MaxShirtNumber), new Random().Next(0,MaxSkirtNumber));
    }

}

public class SkinObject
{
    public int body { get; set; }
    public int head { get; set; }
    public int hand { get; set; }
    public int hat { get; set; }
    public int bear { get; set; }
    public int glass { get; set; }
    public int shirt { get; set; }
    public int skirt { get; set; }

    public SkinObject()
    {
        body = 0;
        head = 0;
        hand = 0;
        hat = -1;
        bear = -1;
        glass = -1;
        skirt = -1;
        shirt = -1;
    }

    public static SkinObject Default
    {
        get { return new SkinObject(); }
    }
}
