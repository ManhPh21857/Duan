﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
namespace _2.BUS.IServices
{
    public interface IChucVuService
    {
        bool Add(BangChucVu obj);
        bool Update(BangChucVu obj);
        bool Delete(BangChucVu obj);
        List<BangChucVu> GetAll();
    }
}
