public sealed class GundataInfo
{

    public int Id { get; set; }
    public string Name { get; set; }
    /// <summary>
    /// Soluong vien dan
    /// </summary>
    public int BulletQuantity { get; set; }
    public int BulletType { get; set; }
    /// <summary>
    ///  1 phat thi tung ra bao nhieu vien dan nho? 
    /// </summary>
    public int OneShotNumBullet { get; set; }

    /// <summary>
    /// Goc' thay doi? khi ban' 1 vien dan. Neu' nhu 1 lan` ban' nhieu vien thi day la goc' phan tach' giua~ cac' vien
    /// </summary>
    public float AngleChange { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int BulletPrefTab { get; set; }
    /// <summary>
    /// hieu ung' khi ban' sung 1 la` ban' mau` vang 2 la co' lap' ong' giam? thanh ban' ra mau` trang'
    /// </summary>
    public int ShootEffectType { get; set; }
    public int ShootSpecialEffectType { get; set; }
    /// <summary>
    /// Toa. do x diem ban'
    /// </summary>
    public float Sx { get; set; }
    /// <summary>
    /// Toa. do y diem ban'
    /// </summary>
    public float Sy { get; set; }
    /// <summary>
    /// Thoi gian ban' 1 vien da.n
    /// </summary>
    public float TimeShootLimit { get; set; }
    /// <summary>
    /// Khoang cach tay cam` sung'
    /// </summary>
    public float Cx { get; set; }
    /// <summary>
    /// Khoang cach tay cam` sung'
    /// </summary>
    public float Cy { get; set; }

    /// <summary>
    /// Do. pha' huy?
    /// </summary>
    public float Damage { get; set; }
    /// <summary>
    /// Muc' do. day? nguoi` sau khi trung' dan.
    /// </summary>
    public float Force { get; set; }
    /// <summary>
    /// sung hay dao
    /// </summary>
    public bool IsGun { get; set; }

    /// <summary>
    /// Thoi gian cho hieu ung lui
    /// </summary>
    public float DelayEffect { get; set; }
    /// <summary>
    /// Khoang cach' cam` sung' tot't nhat' tu` -0.4 den 0.1
    /// doi voi sung' cam` 2 tay thi` nen cho gia' tri. am de tay sau cam sung' lui ve` sau nguoi`
    /// </summary>
    public float WeaponRadius { get; set; }
    /// <summary>
    /// Khoang cach tang them doi voi vu khi danh' can. chien'
    /// </summary>
    public float BeatDistance{ get; set; }
    /// <summary>
    /// Thoi` gian cho` nap. dan.
    /// </summary>
    public float ReloadBulletTime { get; set; }
    /// <summary>
    ///Pham vi dinh' dan. cua sung'
    /// </summary>
    public float BulletRadius { get; set; }
    /// <summary>
    /// File Am thanh
    /// </summary>
    public string SoundId { get; set; }

}
