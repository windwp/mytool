public sealed class GundataInfo
{

    public int Id { get; set; }
    public string Name { get; set; }
    /// <summary>
    /// Soluong vien dan
    /// </summary>
    public int BulletQuantity { get; set; }
    public int BulletType { get; set; }

    public int BulletPrefTab { get; set; }
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

}
