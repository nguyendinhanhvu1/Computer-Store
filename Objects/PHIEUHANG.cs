using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Objects
{
   public class PHIEUHANG
    {
       public int ID_PHIEUHANG { get; set; }
       public DateTime NGAYLAP { get; set; }
       public int ID_NHANVIEN { get; set; }
       public BindingList<SANPHAM> LISTSP = new BindingList<SANPHAM>();
    }
}
