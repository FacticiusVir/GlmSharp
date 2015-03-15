using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct swizzle_ivec4
    {
        public readonly int x;
        public readonly int y;
        public readonly int z;
        public readonly int w;
        
        public swizzle_ivec4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        public ivec4 xxxx => new ivec4(x, x, x, x);
        public ivec4 xxxy => new ivec4(x, x, x, y);
        public ivec4 xxxz => new ivec4(x, x, x, z);
        public ivec4 xxxw => new ivec4(x, x, x, w);
        public ivec3 xxx => new ivec3(x, x, x);
        public ivec4 xxyx => new ivec4(x, x, y, x);
        public ivec4 xxyy => new ivec4(x, x, y, y);
        public ivec4 xxyz => new ivec4(x, x, y, z);
        public ivec4 xxyw => new ivec4(x, x, y, w);
        public ivec3 xxy => new ivec3(x, x, y);
        public ivec4 xxzx => new ivec4(x, x, z, x);
        public ivec4 xxzy => new ivec4(x, x, z, y);
        public ivec4 xxzz => new ivec4(x, x, z, z);
        public ivec4 xxzw => new ivec4(x, x, z, w);
        public ivec3 xxz => new ivec3(x, x, z);
        public ivec4 xxwx => new ivec4(x, x, w, x);
        public ivec4 xxwy => new ivec4(x, x, w, y);
        public ivec4 xxwz => new ivec4(x, x, w, z);
        public ivec4 xxww => new ivec4(x, x, w, w);
        public ivec3 xxw => new ivec3(x, x, w);
        public ivec2 xx => new ivec2(x, x);
        public ivec4 xyxx => new ivec4(x, y, x, x);
        public ivec4 xyxy => new ivec4(x, y, x, y);
        public ivec4 xyxz => new ivec4(x, y, x, z);
        public ivec4 xyxw => new ivec4(x, y, x, w);
        public ivec3 xyx => new ivec3(x, y, x);
        public ivec4 xyyx => new ivec4(x, y, y, x);
        public ivec4 xyyy => new ivec4(x, y, y, y);
        public ivec4 xyyz => new ivec4(x, y, y, z);
        public ivec4 xyyw => new ivec4(x, y, y, w);
        public ivec3 xyy => new ivec3(x, y, y);
        public ivec4 xyzx => new ivec4(x, y, z, x);
        public ivec4 xyzy => new ivec4(x, y, z, y);
        public ivec4 xyzz => new ivec4(x, y, z, z);
        public ivec4 xyzw => new ivec4(x, y, z, w);
        public ivec3 xyz => new ivec3(x, y, z);
        public ivec4 xywx => new ivec4(x, y, w, x);
        public ivec4 xywy => new ivec4(x, y, w, y);
        public ivec4 xywz => new ivec4(x, y, w, z);
        public ivec4 xyww => new ivec4(x, y, w, w);
        public ivec3 xyw => new ivec3(x, y, w);
        public ivec2 xy => new ivec2(x, y);
        public ivec4 xzxx => new ivec4(x, z, x, x);
        public ivec4 xzxy => new ivec4(x, z, x, y);
        public ivec4 xzxz => new ivec4(x, z, x, z);
        public ivec4 xzxw => new ivec4(x, z, x, w);
        public ivec3 xzx => new ivec3(x, z, x);
        public ivec4 xzyx => new ivec4(x, z, y, x);
        public ivec4 xzyy => new ivec4(x, z, y, y);
        public ivec4 xzyz => new ivec4(x, z, y, z);
        public ivec4 xzyw => new ivec4(x, z, y, w);
        public ivec3 xzy => new ivec3(x, z, y);
        public ivec4 xzzx => new ivec4(x, z, z, x);
        public ivec4 xzzy => new ivec4(x, z, z, y);
        public ivec4 xzzz => new ivec4(x, z, z, z);
        public ivec4 xzzw => new ivec4(x, z, z, w);
        public ivec3 xzz => new ivec3(x, z, z);
        public ivec4 xzwx => new ivec4(x, z, w, x);
        public ivec4 xzwy => new ivec4(x, z, w, y);
        public ivec4 xzwz => new ivec4(x, z, w, z);
        public ivec4 xzww => new ivec4(x, z, w, w);
        public ivec3 xzw => new ivec3(x, z, w);
        public ivec2 xz => new ivec2(x, z);
        public ivec4 xwxx => new ivec4(x, w, x, x);
        public ivec4 xwxy => new ivec4(x, w, x, y);
        public ivec4 xwxz => new ivec4(x, w, x, z);
        public ivec4 xwxw => new ivec4(x, w, x, w);
        public ivec3 xwx => new ivec3(x, w, x);
        public ivec4 xwyx => new ivec4(x, w, y, x);
        public ivec4 xwyy => new ivec4(x, w, y, y);
        public ivec4 xwyz => new ivec4(x, w, y, z);
        public ivec4 xwyw => new ivec4(x, w, y, w);
        public ivec3 xwy => new ivec3(x, w, y);
        public ivec4 xwzx => new ivec4(x, w, z, x);
        public ivec4 xwzy => new ivec4(x, w, z, y);
        public ivec4 xwzz => new ivec4(x, w, z, z);
        public ivec4 xwzw => new ivec4(x, w, z, w);
        public ivec3 xwz => new ivec3(x, w, z);
        public ivec4 xwwx => new ivec4(x, w, w, x);
        public ivec4 xwwy => new ivec4(x, w, w, y);
        public ivec4 xwwz => new ivec4(x, w, w, z);
        public ivec4 xwww => new ivec4(x, w, w, w);
        public ivec3 xww => new ivec3(x, w, w);
        public ivec2 xw => new ivec2(x, w);
        public ivec4 yxxx => new ivec4(y, x, x, x);
        public ivec4 yxxy => new ivec4(y, x, x, y);
        public ivec4 yxxz => new ivec4(y, x, x, z);
        public ivec4 yxxw => new ivec4(y, x, x, w);
        public ivec3 yxx => new ivec3(y, x, x);
        public ivec4 yxyx => new ivec4(y, x, y, x);
        public ivec4 yxyy => new ivec4(y, x, y, y);
        public ivec4 yxyz => new ivec4(y, x, y, z);
        public ivec4 yxyw => new ivec4(y, x, y, w);
        public ivec3 yxy => new ivec3(y, x, y);
        public ivec4 yxzx => new ivec4(y, x, z, x);
        public ivec4 yxzy => new ivec4(y, x, z, y);
        public ivec4 yxzz => new ivec4(y, x, z, z);
        public ivec4 yxzw => new ivec4(y, x, z, w);
        public ivec3 yxz => new ivec3(y, x, z);
        public ivec4 yxwx => new ivec4(y, x, w, x);
        public ivec4 yxwy => new ivec4(y, x, w, y);
        public ivec4 yxwz => new ivec4(y, x, w, z);
        public ivec4 yxww => new ivec4(y, x, w, w);
        public ivec3 yxw => new ivec3(y, x, w);
        public ivec2 yx => new ivec2(y, x);
        public ivec4 yyxx => new ivec4(y, y, x, x);
        public ivec4 yyxy => new ivec4(y, y, x, y);
        public ivec4 yyxz => new ivec4(y, y, x, z);
        public ivec4 yyxw => new ivec4(y, y, x, w);
        public ivec3 yyx => new ivec3(y, y, x);
        public ivec4 yyyx => new ivec4(y, y, y, x);
        public ivec4 yyyy => new ivec4(y, y, y, y);
        public ivec4 yyyz => new ivec4(y, y, y, z);
        public ivec4 yyyw => new ivec4(y, y, y, w);
        public ivec3 yyy => new ivec3(y, y, y);
        public ivec4 yyzx => new ivec4(y, y, z, x);
        public ivec4 yyzy => new ivec4(y, y, z, y);
        public ivec4 yyzz => new ivec4(y, y, z, z);
        public ivec4 yyzw => new ivec4(y, y, z, w);
        public ivec3 yyz => new ivec3(y, y, z);
        public ivec4 yywx => new ivec4(y, y, w, x);
        public ivec4 yywy => new ivec4(y, y, w, y);
        public ivec4 yywz => new ivec4(y, y, w, z);
        public ivec4 yyww => new ivec4(y, y, w, w);
        public ivec3 yyw => new ivec3(y, y, w);
        public ivec2 yy => new ivec2(y, y);
        public ivec4 yzxx => new ivec4(y, z, x, x);
        public ivec4 yzxy => new ivec4(y, z, x, y);
        public ivec4 yzxz => new ivec4(y, z, x, z);
        public ivec4 yzxw => new ivec4(y, z, x, w);
        public ivec3 yzx => new ivec3(y, z, x);
        public ivec4 yzyx => new ivec4(y, z, y, x);
        public ivec4 yzyy => new ivec4(y, z, y, y);
        public ivec4 yzyz => new ivec4(y, z, y, z);
        public ivec4 yzyw => new ivec4(y, z, y, w);
        public ivec3 yzy => new ivec3(y, z, y);
        public ivec4 yzzx => new ivec4(y, z, z, x);
        public ivec4 yzzy => new ivec4(y, z, z, y);
        public ivec4 yzzz => new ivec4(y, z, z, z);
        public ivec4 yzzw => new ivec4(y, z, z, w);
        public ivec3 yzz => new ivec3(y, z, z);
        public ivec4 yzwx => new ivec4(y, z, w, x);
        public ivec4 yzwy => new ivec4(y, z, w, y);
        public ivec4 yzwz => new ivec4(y, z, w, z);
        public ivec4 yzww => new ivec4(y, z, w, w);
        public ivec3 yzw => new ivec3(y, z, w);
        public ivec2 yz => new ivec2(y, z);
        public ivec4 ywxx => new ivec4(y, w, x, x);
        public ivec4 ywxy => new ivec4(y, w, x, y);
        public ivec4 ywxz => new ivec4(y, w, x, z);
        public ivec4 ywxw => new ivec4(y, w, x, w);
        public ivec3 ywx => new ivec3(y, w, x);
        public ivec4 ywyx => new ivec4(y, w, y, x);
        public ivec4 ywyy => new ivec4(y, w, y, y);
        public ivec4 ywyz => new ivec4(y, w, y, z);
        public ivec4 ywyw => new ivec4(y, w, y, w);
        public ivec3 ywy => new ivec3(y, w, y);
        public ivec4 ywzx => new ivec4(y, w, z, x);
        public ivec4 ywzy => new ivec4(y, w, z, y);
        public ivec4 ywzz => new ivec4(y, w, z, z);
        public ivec4 ywzw => new ivec4(y, w, z, w);
        public ivec3 ywz => new ivec3(y, w, z);
        public ivec4 ywwx => new ivec4(y, w, w, x);
        public ivec4 ywwy => new ivec4(y, w, w, y);
        public ivec4 ywwz => new ivec4(y, w, w, z);
        public ivec4 ywww => new ivec4(y, w, w, w);
        public ivec3 yww => new ivec3(y, w, w);
        public ivec2 yw => new ivec2(y, w);
        public ivec4 zxxx => new ivec4(z, x, x, x);
        public ivec4 zxxy => new ivec4(z, x, x, y);
        public ivec4 zxxz => new ivec4(z, x, x, z);
        public ivec4 zxxw => new ivec4(z, x, x, w);
        public ivec3 zxx => new ivec3(z, x, x);
        public ivec4 zxyx => new ivec4(z, x, y, x);
        public ivec4 zxyy => new ivec4(z, x, y, y);
        public ivec4 zxyz => new ivec4(z, x, y, z);
        public ivec4 zxyw => new ivec4(z, x, y, w);
        public ivec3 zxy => new ivec3(z, x, y);
        public ivec4 zxzx => new ivec4(z, x, z, x);
        public ivec4 zxzy => new ivec4(z, x, z, y);
        public ivec4 zxzz => new ivec4(z, x, z, z);
        public ivec4 zxzw => new ivec4(z, x, z, w);
        public ivec3 zxz => new ivec3(z, x, z);
        public ivec4 zxwx => new ivec4(z, x, w, x);
        public ivec4 zxwy => new ivec4(z, x, w, y);
        public ivec4 zxwz => new ivec4(z, x, w, z);
        public ivec4 zxww => new ivec4(z, x, w, w);
        public ivec3 zxw => new ivec3(z, x, w);
        public ivec2 zx => new ivec2(z, x);
        public ivec4 zyxx => new ivec4(z, y, x, x);
        public ivec4 zyxy => new ivec4(z, y, x, y);
        public ivec4 zyxz => new ivec4(z, y, x, z);
        public ivec4 zyxw => new ivec4(z, y, x, w);
        public ivec3 zyx => new ivec3(z, y, x);
        public ivec4 zyyx => new ivec4(z, y, y, x);
        public ivec4 zyyy => new ivec4(z, y, y, y);
        public ivec4 zyyz => new ivec4(z, y, y, z);
        public ivec4 zyyw => new ivec4(z, y, y, w);
        public ivec3 zyy => new ivec3(z, y, y);
        public ivec4 zyzx => new ivec4(z, y, z, x);
        public ivec4 zyzy => new ivec4(z, y, z, y);
        public ivec4 zyzz => new ivec4(z, y, z, z);
        public ivec4 zyzw => new ivec4(z, y, z, w);
        public ivec3 zyz => new ivec3(z, y, z);
        public ivec4 zywx => new ivec4(z, y, w, x);
        public ivec4 zywy => new ivec4(z, y, w, y);
        public ivec4 zywz => new ivec4(z, y, w, z);
        public ivec4 zyww => new ivec4(z, y, w, w);
        public ivec3 zyw => new ivec3(z, y, w);
        public ivec2 zy => new ivec2(z, y);
        public ivec4 zzxx => new ivec4(z, z, x, x);
        public ivec4 zzxy => new ivec4(z, z, x, y);
        public ivec4 zzxz => new ivec4(z, z, x, z);
        public ivec4 zzxw => new ivec4(z, z, x, w);
        public ivec3 zzx => new ivec3(z, z, x);
        public ivec4 zzyx => new ivec4(z, z, y, x);
        public ivec4 zzyy => new ivec4(z, z, y, y);
        public ivec4 zzyz => new ivec4(z, z, y, z);
        public ivec4 zzyw => new ivec4(z, z, y, w);
        public ivec3 zzy => new ivec3(z, z, y);
        public ivec4 zzzx => new ivec4(z, z, z, x);
        public ivec4 zzzy => new ivec4(z, z, z, y);
        public ivec4 zzzz => new ivec4(z, z, z, z);
        public ivec4 zzzw => new ivec4(z, z, z, w);
        public ivec3 zzz => new ivec3(z, z, z);
        public ivec4 zzwx => new ivec4(z, z, w, x);
        public ivec4 zzwy => new ivec4(z, z, w, y);
        public ivec4 zzwz => new ivec4(z, z, w, z);
        public ivec4 zzww => new ivec4(z, z, w, w);
        public ivec3 zzw => new ivec3(z, z, w);
        public ivec2 zz => new ivec2(z, z);
        public ivec4 zwxx => new ivec4(z, w, x, x);
        public ivec4 zwxy => new ivec4(z, w, x, y);
        public ivec4 zwxz => new ivec4(z, w, x, z);
        public ivec4 zwxw => new ivec4(z, w, x, w);
        public ivec3 zwx => new ivec3(z, w, x);
        public ivec4 zwyx => new ivec4(z, w, y, x);
        public ivec4 zwyy => new ivec4(z, w, y, y);
        public ivec4 zwyz => new ivec4(z, w, y, z);
        public ivec4 zwyw => new ivec4(z, w, y, w);
        public ivec3 zwy => new ivec3(z, w, y);
        public ivec4 zwzx => new ivec4(z, w, z, x);
        public ivec4 zwzy => new ivec4(z, w, z, y);
        public ivec4 zwzz => new ivec4(z, w, z, z);
        public ivec4 zwzw => new ivec4(z, w, z, w);
        public ivec3 zwz => new ivec3(z, w, z);
        public ivec4 zwwx => new ivec4(z, w, w, x);
        public ivec4 zwwy => new ivec4(z, w, w, y);
        public ivec4 zwwz => new ivec4(z, w, w, z);
        public ivec4 zwww => new ivec4(z, w, w, w);
        public ivec3 zww => new ivec3(z, w, w);
        public ivec2 zw => new ivec2(z, w);
        public ivec4 wxxx => new ivec4(w, x, x, x);
        public ivec4 wxxy => new ivec4(w, x, x, y);
        public ivec4 wxxz => new ivec4(w, x, x, z);
        public ivec4 wxxw => new ivec4(w, x, x, w);
        public ivec3 wxx => new ivec3(w, x, x);
        public ivec4 wxyx => new ivec4(w, x, y, x);
        public ivec4 wxyy => new ivec4(w, x, y, y);
        public ivec4 wxyz => new ivec4(w, x, y, z);
        public ivec4 wxyw => new ivec4(w, x, y, w);
        public ivec3 wxy => new ivec3(w, x, y);
        public ivec4 wxzx => new ivec4(w, x, z, x);
        public ivec4 wxzy => new ivec4(w, x, z, y);
        public ivec4 wxzz => new ivec4(w, x, z, z);
        public ivec4 wxzw => new ivec4(w, x, z, w);
        public ivec3 wxz => new ivec3(w, x, z);
        public ivec4 wxwx => new ivec4(w, x, w, x);
        public ivec4 wxwy => new ivec4(w, x, w, y);
        public ivec4 wxwz => new ivec4(w, x, w, z);
        public ivec4 wxww => new ivec4(w, x, w, w);
        public ivec3 wxw => new ivec3(w, x, w);
        public ivec2 wx => new ivec2(w, x);
        public ivec4 wyxx => new ivec4(w, y, x, x);
        public ivec4 wyxy => new ivec4(w, y, x, y);
        public ivec4 wyxz => new ivec4(w, y, x, z);
        public ivec4 wyxw => new ivec4(w, y, x, w);
        public ivec3 wyx => new ivec3(w, y, x);
        public ivec4 wyyx => new ivec4(w, y, y, x);
        public ivec4 wyyy => new ivec4(w, y, y, y);
        public ivec4 wyyz => new ivec4(w, y, y, z);
        public ivec4 wyyw => new ivec4(w, y, y, w);
        public ivec3 wyy => new ivec3(w, y, y);
        public ivec4 wyzx => new ivec4(w, y, z, x);
        public ivec4 wyzy => new ivec4(w, y, z, y);
        public ivec4 wyzz => new ivec4(w, y, z, z);
        public ivec4 wyzw => new ivec4(w, y, z, w);
        public ivec3 wyz => new ivec3(w, y, z);
        public ivec4 wywx => new ivec4(w, y, w, x);
        public ivec4 wywy => new ivec4(w, y, w, y);
        public ivec4 wywz => new ivec4(w, y, w, z);
        public ivec4 wyww => new ivec4(w, y, w, w);
        public ivec3 wyw => new ivec3(w, y, w);
        public ivec2 wy => new ivec2(w, y);
        public ivec4 wzxx => new ivec4(w, z, x, x);
        public ivec4 wzxy => new ivec4(w, z, x, y);
        public ivec4 wzxz => new ivec4(w, z, x, z);
        public ivec4 wzxw => new ivec4(w, z, x, w);
        public ivec3 wzx => new ivec3(w, z, x);
        public ivec4 wzyx => new ivec4(w, z, y, x);
        public ivec4 wzyy => new ivec4(w, z, y, y);
        public ivec4 wzyz => new ivec4(w, z, y, z);
        public ivec4 wzyw => new ivec4(w, z, y, w);
        public ivec3 wzy => new ivec3(w, z, y);
        public ivec4 wzzx => new ivec4(w, z, z, x);
        public ivec4 wzzy => new ivec4(w, z, z, y);
        public ivec4 wzzz => new ivec4(w, z, z, z);
        public ivec4 wzzw => new ivec4(w, z, z, w);
        public ivec3 wzz => new ivec3(w, z, z);
        public ivec4 wzwx => new ivec4(w, z, w, x);
        public ivec4 wzwy => new ivec4(w, z, w, y);
        public ivec4 wzwz => new ivec4(w, z, w, z);
        public ivec4 wzww => new ivec4(w, z, w, w);
        public ivec3 wzw => new ivec3(w, z, w);
        public ivec2 wz => new ivec2(w, z);
        public ivec4 wwxx => new ivec4(w, w, x, x);
        public ivec4 wwxy => new ivec4(w, w, x, y);
        public ivec4 wwxz => new ivec4(w, w, x, z);
        public ivec4 wwxw => new ivec4(w, w, x, w);
        public ivec3 wwx => new ivec3(w, w, x);
        public ivec4 wwyx => new ivec4(w, w, y, x);
        public ivec4 wwyy => new ivec4(w, w, y, y);
        public ivec4 wwyz => new ivec4(w, w, y, z);
        public ivec4 wwyw => new ivec4(w, w, y, w);
        public ivec3 wwy => new ivec3(w, w, y);
        public ivec4 wwzx => new ivec4(w, w, z, x);
        public ivec4 wwzy => new ivec4(w, w, z, y);
        public ivec4 wwzz => new ivec4(w, w, z, z);
        public ivec4 wwzw => new ivec4(w, w, z, w);
        public ivec3 wwz => new ivec3(w, w, z);
        public ivec4 wwwx => new ivec4(w, w, w, x);
        public ivec4 wwwy => new ivec4(w, w, w, y);
        public ivec4 wwwz => new ivec4(w, w, w, z);
        public ivec4 wwww => new ivec4(w, w, w, w);
        public ivec3 www => new ivec3(w, w, w);
        public ivec2 ww => new ivec2(w, w);
    }
}